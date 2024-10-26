Imports System.Data.SqlClient
Imports System.Configuration
Public Class Presupuesto_Ventas
    Private detallesPresupuesto As DataTable
    Private frmVentas As Presupuesto

    Public Sub New(PresupuestoForm As Presupuesto)
        InitializeComponent()
        frmVentas = PresupuestoForm
    End Sub

    Private Sub Presupuestos_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Modulo.IdPres = 0
    End Sub

#Region "Pasar Variable"
    Private Sub PasarIdPresupuestoAlFormularioPrincipal()
        If BunifuDataGridView1.SelectedRows.Count > 0 Then
            Dim idPresupuesto As Integer = Convert.ToInt32(BunifuDataGridView1.SelectedRows(0).Cells(0).Value)



            Modulo.IdPres = idPresupuesto
                frmVentas.IDPresu = idPresupuesto
                frmVentas.CargarDetalles()

        Else
            MessageBox.Show("Por favor seleccione un presupuesto.")
        End If
    End Sub
#End Region

    Private Sub Presupuesto_Ventas_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Llenar_Grilla() ' Recargar la grilla cada vez que el formulario se active
    End Sub


#Region "Cargar Grilla"



    Dim dt As DataTable

        Private Sub Llenar_Grilla()
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "Consultar_Presupuestos_Ventas"

        Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet

            datadapter.Fill(oDs)
            If oDs.Tables(0).Rows.Count > 0 Then
                dt = oDs.Tables(0)
                BunifuDataGridView1.AutoGenerateColumns = True
                BunifuDataGridView1.DataSource = Nothing  ' Limpiar fuente de datos antes de asignar nueva
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
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "Consultar_Presupuestos_Ventas2"
        comando.Parameters.AddWithValue("@Id_Presupuesto", idPresupuesto)

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet

            Try
                conexion.Open()
                datadapter.Fill(oDs)
                If oDs.Tables(0).Rows.Count > 0 Then
                    Dim dtDetalles As DataTable = oDs.Tables(0)
                    BunifuDataGridView2.AutoGenerateColumns = True
                    BunifuDataGridView2.DataSource = dtDetalles
                    BunifuDataGridView2.Refresh()
                Else
                    BunifuDataGridView2.DataSource = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar los detalles: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            PasarIdPresupuestoAlFormularioPrincipal()
            ' Solo cerrar si el proceso anterior fue exitoso
            If Modulo.IdPres <> 0 Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al procesar el clic: " & ex.Message)
        End Try
    End Sub

#End Region
End Class