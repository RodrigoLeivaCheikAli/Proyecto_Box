Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class EstadisticasVentas
    Dim conexion As SqlConnection = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
    Dim comando As SqlCommand
    Dim dr As SqlDataReader
    Dim Fechas As New List(Of DateTime)
    Dim Ventas As New List(Of Double)
    Dim Fechas2 As New List(Of DateTime)
    Dim Ventas2 As New List(Of Double)

    Private Sub EstadisticasVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrafVentas()
        GrafVentasColumn()
        LlenarGrilla()
    End Sub

    Private Sub LlenarGrilla()
        Try
            ' Asegúrate de inicializar el comando antes de usarlo
            comando = New SqlCommand()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "EstadisticaVentasGrill"

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                DataGridView1.AutoGenerateColumns = True
                DataGridView1.Columns.Clear()
                DataGridView1.DataSource = oDs.Tables(0)

                ' Ajuste de columnas
                DataGridView1.Columns("Cliente").Width = 300
                DataGridView1.Columns("Fecha").Width = 200
                DataGridView1.Columns("Total").Width = 200
                DataGridView1.Columns("Descripcion").Width = 150

                If DataGridView1.Columns.Contains("Total") Then
                    Dim columnaPrecio As DataGridViewColumn = DataGridView1.Columns("Total")
                    columnaPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    columnaPrecio.DefaultCellStyle.Format = "C2"
                End If
            Else
                MessageBox.Show("No se encontraron datos.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub GrafVentas()
        Try
            comando = New SqlCommand("EstadisticaVentas", conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()
            dr = comando.ExecuteReader()

            While dr.Read()
                Fechas.Add(dr.GetDateTime(0))
                Ventas.Add(dr.GetDouble(1))
            End While

            ChartVentas.Series(0).Points.DataBindXY(Fechas, Ventas)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dr.Close()
            conexion.Close()
        End Try
    End Sub

    Public Sub GrafVentasColumn()
        Try
            comando = New SqlCommand("EstadisticaVentasColumn", conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()
            dr = comando.ExecuteReader()

            Fechas2.Clear()
            Ventas2.Clear()

            While dr.Read()
                Fechas2.Add(dr.GetString(0))
                Ventas2.Add(dr.GetDouble(1))
            End While

            ChartVentas2.Series(0).Points.DataBindXY(Fechas2, Ventas2)

            Dim chartArea As ChartArea = ChartVentas2.ChartAreas(0)
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Months
            chartArea.AxisX.Interval = 1
            chartArea.AxisX.LabelStyle.Format = "yyyy-MM"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            dr.Close()
            conexion.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Verificar que el índice de la fila sea válido
        If e.RowIndex < 0 Then Return

        ' Obtener el DataTable del DataGridView
        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)

        ' Obtener el valor de IdPresupuesto desde la primera columna
        Dim idPresupuesto As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

        ' Verificar si la fila ya está expandida
        If DataGridView1.Rows(e.RowIndex).Tag IsNot Nothing AndAlso DataGridView1.Rows(e.RowIndex).Tag.ToString() = "Expanded" Then
            ' Colapsar: Eliminar las filas expandidas desde abajo hacia arriba
            For i As Integer = DataGridView1.Rows.Count - 1 To e.RowIndex + 1 Step -1
                If DataGridView1.Rows(i).Tag IsNot Nothing AndAlso DataGridView1.Rows(i).Tag.ToString() = "Detail" Then
                    dt.Rows(i).Delete()
                End If
            Next

            ' Restaurar la fila principal a su estado original
            DataGridView1.Rows(e.RowIndex).Tag = Nothing
            DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        Else
            ' Expandir: Conectar a la base de datos y ejecutar el procedimiento almacenado
            Dim connectionString As String = "data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123"
            Dim query As String = "EstadisticaVentasGrill2"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@IdPresupuesto", idPresupuesto)

                    Dim adapter As New SqlDataAdapter(command)
                    Dim resultTable As New DataTable()
                    adapter.Fill(resultTable)

                    ' Verificar que se obtuvieron datos
                    If resultTable.Rows.Count > 0 Then
                        ' Marcar la fila principal como expandida
                        DataGridView1.Rows(e.RowIndex).Tag = "Expanded"
                        DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray

                        ' Agregar una fila para los encabezados del sub-DataGridView
                        Dim headerRow As DataRow = dt.NewRow()

                        ' Asignar valores apropiados para el encabezado; las celdas de tipo Int32 se dejan vacías o se asigna un valor compatible

                        headerRow("Cliente") = "Productos"
                        headerRow("Descripcion") = "Cantidad"

                        ' Insertar la fila de encabezado en la posición deseada
                        dt.Rows.InsertAt(headerRow, e.RowIndex + 1)

                        ' Cambiar el estilo de la fila de encabezado del sub-DataGridView
                        DataGridView1.Rows(e.RowIndex + 1).Tag = "Detail"
                        DataGridView1.Rows(e.RowIndex + 1).DefaultCellStyle.BackColor = Color.SteelBlue
                        DataGridView1.Rows(e.RowIndex + 1).DefaultCellStyle.ForeColor = Color.White
                        DataGridView1.Rows(e.RowIndex + 1).DefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)
                        ' Agregar filas de detalle al DataTable subyacente
                        Dim insertIndex As Integer = e.RowIndex + 2 ' Iniciar después de la fila de encabezado
                        For Each detailRow As DataRow In resultTable.Rows
                            Dim newRow As DataRow = dt.NewRow()

                            newRow("N°") = detailRow("Id_Detalle_Venta")
                            newRow("Cliente") = detailRow("Descripcion")
                            newRow("Descripcion") = detailRow("Cantidad_Venta")

                            ' Insertar la nueva fila en la posición deseada en el DataTable
                            dt.Rows.InsertAt(newRow, insertIndex)
                            ' Cambiar el color de la fila recién insertada
                            DataGridView1.Rows(insertIndex).Tag = "Detail"
                            DataGridView1.Rows(insertIndex).DefaultCellStyle.BackColor = Color.LightBlue
                            insertIndex += 1 ' Aumentar el índice para insertar la siguiente fila debajo de la última añadida
                        Next
                    Else
                        MessageBox.Show("No se encontraron datos para el IdPresupuesto proporcionado.")
                    End If
                End Using
            End Using
        End If
    End Sub



End Class

