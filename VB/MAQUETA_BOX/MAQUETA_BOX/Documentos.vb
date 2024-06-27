Imports System.Data.SqlClient
Imports System.Configuration
Public Class Documentos

    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

#Region "load"

    Private Sub Documentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Inicializar el combo box y el DataGridView vacío
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

End Class
