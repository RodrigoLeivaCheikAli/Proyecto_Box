Imports System.Data.SqlClient
Imports System.Configuration
Public Class Proveedores
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Private Sub Proveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenarGrilla()
    End Sub

    Private Sub LlenarGrilla()
        Dim connectionString As String = "data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123"

        Try
            Using conexion As New SqlConnection(connectionString)
                conexion.Open()

                Using comando As New SqlCommand("Consultar_Proveedores", conexion)
                    comando.CommandType = CommandType.StoredProcedure

                    Dim datadapter As New SqlDataAdapter(comando)
                    Dim oDs As New DataSet

                    datadapter.Fill(oDs)

                    If oDs.Tables(0).Rows.Count > 0 Then
                        grillaProv.AutoGenerateColumns = True
                        grillaProv.DataSource = oDs.Tables(0)
                        grillaProv.Refresh()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class