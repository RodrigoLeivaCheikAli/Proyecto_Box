Imports System.Data.SqlClient
Imports System.Configuration
Imports DocumentFormat.OpenXml.Spreadsheet
Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Vml.Office

Public Class Documentos

    Private AñoBisiesto As Boolean = False
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

#Region "load"

    Public Sub Documentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarGrilla()
        CargarCBOClientes()
        CargarCbosAño()
        CargarCboMes()
        cboDia.Enabled = False
        cboMes.Enabled = False
    End Sub

#End Region

    Public Sub CargarCbosAño()
        Dim Año As Integer = 2000
        cboAño.Items.Clear()
        For i As Integer = 0 To 50
            cboAño.Items.Add((Año + i).ToString())
        Next
    End Sub

    Public Sub CargarCboMes()
        cboMes.Items.Clear()
        cboMes.Items.AddRange(New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
    End Sub

    Public Sub CargarCboDiasAñoNormal()
        cboDia.Items.Clear()

        Dim DiasDelMes As Integer

        Select Case cboMes.Text
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
            cboDia.Items.Add(i.ToString())
        Next
    End Sub

    Public Sub CargarCboDiasAñoBisiesto()
        cboDia.Items.Clear()
        Dim DiasDelMes As Integer

        Select Case cboMes.Text
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
            cboDia.Items.Add(i.ToString())
        Next
    End Sub

#Region "Llenar Grilla"

    Private Sub LlenarGrilla(Optional ByVal Nombre_Apellido As Object = Nothing,
                         Optional ByVal Descripcion As Object = Nothing,
                         Optional ByVal Dia As Object = Nothing,
                         Optional ByVal Mes As Object = Nothing,
                         Optional ByVal Año As Object = Nothing)
        Try
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
            cboClientes.Items.Clear()

            While reader.Read()
                cboClientes.Items.Add(reader("Nombre_Apellido"))
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

    Private Sub FiltrarGrilla()
        If cboClientes.SelectedItem IsNot Nothing Then
            Dim dataset As New DataSet()

            Try
                conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
                conexion.Open()

                comando = New SqlCommand()
                comando.Connection = conexion
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandText = "Consultar_Sortear_Presupuesto"

                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@Nombre_Apellido", If(cboClientes.SelectedItem.ToString() = "Ninguno", DBNull.Value, cboClientes.SelectedItem.ToString()))

                ' Convertir valores de los ComboBox a enteros o DBNull
                Dim año As Object = If(cboAño.SelectedItem Is Nothing OrElse cboAño.SelectedItem.ToString() = "Ninguno", DBNull.Value, Convert.ToInt32(cboAño.SelectedItem))

                ' Mapa para convertir los nombres de los meses a números
                Dim meses As New Dictionary(Of String, Integer) From {
                {"Enero", 1}, {"Febrero", 2}, {"Marzo", 3}, {"Abril", 4},
                {"Mayo", 5}, {"Junio", 6}, {"Julio", 7}, {"Agosto", 8},
                {"Septiembre", 9}, {"Octubre", 10}, {"Noviembre", 11}, {"Diciembre", 12}
            }

                Dim mes As Object
                If cboMes.SelectedItem Is Nothing OrElse cboMes.SelectedItem.ToString() = "Ninguno" Then
                    mes = DBNull.Value
                ElseIf meses.ContainsKey(cboMes.SelectedItem.ToString()) Then
                    mes = meses(cboMes.SelectedItem.ToString())
                Else
                    mes = DBNull.Value
                End If

                Dim dia As Object = If(cboDia.SelectedItem Is Nothing OrElse cboDia.SelectedItem.ToString() = "Ninguno", DBNull.Value, Convert.ToInt32(cboDia.SelectedItem))

                comando.Parameters.AddWithValue("@Año", año)
                comando.Parameters.AddWithValue("@Mes", mes)
                comando.Parameters.AddWithValue("@Dia", dia)

                Dim adapter As New SqlDataAdapter(comando)
                adapter.Fill(dataset)

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
        End If
    End Sub





#Region "Exportar"

    Public Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim dataTable As New DataTable()
        For Each column As DataGridViewColumn In DataGridView1.Columns
            dataTable.Columns.Add(column.HeaderText, column.ValueType)
        Next

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim dataRow As DataRow = dataTable.NewRow()
                For Each column As DataGridViewColumn In DataGridView1.Columns
                    dataRow(column.HeaderText) = row.Cells(column.Index).Value
                Next
                dataTable.Rows.Add(dataRow)
            End If
        Next

        Try
            Dim workbook As New XLWorkbook()
            Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Datos")
            worksheet.Cell(1, 1).InsertTable(dataTable)

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

    Private Sub cboClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClientes.SelectedIndexChanged
        If cboClientes.Text <> "Cliente" Or cboClientes.Text <> "Deseleccionado" Then
            FiltrarGrilla()
        End If
    End Sub

    Public Sub cboAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAño.SelectedIndexChanged
        If cboAño.Text <> "Año" Then
            Dim AñoSeleccionado As Integer = Integer.Parse(cboAño.Text)
            AñoBisiesto = DateTime.IsLeapYear(AñoSeleccionado)
            FiltrarGrilla()

            cboMes.Enabled = True
            cboMes.Text = "Mes"
            cboDia.Text = "Día"
            cboDia.Enabled = False
        Else
            cboMes.Enabled = False
            cboMes.Text = "Mes"
            cboDia.Enabled = False
            cboDia.Text = "Día"
        End If
    End Sub

    Private Sub cboMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMes.SelectedIndexChanged
        If cboMes.Text <> "Mes" Then
            FiltrarGrilla()
            cboDia.Enabled = True
            CargarDiasDelMes()
        Else
            cboDia.Enabled = False
            cboDia.Text = "Día"
        End If
    End Sub

    Private Sub CargarDiasDelMes()
        cboDia.Items.Clear()
        Dim MesSeleccionado As Integer = cboMes.SelectedIndex + 1
        Dim AñoSeleccionado As Integer = Integer.Parse(cboAño.Text)
        Dim DiasEnElMes As Integer = DateTime.DaysInMonth(AñoSeleccionado, MesSeleccionado)

        For i As Integer = 1 To DiasEnElMes
            cboDia.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub btnCargarTodo_Click_1(sender As Object, e As EventArgs) Handles btnCargarTodo.Click
        LlenarGrilla()
        cboClientes.Text = "Cliente"
        cboAño.Text = "Año"
        cboMes.Text = "Mes"
        cboDia.Text = "Día"
        cboMes.Enabled = False
        cboDia.Enabled = False
    End Sub

    Private Sub cboDia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDia.SelectedIndexChanged
        FiltrarGrilla()
    End Sub

End Class