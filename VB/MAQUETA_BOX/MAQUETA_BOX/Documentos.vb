﻿Imports System.Data.SqlClient
Imports System.Configuration
Imports DocumentFormat.OpenXml.Spreadsheet
Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Vml.Office
Imports DocumentFormat.OpenXml
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Documentos

    Private AñoBisiesto As Boolean = False
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Dim nombreApellido As Object = Nothing
    Dim descripcion As Object = Nothing
    Dim año As Object = Nothing
    Dim mes As Object = Nothing
    Dim dia As Object = Nothing
    Dim estado As Object = Nothing

#Region "load"

    Public Sub Documentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarGrilla()
        CargarCBOClientes()
        CargarCbosAño()
        CargarCboMes()
        CargarCbosEstado()
        CargarCbosDescripcion()
        cboDia1.Enabled = False
        cboMes1.Enabled = False
    End Sub

#End Region

    Public Sub CargarCbosEstado()
        cboEstado1.Items.Clear()

        Dim estados() As String = {"Pedido", "Realizado", "Presupuesto"}

        For Each estado As String In estados
            cboEstado1.Items.Add(estado)
        Next
    End Sub

    Public Sub CargarCbosDescripcion()
        cboDescripcion1.Items.Clear()

        Dim Descripciones() As String = {"Efectivo", "Debito", "Credito"}

        For Each Descripcion As String In Descripciones
            cboDescripcion1.Items.Add(Descripcion)
        Next
    End Sub

    Public Sub CargarCbosAño()
        Dim Año As Integer = 2022
        cboAño1.Items.Clear()
        For i As Integer = 0 To 10
            cboAño1.Items.Add((Año + i).ToString())
        Next
    End Sub

    Public Sub CargarCboMes()
        cboMes1.Items.Clear()
        cboMes1.Items.AddRange(New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
    End Sub






    Public Sub CargarCboDiasAñoNormal()
        cboDia1.Items.Clear()

        Dim DiasDelMes As Integer

        Select Case cboMes1.Text
            Case "Enero", "Marzo", "Mayo", "Julio", "Agosto", "Octubre", "Diciembre"
                DiasDelMes = 31
            Case "Abril", "Junio", "Septiembre", "Noviembre"
                DiasDelMes = 30
            Case "Febrero"
                DiasDelMes = 28
            Case Else
                DiasDelMes = 0
        End Select

        For i As Integer = 1 To DiasDelMes
            cboDia1.Items.Add(i.ToString())
        Next
    End Sub

    Public Sub CargarCboDiasAñoBisiesto()
        cboDia1.Items.Clear()
        Dim DiasDelMes As Integer

        Select Case cboMes1.Text
            Case "Enero", "Marzo", "Mayo", "Julio", "Agosto", "Octubre", "Diciembre"
                DiasDelMes = 31
            Case "Abril", "Junio", "Septiembre", "Noviembre"
                DiasDelMes = 30
            Case "Febrero"
                DiasDelMes = 29
            Case Else
                DiasDelMes = 0
        End Select

        For i As Integer = 1 To DiasDelMes
            cboDia1.Items.Add(i.ToString())
        Next
    End Sub

#Region "Llenar Grilla"

    Private Sub LlenarGrilla(Optional ByVal Nombre_Apellido As Object = Nothing,
                         Optional ByVal Descripcion As Object = Nothing,
                         Optional ByVal Dia As Object = Nothing,
                         Optional ByVal Mes As Object = Nothing,
                         Optional ByVal Año As Object = Nothing)
        Try
            DataGridView1.Columns.Clear()
            conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
            conexion.Open()
            comando = New SqlCommand("Consultar_Sortear_Presupuesto", conexion)
            comando.CommandType = CommandType.StoredProcedure

            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@Nombre_Apellido", If(Nombre_Apellido Is Nothing, DBNull.Value, Nombre_Apellido))
            comando.Parameters.AddWithValue("@Descripcion", If(Descripcion Is Nothing, DBNull.Value, Descripcion))
            comando.Parameters.AddWithValue("@Dia", If(Dia Is Nothing, DBNull.Value, Dia))
            comando.Parameters.AddWithValue("@Mes", If(Mes Is Nothing, DBNull.Value, Mes))
            comando.Parameters.AddWithValue("@Año", If(Año Is Nothing, DBNull.Value, Año))

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                DataGridView1.AutoGenerateColumns = True
                DataGridView1.DataSource = oDs.Tables(0)
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error al llenar la grilla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

#End Region

#Region "Cargar Cbo"

    Private Sub CargarCBOClientes()
        Try
            conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
            comando = New SqlCommand("cargar_CBO_clientes", conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()

            Dim reader As SqlDataReader = comando.ExecuteReader()
            cboClientes1.Items.Clear()

            While reader.Read()
                cboClientes1.Items.Add(reader("Nombre_Apellido"))
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub


#End Region

#Region "Filtrar Grilla"

    Private Sub FiltrarGrilla()
        Dim dataset As New DataSet()

        Try
            DataGridView1.Columns.Clear()
            conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
            conexion.Open()

            comando = New SqlCommand()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Consultar_Sortear_Presupuesto"

            comando.Parameters.Clear()

            ' Diccionario de meses
            Dim meses As New Dictionary(Of String, Integer) From {
            {"Enero", 1}, {"Febrero", 2}, {"Marzo", 3}, {"Abril", 4},
            {"Mayo", 5}, {"Junio", 6}, {"Julio", 7}, {"Agosto", 8},
            {"Septiembre", 9}, {"Octubre", 10}, {"Noviembre", 11}, {"Diciembre", 12}
        }

            ' Nombre_Apellido parameter
            Dim nombreApellido As Object = If(cboClientes1.SelectedItem Is Nothing OrElse cboClientes1.SelectedItem.ToString() = "Cliente", DBNull.Value, cboClientes1.SelectedItem.ToString())
            comando.Parameters.AddWithValue("@Nombre_Apellido", nombreApellido)

            ' Mes parameter
            Dim mes As Object = If(cboMes1.SelectedItem Is Nothing OrElse cboMes1.SelectedItem.ToString() = "Mes", DBNull.Value, DBNull.Value)

            ' Descripcion parameter
            Dim descripcion As Object = If(cboDescripcion1.SelectedItem Is Nothing OrElse cboDescripcion1.SelectedItem.ToString() = "Descripcion", DBNull.Value, cboDescripcion1.SelectedItem.ToString())
            comando.Parameters.AddWithValue("@Descripcion", descripcion)

            ' Dia parameter
            Dim dia As Object = If(cboDia1.SelectedItem Is Nothing OrElse cboDia1.SelectedItem.ToString() = "Día", DBNull.Value, Convert.ToInt32(cboDia1.SelectedItem))
            comando.Parameters.AddWithValue("@Dia", dia)

            ' Si hay un mes válido, lo obtengo del diccionario
            If cboMes1.SelectedItem IsNot Nothing AndAlso meses.ContainsKey(cboMes1.SelectedItem.ToString()) Then
                mes = meses(cboMes1.SelectedItem.ToString())
            End If
            comando.Parameters.AddWithValue("@Mes", mes)

            ' Año parameter
            Dim año As Object = If(cboAño1.SelectedItem Is Nothing OrElse cboAño1.SelectedItem.ToString() = "Año", DBNull.Value, Convert.ToInt32(cboAño1.SelectedItem))
            comando.Parameters.AddWithValue("@Año", año)

            ' Estado parameter
            Dim estado As Object = If(cboEstado1.SelectedItem Is Nothing OrElse cboEstado1.SelectedItem.ToString() = "Estado", DBNull.Value, cboEstado1.SelectedItem.ToString())
            comando.Parameters.AddWithValue("@Estado", estado)

            ' Ejecutar el comando y llenar el dataset
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(dataset)

            ' Vincular los datos al DataGridView
            If dataset.Tables.Count > 0 AndAlso dataset.Tables(0).Rows.Count > 0 Then
                DataGridView1.DataSource = dataset.Tables(0)
            Else
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar documentos del proveedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

#End Region

#Region "CBO Cargar Dias Del Mes"
    Private Sub CargarDiasDelMes()

        cboDia1.Items.Clear()

        Dim AñoSeleccionado As Integer
        If Not Integer.TryParse(cboAño1.Text, AñoSeleccionado) Then
            MessageBox.Show("Por favor, selecciona un año válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim MesSeleccionado As Integer = cboMes1.SelectedIndex + 1

        If MesSeleccionado <= 0 OrElse MesSeleccionado > 12 Then
            MessageBox.Show("Por favor, selecciona un mes válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtiene la cantidad de días en el mes seleccionado
        Dim DiasEnElMes As Integer = DateTime.DaysInMonth(AñoSeleccionado, MesSeleccionado)

        ' Rellena el ComboBox con los días del mes
        For i As Integer = 1 To DiasEnElMes
            cboDia1.Items.Add(i.ToString())
        Next

    End Sub

#End Region

#Region "Exportar"

    Private Sub btnExportar1_Click(sender As Object, e As EventArgs) Handles btnExportar1.Click
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim dataTable As New DataTable()
        For Each column As DataGridViewColumn In DataGridView1.Columns
            dataTable.Columns.Add(column.HeaderText, column.ValueType)
        Next

        ' Create a list to track rows that are expanded
        Dim expandedRows As New HashSet(Of Integer)()

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim dataRow As DataRow = dataTable.NewRow()
                For Each column As DataGridViewColumn In DataGridView1.Columns
                    dataRow(column.HeaderText) = row.Cells(column.Index).Value
                Next
                dataTable.Rows.Add(dataRow)

                ' Check if the row is expanded
                If row.Tag IsNot Nothing AndAlso row.Tag.ToString() = "Expanded" Then
                    expandedRows.Add(dataTable.Rows.Count - 1) ' Track expanded rows
                End If
            End If
        Next

        Try
            Dim workbook As New XLWorkbook()
            Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Datos")

            ' Insert the DataTable into the worksheet
            worksheet.Cell(1, 1).InsertTable(dataTable)

            ' Apply colors and font styles to the cells
            Dim table = worksheet.Tables.First()
            For i As Integer = 1 To table.Rows.Count
                Dim row = worksheet.Row(i + 1) ' +1 because data starts from row 2 in Excel

                For j As Integer = 1 To table.Columns.Count
                    Dim cell = row.Cell(j)

                    ' Set font color to black for all cells and make text bold
                    cell.Style.Font.FontColor = XLColor.Black
                    cell.Style.Font.Bold = True

                    ' Set cell background color based on row and content
                    If i = 1 Then ' Header row
                        cell.Style.Fill.BackgroundColor = XLColor.SteelBlue
                        cell.Style.Font.FontColor = XLColor.White
                    ElseIf expandedRows.Contains(i - 1) Then
                        cell.Style.Fill.BackgroundColor = XLColor.LightGray
                    Else
                        cell.Style.Fill.BackgroundColor = XLColor.LightBlue
                    End If

                    ' Ensure cells with no data do not have a white background
                    If String.IsNullOrWhiteSpace(cell.Value.ToString()) Then
                        cell.Style.Fill.BackgroundColor = XLColor.White
                    End If
                Next

                ' Special handling for the second row if it's empty
                If i = 2 AndAlso row.Cells.All(Function(c) String.IsNullOrWhiteSpace(c.Value.ToString())) Then
                    row.Style.Fill.BackgroundColor = XLColor.Black
                    row.Style.Font.FontColor = XLColor.White
                End If
            Next

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
            saveFileDialog.Title = "Guardar archivo Excel"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                workbook.SaveAs(saveFileDialog.FileName)
                MessageBox.Show("Datos exportados exitosamente.", "Exportación completada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al exportar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region




    Private Sub btnCargarTodo1_Click(sender As Object, e As EventArgs) Handles btnCargarTodo1.Click

        cboMes1.Enabled = False
        cboDia1.Enabled = False

        ' Restablece los valores seleccionados de los ComboBox
        cboClientes1.SelectedIndex = -1
        cboDescripcion1.SelectedIndex = -1
        cboEstado1.SelectedIndex = -1
        cboDia1.SelectedIndex = -1
        cboMes1.SelectedIndex = -1
        cboAño1.SelectedIndex = -1

        cboClientes1.Text = "Cliente"
        cboAño1.Text = "Año"
        cboMes1.Text = "Mes"
        cboDia1.Text = "Día"
        cboDescripcion1.Text = "Descripcion"
        cboEstado1.Text = "Estado"

        nombreApellido = Nothing
        descripcion = Nothing
        año = Nothing
        mes = Nothing
        dia = Nothing
        estado = Nothing

        FiltrarGrilla()

    End Sub

    Private Sub cboClientes1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClientes1.SelectedIndexChanged
        FiltrarGrilla()
    End Sub

    Private Sub cboAño1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAño1.SelectedIndexChanged
        ' Verifica si el texto de cboAño no es "Año" y no está vacío
        If cboAño1.Text <> "Año" AndAlso Not String.IsNullOrEmpty(cboAño1.Text) Then
            Dim AñoSeleccionado As Integer

            ' Intenta convertir el texto a un número entero
            If Integer.TryParse(cboAño1.Text, AñoSeleccionado) Then
                AñoBisiesto = DateTime.IsLeapYear(AñoSeleccionado)
                FiltrarGrilla()

                ' Habilita el ComboBox de Mes y deshabilita el de Día
                cboMes1.Enabled = True
                cboMes1.Text = "Mes"
                cboDia1.Text = "Día"
                cboDia1.Enabled = False
            Else
                ' Manejo en caso de que la conversión falle
                MessageBox.Show("El año ingresado no es válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Si el texto es "Año" o está vacío, deshabilita los ComboBox de Mes y Día
            cboMes1.Enabled = False
            cboMes1.Text = "Mes"
            cboDia1.Enabled = False
            cboDia1.Text = "Día"
        End If
    End Sub

    Private Sub cboDia1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDia1.SelectedIndexChanged
        FiltrarGrilla()
    End Sub

    Private Sub cboMes1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMes1.SelectedIndexChanged
        If cboMes1.SelectedIndex > -1 AndAlso cboMes1.Text <> "Mes" Then
            FiltrarGrilla()
            cboDia1.Enabled = True
            CargarDiasDelMes()
        Else
            cboDia1.Enabled = False
            cboDia1.Text = "Día"
        End If
    End Sub

    Private Sub cboDescripcion1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDescripcion1.SelectedIndexChanged
        FiltrarGrilla()
    End Sub

    Private Sub cboEstado1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado1.SelectedIndexChanged
        FiltrarGrilla()
    End Sub

#Region "Cell Content Double Click"

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            ' Verificar que el índice de la fila sea válido
            If e.RowIndex < 0 Then Return

            ' Obtener el DataTable del DataGridView
            Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)

            ' Obtener el valor de IdPresupuesto desde la primera columna
            Dim id_Presupuesto As Integer

            If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(0).Value) Then
                Return
            Else
                id_Presupuesto = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
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
                'DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            Else
                ' Expandir: Conectar a la base de datos y ejecutar el procedimiento almacenado
                Dim connectionString As String = "data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123"
                Dim query As String = "EstadisticaVentasGrill2"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.CommandType = CommandType.StoredProcedure
                        command.Parameters.AddWithValue("@IdPresupuesto", id_Presupuesto)

                        Dim adapter As New SqlDataAdapter(command)
                        Dim resultTable As New DataTable()
                        adapter.Fill(resultTable)

                        ' Verificar que se obtuvieron datos
                        If resultTable.Rows.Count > 0 Then
                            ' Marcar la fila principal como expandida
                            DataGridView1.Rows(e.RowIndex).Tag = "Expanded"
                            'DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray

                            ' Agregar una fila para los encabezados del sub-DataGridView
                            Dim headerRow As DataRow = dt.NewRow()
                            headerRow("Cliente") = "Producto"
                            headerRow("Descripcion") = "Cantidad"

                            ' Insertar la fila de encabezado en la posición deseada
                            dt.Rows.InsertAt(headerRow, e.RowIndex + 1)

                            ' Cambiar el estilo de la fila de encabezado del sub-DataGridView
                            DataGridView1.Rows(e.RowIndex + 1).Tag = "Detail"
                            'DataGridView1.Rows(e.RowIndex + 1).DefaultCellStyle.BackColor = Color.SteelBlue
                            'DataGridView1.Rows(e.RowIndex + 1).DefaultCellStyle.ForeColor = Color.White
                            'DataGridView1.Rows(e.RowIndex + 1).DefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)

                            ' Agregar filas de detalle al DataTable subyacente
                            Dim insertIndex As Integer = e.RowIndex + 2 ' Iniciar después de la fila de encabezado
                            For Each detailRow As DataRow In resultTable.Rows
                                Dim newRow As DataRow = dt.NewRow()
                                newRow("Cliente") = detailRow("Descripcion") ' Producto
                                newRow("Descripcion") = detailRow("Cantidad_Venta") ' Cantidad

                                ' Insertar la nueva fila en la posición deseada en el DataTable
                                dt.Rows.InsertAt(newRow, insertIndex)
                                ' Cambiar el color de la fila recién insertada
                                DataGridView1.Rows(insertIndex).Tag = "Detail"
                                'zzDataGridView1.Rows(insertIndex).DefaultCellStyle.BackColor = Color.LightBlue
                                insertIndex += 1 ' Aumentar el índice para insertar la siguiente fila debajo de la última añadida
                            Next

                        End If
                    End Using
                End Using
            End If
        Catch ex As InvalidCastException
            ' Manejo de la excepción InvalidCastException
        Catch ex As Exception
            ' Manejo de cualquier otra excepción
        End Try
    End Sub

#End Region

#Region "Eliminar"

    Private selectedPresupuestoId As Integer

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Verificar si la celda seleccionada es válida y que no sea una fila de detalle
        If e.RowIndex >= 0 AndAlso (DataGridView1.Rows(e.RowIndex).Tag Is Nothing OrElse DataGridView1.Rows(e.RowIndex).Tag.ToString() <> "Detail") Then
            ' Obtener el ID del presupuesto seleccionado de la primera columna
            selectedPresupuestoId = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Using connection As New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
            Using command As New SqlCommand("EliminarPresupuestoDocumentos", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@Id_Presupuesto", selectedPresupuestoId)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("File deleted successfully.")
                        ' Optionally, refresh the grid to reflect the deletion
                        LlenarGrilla()
                    Else
                        MessageBox.Show("No record was deleted.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

    End Sub

#End Region

End Class