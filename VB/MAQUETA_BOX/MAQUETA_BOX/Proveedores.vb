Imports System.Data.SqlClient
Imports System.Configuration
Public Class Proveedores
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Private Sub Proveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub

#Region "Llenar textboxes al tocar grilla"
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaProv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = grillaProv.Rows(e.RowIndex)
            txtId.Text = row.Cells("ID").Value.ToString()
            txtNombre.Text = row.Cells("Nombre").Value.ToString()
            txtRubro.Text = row.Cells("Rubro").Value.ToString()
            txtCuit.Text = row.Cells("CUIT").Value.ToString()
            txtDireccion.Text = row.Cells("Direccion").Value.ToString()
            txtLocalidad.Text = row.Cells("Localidad").Value.ToString()
            txtTelefono.Text = row.Cells("Telefono").Value.ToString()
            txtMail.Text = row.Cells("Mail").Value.ToString()
            txtNotas.Text = row.Cells("Notas").Value.ToString()
        End If
    End Sub
#End Region

#Region "Cargar Grilla"
    Private Sub CargarGrilla()
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

#End Region

#Region "Limpiar"
    Public Sub Limpiar()

        txtId.Text = Nothing
        txtNombre.Text = Nothing
        txtRubro.Text = Nothing
        txtCuit.Text = Nothing
        txtDireccion.Text = Nothing
        txtLocalidad.Text = Nothing
        txtTelefono.Text = Nothing
        txtMail.Text = Nothing
        txtNotas.Text = Nothing
        txtBuscar.Text = Nothing

    End Sub

#End Region

#Region "Cargar"
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If txtNombre.Text <> Nothing Then

            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Proveedores")

            With comando.Parameters
                .AddWithValue("@nombre", txtNombre.Text)
                .AddWithValue("@rubro", txtRubro.Text)
                .AddWithValue("@cuit", txtCuit.Text)
                .AddWithValue("@direccion", txtDireccion.Text)
                .AddWithValue("@localidad", txtLocalidad.Text)
                .AddWithValue("@telefono", txtTelefono.Text)
                .AddWithValue("@mail", txtMail.Text)
                .AddWithValue("@notas", txtNotas.Text)

            End With

            comando.ExecuteScalar()
            conexion.Close()
            MsgBox("Se ha cargado correctamente", vbInformation, Me.Text)
            Limpiar()
            CargarGrilla()
        Else
            MsgBox("Debe ingresar un nombre para cargar un proveedor", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtId.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Modificar_Proveedores")

            With comando.Parameters
                .AddWithValue("@id", txtId.Text)
                .AddWithValue("@nombre", txtNombre.Text)
                .AddWithValue("@rubro", txtRubro.Text)
                .AddWithValue("@cuit", txtCuit.Text)
                .AddWithValue("@direccion", txtDireccion.Text)
                .AddWithValue("@localidad", txtLocalidad.Text)
                .AddWithValue("@telefono", txtTelefono.Text)
                .AddWithValue("@mail", txtMail.Text)
                .AddWithValue("@notas", txtNotas.Text)

            End With

            comando.ExecuteNonQuery()
            MsgBox("Se ha modificado con exito", vbInformation, Me.Text)
            Limpiar()
            CargarGrilla()
            conexion.Close()
        Else
            MsgBox("Coloque el código del proveedor que desea modificar", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

#End Region

#Region "Eliminar"
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtId.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Eliminar_Proveedores")
            With comando.Parameters
                .AddWithValue("@id", txtId.Text)
            End With

            comando.ExecuteNonQuery()
            MsgBox("Se ha eliminado correctamente", vbInformation, Me.Text)
            Limpiar()
            CargarGrilla()
            conexion.Close()
        Else
            MsgBox("Coloque el código del proveedor que desea eliminar", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
#End Region

#Region "Buscar"
    Private connectionString As String = "data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123"

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Llama a la función para buscar proveedores
        BuscarProveedores(txtBuscar.Text)
    End Sub

    Private Sub BuscarProveedores(busqueda As String)
        Dim query As String
        Dim isNumericSearch As Boolean = IsNumeric(busqueda)

        If isNumericSearch Then
            query = "SELECT Id_Proveedor, Nombre, Direccion, Telefono, Localidad, Mail, Rubro, CUIT, Notas FROM Proveedores WHERE Id_Proveedor = @Busqueda"
        Else
            query = "SELECT Id_Proveedor, Nombre, Direccion, Telefono, Localidad, Mail, Rubro, CUIT, Notas FROM Proveedores WHERE Nombre LIKE @Busqueda"
        End If

        ' Usa Using para asegurar que los recursos se liberan correctamente
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                If isNumericSearch Then
                    command.Parameters.AddWithValue("@Busqueda", Convert.ToInt32(busqueda))
                Else
                    command.Parameters.AddWithValue("@Busqueda", "%" & busqueda & "%")
                End If

                ' Crea un adaptador de datos y un DataTable
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()

                Try
                    ' Abre la conexión a la base de datos
                    connection.Open()

                    ' Llena el DataTable con los resultados de la consulta
                    adapter.Fill(dataTable)

                    ' Asigna el DataTable como origen de datos del DataGridView
                    grillaProv.DataSource = dataTable
                Catch ex As Exception
                    ' Muestra un mensaje de error si ocurre algún problema
                    MessageBox.Show("Error al buscar los proveedores: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CargarGrilla()
        Limpiar()
    End Sub



#End Region
End Class