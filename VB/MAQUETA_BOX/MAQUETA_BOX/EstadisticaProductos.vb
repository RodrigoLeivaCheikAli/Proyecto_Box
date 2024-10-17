Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class EstadisticaProductos
    Dim conexion As SqlConnection = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
    Dim dr As SqlDataReader
    Dim comando As New SqlCommand

    Private Sub EstadisticaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarRentabilidadPorProducto()
    End Sub

    Public Sub MostrarRentabilidadPorProducto()
        comando = New SqlCommand("RentabilidadPorProducto", conexion)
        comando.CommandType = CommandType.StoredProcedure

        Try
            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            ' Limpiar el DataGridView antes de mostrar los nuevos datos
            DataGridView1.Rows.Clear()

            While reader.Read()
                Dim row As String() = New String() {
                    reader("Id_Oferta").ToString(),
                    reader("Descripcion").ToString(),
                    reader("Precio_Costo").ToString(),
                    reader("Ganancia").ToString(),
                    reader("Cantidad").ToString(),
                    reader("Rentabilidad").ToString(),
                    reader("Ganancia_Total").ToString(),
                    reader("Costo_Total").ToString()
                }
                DataGridView1.Rows.Add(row)
            End While
        Catch ex As Exception
            MessageBox.Show("Error al cargar rentabilidad por producto: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub ProyeccionDemandaPorProducto(productoID As Integer, productoNombre As String)
        Try
            ' Obtener ventas históricas
            comando = New SqlCommand("Est_VentasHistoricasPorProducto", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@ProductoID", productoID)
            conexion.Open()
            dr = comando.ExecuteReader()

            Dim Fechas As New List(Of DateTime)()
            Dim Cantidades As New List(Of Integer)()

            While dr.Read()
                Fechas.Add(dr.GetDateTime(0))
                Cantidades.Add(dr.GetInt32(1))
            End While
            dr.Close()

            ' Verificar si hay datos históricos
            If Cantidades.Count = 0 Then
                MessageBox.Show("No hay datos históricos de ventas para este producto.")
                Return ' Salir del método si no hay datos
            End If

            ' Aplicar regresión lineal
            Dim n As Integer = Fechas.Count
            Dim sumX As Double = Fechas.Select(Function(f) f.ToOADate()).Sum()
            Dim sumY As Double = Cantidades.Sum()
            Dim sumXY As Double = Fechas.Select(Function(f, i) f.ToOADate() * Cantidades(i)).Sum()
            Dim sumX2 As Double = Fechas.Select(Function(f) f.ToOADate() * f.ToOADate()).Sum()

            Dim slope As Double = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX)
            Dim intercept As Double = (sumY - slope * sumX) / n

            ' Proyección de demanda
            Dim fechaActual As DateTime = DateTime.Now.Date
            Dim FechasProyeccion As New List(Of DateTime)(Fechas)
            Dim CantidadesProyeccion As New List(Of Integer)(Cantidades)

            ' Proyectar datos para los próximos meses
            For i As Integer = 1 To 3 ' Proyección de 3 meses, ajustable
                Dim fechaProyeccion As DateTime = Fechas.Last().AddMonths(i)
                Dim mesProyeccion As Double = fechaProyeccion.ToOADate()
                Dim cantidadProyectada As Double = intercept + slope * mesProyeccion
                ' Evitar valores negativos
                If cantidadProyectada < 0 Then cantidadProyectada = 0
                FechasProyeccion.Add(fechaProyeccion)
                CantidadesProyeccion.Add(CInt(cantidadProyectada))
            Next

            ' Graficar ventas históricas
            Dim seriesHistoricas As New Series("Ventas Históricas")
            seriesHistoricas.ChartType = SeriesChartType.Area
            seriesHistoricas.Points.DataBindXY(Fechas, Cantidades)
            seriesHistoricas.Color = Color.FromArgb(128, Color.Blue)
            seriesHistoricas.BorderWidth = 3

            ' Graficar proyección
            Dim seriesProyeccion As New Series("Proyección de Demanda")
            seriesProyeccion.ChartType = SeriesChartType.Area
            seriesProyeccion.Points.DataBindXY(FechasProyeccion, CantidadesProyeccion)
            seriesProyeccion.Color = Color.FromArgb(128, Color.Red)
            seriesProyeccion.BorderWidth = 3

            ' Limpiar series anteriores para evitar superposiciones
            chartProyeccion.Series.Clear()
            chartProyeccion.Series.Add(seriesHistoricas)
            chartProyeccion.Series.Add(seriesProyeccion)

            ' Mejorar la visibilidad del gráfico
            chartProyeccion.ChartAreas(0).AxisX.LabelStyle.Format = "dd/MM/yyyy"
            chartProyeccion.ChartAreas(0).RecalculateAxesScale()

            ' Agregar título al gráfico
            chartProyeccion.Titles.Clear() ' Limpiar títulos anteriores si hay
            chartProyeccion.Titles.Add("Proyección de Demanda de: " & productoNombre)
            chartProyeccion.Titles(0).Font = New Font("Arial", 14, FontStyle.Bold) ' Establecer fuente y estilo

        Catch ex As Exception
            MessageBox.Show("Se produjo un error: " & ex.Message)
        Finally
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub







    ' Evento para manejar clic en el DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then ' Asegúrate de que se ha hecho clic en una fila válida
            Dim idOferta As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(0).Value) ' Obtener el Id_Oferta de la fila seleccionada
            Dim nombreProd As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            ProyeccionDemandaPorProducto(idOferta, nombreProd) ' Llamar al procedimiento con el Id_Oferta
        End If
    End Sub
End Class
