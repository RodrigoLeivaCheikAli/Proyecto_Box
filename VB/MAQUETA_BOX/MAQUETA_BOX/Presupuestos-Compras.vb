Imports System.Data.SqlClient
Imports System.Configuration

Public Class Presupuestos_Compras

#Region "Load Formulario"
    Private Sub Presupuestos_Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar_Grilla()
    End Sub
#End Region

#Region "Cargar Grilla"

    Dim dt As DataTable

    Private Sub Llenar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "Consultar_Presupuestos_Compras"

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet

        datadapter.Fill(oDs)
        If oDs.Tables(0).Rows.Count > 0 Then
            dt = oDs.Tables(0)
            BunifuDataGridView1.AutoGenerateColumns = True
            BunifuDataGridView1.DataSource = dt
            BunifuDataGridView1.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

#End Region

#Region "Eventos de DataGridView"

    Private Sub BunifuDataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles BunifuDataGridView1.SelectionChanged
        If BunifuDataGridView1.SelectedRows.Count > 0 Then
            Dim idPresupuesto As Integer = Convert.ToInt32(BunifuDataGridView1.SelectedRows(0).Cells(0).Value)
            Cargar_Detalles(idPresupuesto)
        End If
    End Sub

    Private Sub Cargar_Detalles(idPresupuesto As Integer)
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "Consultar_Detalle_Presupuestos_Compras"
        comando.Parameters.AddWithValue("@Id_Presupuesto", idPresupuesto)

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet

        datadapter.Fill(oDs)
        If oDs.Tables(0).Rows.Count > 0 Then
            Dim dtDetalles As DataTable = oDs.Tables(0)
            BunifuDataGridView2.AutoGenerateColumns = True
            BunifuDataGridView2.DataSource = dtDetalles
            BunifuDataGridView2.Refresh()
        Else
            BunifuDataGridView2.DataSource = Nothing
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

#End Region

End Class