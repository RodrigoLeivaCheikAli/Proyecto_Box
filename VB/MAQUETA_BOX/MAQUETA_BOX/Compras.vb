Imports System.Data.SqlClient
Imports System.Configuration

Public Class Compras

#Region "Llenar Grilla"

    Dim dt As DataTable

    Private Sub Llenar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Consultar_Productos_Compras")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet

        datadapter.Fill(oDs)
        If oDs.Tables(0).Rows.Count > 0 Then
            dt = oDs.Tables(0)
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

#End Region

#Region "Load Formulario"

    Private Sub Compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Llenar_Grilla()
    End Sub

#End Region

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

#Region "Barra Busqueda"

    Private Sub txtBusqueda_Compras_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusqueda_Compras.TextChanged



    End Sub

#End Region

    Private Sub boton_Busqueda_Click(sender As System.Object, e As System.EventArgs) Handles boton_Busqueda.Click
        If dt IsNot Nothing Then
            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = String.Format("NOMBRE LIKE '%{0}%'", txtBusqueda_Compras.Text)
            DataGridView1.DataSource = dv
        End If
    End Sub
End Class