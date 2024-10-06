Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing.Printing

Public Class EstadisticaVentas
    Dim conexion As SqlConnection = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
    Dim comando As SqlCommand
    Dim dr As SqlDataReader
    Dim Fechas As New List(Of DateTime)
    Dim Ventas As New List(Of Double)
    Dim Fechas2 As New List(Of DateTime)
    Dim Ventas2 As New List(Of Double)
    Private currentRowIndex As Integer = 0
    Private panelImpreso As Boolean = False

    Private Sub EstadisticaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                ' Redondea el valor a 2 decimales y lo agrega a la lista de Ventas
                Ventas.Add(Math.Round(dr.GetDouble(1)))
            End While

            ' Asigna los datos al gráfico y formatea los puntos
            ChartVentas.Series(0).Points.DataBindXY(Fechas, Ventas)

            ' Formatea los puntos del gráfico para mostrar el símbolo de moneda
            For Each point As DataVisualization.Charting.DataPoint In ChartVentas.Series(0).Points
                point.Label = String.Format("{0:C2}", point.YValues(0))
            Next
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
                ' Redondea el valor a 2 decimales y lo agrega a la lista de Ventas2
                Ventas2.Add(Math.Round(dr.GetDouble(1), 2))
            End While

            ChartVentas2.Series(0).Points.DataBindXY(Fechas2, Ventas2)

            ' Formatea los puntos del gráfico para mostrar el símbolo de moneda
            For Each point As DataVisualization.Charting.DataPoint In ChartVentas2.Series(0).Points
                point.Label = String.Format("{0:C2}", point.YValues(0))
            Next

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


    Private Sub FiltrarPresupuestosPorFecha(fecha As DateTime)
        Try
            comando = New SqlCommand("EstadisticaFiltrarPorFecha", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@Fecha", fecha)

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                DataGridView1.DataSource = oDs.Tables(0)
            Else
                MessageBox.Show("No se encontraron presupuestos para la fecha seleccionada.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub



    Private Sub ChartVentas2_MouseClick(sender As Object, e As MouseEventArgs) Handles ChartVentas2.MouseClick
        Dim resultadoHitTest As HitTestResult = ChartVentas2.HitTest(e.X, e.Y)

        ' Verifica si se hizo clic en un punto de la serie
        If resultadoHitTest.ChartElementType = ChartElementType.DataPoint Then
            ' Obtén el punto clickeado
            Dim punto As DataPoint = ChartVentas2.Series(0).Points(resultadoHitTest.PointIndex)

            ' Obtén la fecha del punto clickeado (usando Fechas2 que está sincronizada con el gráfico)
            Dim fechaSeleccionada As DateTime = Fechas2(resultadoHitTest.PointIndex)

            ' Llama al método para filtrar los presupuestos por la fecha seleccionada
            FiltrarPresupuestosPorFecha(fechaSeleccionada)
        End If
    End Sub

    Private Sub ChartVentas_Click(sender As Object, e As EventArgs) Handles ChartVentas.Click
        LlenarGrilla()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            ' Verificar que el índice de la fila sea válido
            If e.RowIndex < 0 Then Return

            ' Obtener el DataTable del DataGridView
            Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)

            ' Obtener el valor de IdPresupuesto desde la primera columna
            Dim idPresupuesto As Integer

            If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(0).Value) Then

                Return
            Else
                idPresupuesto = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            End If

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
                            DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White

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

                        End If
                    End Using
                End Using
            End If
        Catch ex As InvalidCastException

        Catch ex As Exception

        End Try
    End Sub

    Public Sub ExportarFormularioAPDF()
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf Me.PrintPage

        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument
        printDialog.PrinterSettings.PrinterName = "Microsoft Print To PDF"

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
        LlenarGrilla()
    End Sub

    Private Sub PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Tamaño y posición del panel en el PDF
        Dim panelWidth As Integer = Panel2.Width
        Dim panelHeight As Integer = Panel2.Height

        ' Margen superior e izquierdo
        Dim marginX As Integer = e.MarginBounds.Left
        Dim marginY As Integer = e.MarginBounds.Top

        ' Imprimir el Panel solo una vez
        If Not panelImpreso Then
            ' Capturar el Panel con los gráficos
            Dim panelBitmap As New Bitmap(panelWidth, panelHeight)
            Panel2.DrawToBitmap(panelBitmap, New Rectangle(0, 0, panelWidth, panelHeight))
            e.Graphics.DrawImage(panelBitmap, marginX, marginY)

            ' Dejar un espacio debajo del panel antes de empezar con el DataGridView
            Dim spacing As Integer = 20
            marginY += panelHeight + spacing

            ' Marcar el panel como impreso para que no se imprima en las siguientes páginas
            panelImpreso = True
        End If

        ' Variables para manejar el dibujo del DataGridView
        Dim cellHeight As Integer = 30
        Dim cellWidth As Integer
        Dim startX As Integer = marginX
        Dim availableHeight As Integer = e.MarginBounds.Height - marginY ' Altura restante para el DataGridView

        ' Dibujar encabezados del DataGridView (solo en la primera página de impresión)
        If currentRowIndex = 0 Then
            startX = marginX
            For Each column As DataGridViewColumn In DataGridView1.Columns
                cellWidth = column.Width
                e.Graphics.FillRectangle(Brushes.SteelBlue, New Rectangle(startX, marginY, cellWidth, cellHeight)) ' Fondo de encabezado
                e.Graphics.DrawString(column.HeaderText, DataGridView1.Font, Brushes.White, startX + 5, marginY + 5) ' Texto del encabezado
                startX += cellWidth
            Next
            marginY += cellHeight ' Avanzar a la siguiente línea después de los encabezados
        End If

        ' Dibujar filas del DataGridView
        startX = marginX
        While currentRowIndex < DataGridView1.Rows.Count
            Dim row As DataGridViewRow = DataGridView1.Rows(currentRowIndex)

            ' Verificar si hay suficiente espacio para la fila actual
            If marginY + cellHeight > e.MarginBounds.Bottom Then
                ' No hay suficiente espacio, saltar a la siguiente página
                e.HasMorePages = True
                Exit Sub
            End If
            ' Dibujar las celdas de la fila
            startX = marginX
            For Each cell As DataGridViewCell In row.Cells
                cellWidth = DataGridView1.Columns(cell.ColumnIndex).Width

                ' Dibuja el fondo de la celda
                Dim brush As Brush = New SolidBrush(row.DefaultCellStyle.BackColor)
                e.Graphics.FillRectangle(brush, New Rectangle(startX, marginY, cellWidth, cellHeight)) ' Fondo de la celda
                e.Graphics.DrawRectangle(Pens.Black, startX, marginY, cellWidth, cellHeight) ' Dibuja el borde de la celda

                ' Formatear la celda si es la columna de precio
                If DataGridView1.Columns(cell.ColumnIndex).Name = "Total" Then
                    Dim precio As Decimal
                    If Decimal.TryParse(cell.Value?.ToString(), precio) Then
                        e.Graphics.DrawString(precio.ToString("C2"), DataGridView1.Font, Brushes.Black, startX + 5, marginY + 5) ' Dibuja el texto con formato de precio
                    Else
                        e.Graphics.DrawString(cell.Value?.ToString(), DataGridView1.Font, Brushes.Black, startX + 5, marginY + 5) ' Dibuja el texto sin formatear
                    End If
                ElseIf DataGridView1.Columns(cell.ColumnIndex).Name = "Fecha" Then
                    Dim fecha As DateTime
                    If DateTime.TryParse(cell.Value?.ToString(), fecha) Then
                        e.Graphics.DrawString(fecha.ToString("dd/MM/yyyy"), DataGridView1.Font, Brushes.Black, startX + 5, marginY + 5) ' Dibuja el texto con formato de fecha
                    Else
                        e.Graphics.DrawString(cell.Value?.ToString(), DataGridView1.Font, Brushes.Black, startX + 5, marginY + 5) ' Dibuja el texto sin formatear
                    End If
                Else
                    e.Graphics.DrawString(cell.Value?.ToString(), DataGridView1.Font, Brushes.Black, startX + 5, marginY + 5) ' Dibuja el texto para otras columnas
                End If

                startX += cellWidth
            Next


            ' Moverse a la siguiente fila
            marginY += cellHeight
            currentRowIndex += 1
        End While

        ' Si no hay más filas, detener el proceso de impresión
        e.HasMorePages = False
    End Sub


    Public Sub ExpandAllRows()
        Try
            ' Obtener el DataTable del DataGridView
            Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)

            ' Recorrer cada fila del DataGridView en orden inverso (de abajo hacia arriba)
            For i As Integer = DataGridView1.Rows.Count - 1 To 0 Step -1
                ' Obtener los detalles para cada fila
                Dim detailsTable As DataTable = GetDetailsForRow(i)

                ' Verificar que se obtuvieron datos
                If detailsTable.Rows.Count > 0 Then
                    ' Marcar la fila principal como expandida
                    DataGridView1.Rows(i).Tag = "Expanded"
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White

                    ' Agregar una fila para los encabezados del sub-DataGridView
                    Dim headerRow As DataRow = dt.NewRow()
                    headerRow("Cliente") = "Productos"
                    headerRow("Descripcion") = "Cantidad"

                    ' Insertar la fila de encabezado en la posición deseada
                    dt.Rows.InsertAt(headerRow, i + 1)

                    ' Cambiar el estilo de la fila de encabezado del sub-DataGridView
                    DataGridView1.Rows(i + 1).Tag = "Detail"
                    DataGridView1.Rows(i + 1).DefaultCellStyle.BackColor = Color.SteelBlue
                    DataGridView1.Rows(i + 1).DefaultCellStyle.ForeColor = Color.White
                    DataGridView1.Rows(i + 1).DefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)

                    ' Agregar filas de detalle al DataTable subyacente
                    Dim insertIndex As Integer = i + 2 ' Iniciar después de la fila de encabezado
                    For Each detailRow As DataRow In detailsTable.Rows
                        Dim newRow As DataRow = dt.NewRow()

                        ' Rellenar las columnas de detalle con los datos del DataTable obtenido
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
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Function GetDetailsForRow(rowIndex As Integer) As DataTable
        ' Obtener el valor de IdPresupuesto desde la primera columna
        Dim idPresupuesto As Integer = Convert.ToInt32(DataGridView1.Rows(rowIndex).Cells(0).Value)

        ' Configuración de la conexión y el comando para obtener los detalles
        Dim connectionString As String = "data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123"
        Dim query As String = "EstadisticaVentasGrill2"

        ' Realizar la consulta a la base de datos
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@IdPresupuesto", idPresupuesto)

                Dim adapter As New SqlDataAdapter(command)
                Dim resultTable As New DataTable()
                adapter.Fill(resultTable)

                ' Devolver el DataTable con los detalles
                Return resultTable
            End Using
        End Using
    End Function


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label.Click
        ExpandAllRows()
        ExportarFormularioAPDF()
    End Sub
End Class