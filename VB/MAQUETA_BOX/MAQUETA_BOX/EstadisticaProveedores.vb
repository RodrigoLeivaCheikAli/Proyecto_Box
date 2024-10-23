Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class EstadisticaProveedores
    Dim conexion As SqlConnection = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
    Dim comando As SqlCommand
    Dim dr As SqlDataReader
    Private isShowingProducts As Boolean = False

    Private Sub EstadisticaProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCantidadProductosPorProveedor()
    End Sub
    Public Sub MostrarCantidadProductosPorProveedor()
        comando = New SqlCommand("Est_CantidadProductosPorProveedor", conexion)
        comando.CommandType = CommandType.StoredProcedure

        Try
            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            Dim proveedores As New List(Of String)()
            Dim cantidades As New List(Of Integer)()

            While reader.Read()
                proveedores.Add(reader("Proveedor").ToString())
                cantidades.Add(Convert.ToInt32(reader("CantidadProductos")))
            End While

            ' Configurar el gráfico
            chartProveedores.Series.Clear() ' Limpiar series existentes

            Dim series As New Series("Cantidad de Productos")
            series.ChartType = SeriesChartType.Bar ' Tipo de gráfico de barras
            series.Points.DataBindXY(proveedores, cantidades)
            series.Palette = ChartColorPalette.BrightPastel
            series.IsValueShownAsLabel = True
            series.CustomProperties = "BarLabelStyle=Center"
            series.LabelForeColor = Color.White
            series.Font = New Font("Arial", 20, FontStyle.Bold)

            ' Agregar la serie al gráfico
            chartProveedores.Series.Add(series)

            ' Configurar el área del gráfico
            chartProveedores.ChartAreas(0).AxisX.MajorGrid.Enabled = False ' Ocultar líneas de cuadrícula en el eje X
            chartProveedores.ChartAreas(0).AxisY.MajorGrid.Enabled = False ' Ocultar líneas de cuadrícula en el eje Y



            ' Agregar título al gráfico
            chartProveedores.Titles.Clear()
            chartProveedores.Titles.Add("Cantidad de Productos por Proveedor")

            ' Cambiar el estado al mostrar productos
            isShowingProducts = False

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub



    ' Método para mostrar productos por proveedor
    Public Sub MostrarProductosPorProveedorEnChart(proveedorNombre As String)
        Dim comando As New SqlCommand("Est_ProductosPorProveedor", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@ProveedorNombre", proveedorNombre)

        Try
            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            ' Limpiar el gráfico de productos
            chartProveedores.Series.Clear()

            ' Crear una nueva serie para los productos
            Dim series As New Series("Productos")
            series.ChartType = SeriesChartType.Bar
            series.Palette = ChartColorPalette.BrightPastel
            series.IsValueShownAsLabel = True
            series.CustomProperties = "BarLabelStyle=Center"
            series.LabelForeColor = Color.White
            series.Font = New Font("Arial", 10, FontStyle.Bold)

            While reader.Read()
                Dim productoNombre As String = reader("Descripcion").ToString()
                Dim cantidad As Integer = Convert.ToInt32(reader("Cantidad"))

                ' Verificar si la cantidad es mayor que cero antes de agregar al gráfico
                If cantidad > 0 Then
                    ' Imprimir los valores para depuración
                    Debug.WriteLine($"Producto: {productoNombre}, Cantidad: {cantidad}")

                    ' Agregar puntos a la serie
                    series.Points.AddXY(productoNombre, cantidad)
                End If
            End While

            ' Solo agregar la serie si hay datos
            If series.Points.Count > 0 Then
                ' Agregar la serie de productos al gráfico
                chartProveedores.Series.Add(series)

                ' Ajustar el límite máximo del eje X

                ' Configurar el área del gráfico
                chartProveedores.Titles.Clear()
                chartProveedores.Titles.Add($"Productos del Proveedor: {proveedorNombre}")

                ' Configurar el eje X

                chartProveedores.ChartAreas(0).AxisX.Interval = 1 ' Mostrar cada etiqueta
            Else
                MessageBox.Show("No hay productos disponibles para este proveedor.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub



    ' Evento que maneja el clic en las barras del gráfico de productos
    ' Evento que maneja el clic en el gráfico
    Private Sub chartProveedores_MouseDown(sender As Object, e As MouseEventArgs) Handles chartProveedores.MouseDown
        Dim resultadoHit As HitTestResult = chartProveedores.HitTest(e.X, e.Y)

        If resultadoHit.ChartElementType = ChartElementType.DataPoint Then
            Dim punto As DataPoint = chartProveedores.Series(0).Points(resultadoHit.PointIndex)

            If Not isShowingProducts Then
                ' Llamar al procedimiento para mostrar productos del proveedor
                Dim proveedorNombre As String = punto.AxisLabel
                MostrarProductosPorProveedorEnChart(proveedorNombre)
                isShowingProducts = True ' Cambiar estado a productos
            Else
                ' Llamar al procedimiento para mostrar la rentabilidad y costo
                Dim productoNombre As String = punto.AxisLabel
                MostrarRentabilidadYCosto(productoNombre)
            End If
        Else
            MostrarCantidadProductosPorProveedor()
        End If
    End Sub




    ' Método para mostrar la relación de rentabilidad y costo en un gráfico de doughnut
    Public Sub MostrarRentabilidadYCosto(productoNombre As String)
        Dim comando As New SqlCommand("Est_RentabilidadYCostoPorProducto", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@ProductoNombre", productoNombre)

        Try
            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            ' Limpiar el gráfico de doughnut
            chartRentabilidadCosto.Series.Clear()

            ' Crear una nueva serie para rentabilidad y costo
            Dim serieDoughnut As New Series("Rentabilidad y Costo")
            serieDoughnut.ChartType = SeriesChartType.Doughnut

            While reader.Read()
                Dim costo As Decimal = Convert.ToDecimal(reader("Precio_Costo"))
                Dim rentabilidad As Decimal = Convert.ToDecimal(reader("Rentabilidad"))

                ' Agregar puntos a la serie
                serieDoughnut.Points.AddXY("Costo", costo)
                serieDoughnut.Points.AddXY("Rentabilidad", rentabilidad)

                ' Etiquetas

            End While
            serieDoughnut.Palette = ChartColorPalette.BrightPastel
            serieDoughnut.IsValueShownAsLabel = True
            serieDoughnut.CustomProperties = "BarLabelStyle=Center"
            serieDoughnut.LabelForeColor = Color.White
            serieDoughnut.Font = New Font("Arial", 10, FontStyle.Bold)
            ' Agregar la serie de doughnut al gráfico
            chartRentabilidadCosto.Series.Add(serieDoughnut)

            ' Configurar el área del gráfico
            chartRentabilidadCosto.Titles.Clear()
            chartRentabilidadCosto.Titles.Add($"Relación de Rentabilidad y Costo de {productoNombre}")

        Catch ex As Exception
            MessageBox.Show("Error al cargar la relación: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' Evento que maneja el clic en las barras del gráfico de productos
    Private Sub chartProductos_MouseDown(sender As Object, e As MouseEventArgs) Handles chartProveedores.MouseDown
        Dim resultadoHit As HitTestResult = chartProveedores.HitTest(e.X, e.Y)

        If resultadoHit.ChartElementType = ChartElementType.DataPoint Then
            Dim punto As DataPoint = chartProveedores.Series(0).Points(resultadoHit.PointIndex)
            Dim productoNombre As String = punto.AxisLabel

            ' Llamar al procedimiento para mostrar la rentabilidad y costo en un gráfico de doughnut
            MostrarRentabilidadYCosto(productoNombre)

        End If
    End Sub


End Class

