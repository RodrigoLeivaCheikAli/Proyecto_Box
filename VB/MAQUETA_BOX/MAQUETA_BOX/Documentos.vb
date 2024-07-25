Imports System.Data.SqlClient
Imports System.Configuration
Imports DocumentFormat.OpenXml.Spreadsheet
Imports ClosedXML.Excel

Public Class Documentos

    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Dim allow As Integer = -1

#Region "load"

    Private Sub Documentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PIN_GRUPO11DataSet.consultar_documentos_OrVentas' Puede moverla o quitarla según sea necesario.
        Me.Consultar_documentos_OrVentasTableAdapter.Fill(Me.PIN_GRUPO11DataSet.consultar_documentos_OrVentas)
        'TODO: esta línea de código carga datos en la tabla 'PIN_GRUPO11DataSet.consultar_documentos_OrCompras' Puede moverla o quitarla según sea necesario.
        Me.Consultar_documentos_OrComprasTableAdapter.Fill(Me.PIN_GRUPO11DataSet.consultar_documentos_OrCompras)

        cboDocumentos.SelectedIndex = -1

        cboProductos.Enabled = False
        cboClientes.Enabled = False
        cboProveedores.Enabled = False
    End Sub

#End Region

#Region "Llenar Grilla y CBOs "

    Private Sub LlenarGrillaVentas()
        conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "consultar_documentos_OrVentas"

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = oDs.Tables(0)
            DataGridView1.Refresh()
        Else
            DataGridView1.DataSource = Nothing
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Private Sub FiltrarGrillaVentas()
        Dim conexion As SqlConnection = Nothing
        Dim comando As SqlCommand = Nothing
        Dim adapter As SqlDataAdapter = Nothing
        Dim dataset As New DataSet()

        Try
            conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
            conexion.Open()

            comando = New SqlCommand()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Sortear_Cliente_Documentos"

            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@Nombre_Apellido", If(cboClientes.SelectedItem IsNot Nothing, cboClientes.SelectedItem.ToString(), DBNull.Value))
            comando.Parameters.AddWithValue("@Descripcion", If(cboProductos.SelectedItem IsNot Nothing, cboProductos.SelectedItem.ToString(), DBNull.Value))
            comando.Parameters.AddWithValue("@Fecha", DateTimePicker1.Value.Date)

            adapter = New SqlDataAdapter(comando)
            adapter.Fill(dataset)

            If dataset.Tables.Count > 0 AndAlso dataset.Tables(0).Rows.Count > 0 Then
                DataGridView1.DataSource = dataset.Tables(0)
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar documentos del cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Private Sub LlenarGrillaCompras()
        Try
            conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "consultar_documentos_OrCompras"

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                DataGridView1.AutoGenerateColumns = True
                DataGridView1.DataSource = oDs.Tables(0)
                DataGridView1.Refresh()
            Else
                DataGridView1.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar documentos de compras: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub FiltrarGrillaCompras()
        If cboProveedores.SelectedItem IsNot Nothing Then
            Dim conexion As SqlConnection = Nothing
            Dim comando As SqlCommand = Nothing
            Dim adapter As SqlDataAdapter = Nothing
            Dim dataset As New DataSet()

            Try
                conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
                conexion.Open()

                comando = New SqlCommand()
                comando.Connection = conexion
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandText = "Sortear_Proveedor_Documentos"

                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@Nombre", If(cboProveedores.SelectedItem IsNot Nothing, cboProveedores.SelectedItem.ToString(), DBNull.Value))
                comando.Parameters.AddWithValue("@Descripcion", If(cboProductos.SelectedItem IsNot Nothing, cboProductos.SelectedItem.ToString(), DBNull.Value))
                comando.Parameters.AddWithValue("@FechaParam", DateTimePicker1.Value.Date)

                adapter = New SqlDataAdapter(comando)
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


    Private Sub CargarCBOClientes()
        ' Configurar la conexión y el comando para el procedimiento almacenado
        conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "cargar_CBO_clientes"

        ' Ejecutar el comando y llenar el ComboBox
        Try
            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            While reader.Read()
                cboClientes.Items.Add(reader("Nombre_Apellido")) ' Asumiendo que "NombreCliente" es el nombre del campo que quieres mostrar
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub CargarCBOProveedores()
        ' Configurar la conexión y el comando para el procedimiento almacenado
        conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "Cargar_cbo_Proveedores"

        ' Ejecutar el comando y llenar el ComboBox
        Try
            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            While reader.Read()
                cboProveedores.Items.Add(reader("Nombre"))
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar proveedores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub CargarCBOProducto()
        ' Configurar la conexión y el comando para el procedimiento almacenado
        conexion = New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "Cargar_CBO_Productos"

        ' Ejecutar el comando y llenar el ComboBox
        Try
            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            While reader.Read()
                cboProductos.Items.Add(reader("Descripcion"))
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar proveedores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

#End Region

    Private Sub cboDocumentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentos.SelectedIndexChanged
        ' Cargar la grilla dependiendo de la selección
        If cboDocumentos.SelectedItem.ToString() = "Cliente" Then
            allow = 0

            LlenarGrillaVentas()

            cboProductos.Items.Clear()

            CargarCBOProducto()

            cboProveedores.Items.Clear()

            cboClientes.Items.Clear()

            CargarCBOClientes()
            cboProductos.Enabled = True
            cboProveedores.Enabled = False
            cboClientes.Enabled = True
        ElseIf cboDocumentos.SelectedItem.ToString() = "Proveedor" Then
            allow = 1

            LlenarGrillaCompras()

            cboProductos.Items.Clear()

            CargarCBOProducto()

            cboProveedores.Items.Clear()

            cboClientes.Items.Clear()

            CargarCBOProveedores()
            cboProductos.Enabled = True
            cboClientes.Enabled = False
            cboProveedores.Enabled = True
        End If

    End Sub

#Region "Exportar"

    Public Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        ' Verifica que el DataGridView tenga datos
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Crear un DataTable para almacenar los datos del DataGridView
        Dim dataTable As New DataTable()

        ' Crear las columnas en el DataTable
        For Each column As DataGridViewColumn In DataGridView1.Columns
            dataTable.Columns.Add(column.HeaderText, column.ValueType)
        Next

        ' Rellenar el DataTable con las filas del DataGridView
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
            ' Crear un nuevo libro de Excel
            Dim workbook As New XLWorkbook()
            ' Agregar una hoja al libro de Excel
            Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Datos")

            ' Cargar el DataTable en la hoja de Excel
            worksheet.Cell(1, 1).InsertTable(dataTable)

            ' Guardar el libro de Excel en el disco
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
        If cboClientes.Text <> "Cliente" Then
            FiltrarGrillaVentas()
        End If
    End Sub

    Private Sub cboProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedores.SelectedIndexChanged
        If cboProveedores.Text <> "Proveedor" Then
            FiltrarGrillaCompras()
        End If
    End Sub

    Private Sub cboProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProductos.SelectedIndexChanged
        If allow = 0 Then
            FiltrarGrillaVentas()
        ElseIf allow = 1 Then
            FiltrarGrillaCompras()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        Select Case cboDocumentos.Text
            Case "Proveedor"
                FiltrarGrillaCompras()
            Case "Cliente"
                FiltrarGrillaVentas()
        End Select

    End Sub
End Class