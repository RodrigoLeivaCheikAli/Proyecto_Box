Imports System.Data.SqlClient
Imports System.Configuration
Imports DocumentFormat.OpenXml.Spreadsheet
Imports ClosedXML.Excel
Public Class Documentos

    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

#Region "load"

    Private Sub Documentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PIN_GRUPO11DataSet.consultar_documentos_OrVentas' Puede moverla o quitarla según sea necesario.
        Me.Consultar_documentos_OrVentasTableAdapter.Fill(Me.PIN_GRUPO11DataSet.consultar_documentos_OrVentas)
        'TODO: esta línea de código carga datos en la tabla 'PIN_GRUPO11DataSet.consultar_documentos_OrCompras' Puede moverla o quitarla según sea necesario.
        Me.Consultar_documentos_OrComprasTableAdapter.Fill(Me.PIN_GRUPO11DataSet.consultar_documentos_OrCompras)
        cboDocumentos.SelectedIndex = -1
        DataGridView1.DataSource = Nothing
    End Sub

#End Region

#Region "Llenar Grilla"

    Private Sub LlenarGrillaVentas()
        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("consultar_documentos_OrVentas")

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

    Private Sub LlenarGrillaCompras()
        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("consultar_documentos_OrCompras")

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

#End Region

#Region "Exportar"

#End Region

    Private Sub cboDocumentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentos.SelectedIndexChanged
        DataGridView1.DataSource = Nothing  ' Limpiar el DataGridView

        If cboDocumentos.SelectedIndex = -1 Then
            ' No hacer nada si no hay una selección válida
            Return
        End If

        ' Cargar la grilla dependiendo de la selección
        If cboDocumentos.SelectedItem.ToString() = "Clientes" Then
            LlenarGrillaCompras()
        ElseIf cboDocumentos.SelectedItem.ToString() = "Proveedores" Then
            LlenarGrillaVentas()
        End If
    End Sub

    Public Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        ' Define la cadena de conexión a tu base de datos con autenticación SQL
        Dim connectionString As String = "data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123"

        ' Definir la consulta SQL basada en la selección del ComboBox
        Dim query As String = ""
        If cboDocumentos.SelectedItem IsNot Nothing Then
            If cboDocumentos.SelectedItem.ToString() = "Clientes" Then
                query = "EXEC consultar_documentos_OrVentas"
            ElseIf cboDocumentos.SelectedItem.ToString() = "Proveedores" Then
                query = "EXEC consultar_documentos_OrCompras"
            Else
                MessageBox.Show("Por favor, selecciona una opción válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            MessageBox.Show("Por favor, selecciona una opción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Crear un DataTable para almacenar los datos
        Dim dataTable As New DataTable()

        Try
            ' Usar SqlConnection y SqlCommand para ejecutar la consulta y llenar el DataTable
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        dataTable.Load(reader)
                    End Using
                End Using
            End Using

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








End Class