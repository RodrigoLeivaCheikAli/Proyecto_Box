Imports System.Data.SqlClient
Imports System.Configuration
Public Class Documentos

    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

#Region "load"

    Private Sub Documentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarGrillaVentas()
        LlenarGrillaCompras()
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
        End If
        oDs = Nothing
        conexion.Close()

    End Sub

#End Region

End Class