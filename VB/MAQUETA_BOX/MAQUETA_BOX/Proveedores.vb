Imports System.Data.SqlClient
Imports System.Configuration
Public Class form1
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

#Region "Load"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEstados()
        CargarGrilla()
    End Sub

#End Region

#Region "Llenar textboxes al tocar grilla"
    Private Sub grillaProv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaProv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = grillaProv.Rows(e.RowIndex)
            txtId.Text = row.Cells("ID").Value.ToString()
            txtNombre.Text = row.Cells("Nombre").Value.ToString()
            txtRubro.Text = row.Cells("Rubro").Value.ToString()
            txtCUIT.Text = row.Cells("CUIT").Value.ToString()
            txtDireccion.Text = row.Cells("Direccion").Value.ToString()
            txtLocalidad.Text = row.Cells("Localidad").Value.ToString()
            cboEstado.Text = row.Cells("Estado").Value.ToString()
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
        cboEstado.SelectedItem = "Activo"

    End Sub

#End Region

#Region "Cargar"
    Private Sub brnGuardar_Click(sender As Object, e As EventArgs) Handles brnGuardar.Click
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
                .AddWithValue("@cuit", txtCUIT.Text)
                .AddWithValue("@direccion", txtDireccion.Text)
                .AddWithValue("@localidad", txtLocalidad.Text)
                .AddWithValue("@telefono", txtTelefono.Text)
                .AddWithValue("@mail", txtMail.Text)
                .AddWithValue("@notas", txtNotas.Text)
                .AddWithValue("id_estado", cboEstado.SelectedValue)

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
    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
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
                .AddWithValue("@cuit", txtCUIT.Text)
                .AddWithValue("@direccion", txtDireccion.Text)
                .AddWithValue("@localidad", txtLocalidad.Text)
                .AddWithValue("@telefono", txtTelefono.Text)
                .AddWithValue("@mail", txtMail.Text)
                .AddWithValue("@notas", txtNotas.Text)
                .AddWithValue("id_estado", cboEstado.SelectedValue)

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
    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
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

    ' Maneja el evento TextChanged del TextBox para actualizar la grilla en tiempo real
    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarProveedores(txtBuscar.Text)
    End Sub

    Private Sub BuscarProveedores(busqueda As String)
        Dim query As String
        Dim isNumericSearch As Boolean = IsNumeric(busqueda)

        If isNumericSearch Then
            query = "SELECT p.Id_Proveedor AS Id, p.Nombre, p.Direccion, p.Telefono, p.Localidad, p.Mail, p.Rubro, p.CUIT, p.Notas, e.Nombre AS Estado " &
                    "FROM Proveedores p " &
                    "INNER JOIN Estados e ON p.Id_Estado = e.Id_Estado " &
                    "WHERE p.Id_Proveedor = @Busqueda OR p.Telefono = @Busqueda"
        Else
            query = "SELECT p.Id_Proveedor AS Id, p.Nombre, p.Direccion, p.Telefono, p.Localidad, p.Mail, p.Rubro, p.CUIT, p.Notas, e.Nombre AS Estado " &
                    "FROM Proveedores p " &
                    "INNER JOIN Estados e ON p.Id_Estado = e.Id_Estado " &
                    "WHERE p.Nombre LIKE @Busqueda OR p.Direccion LIKE @Busqueda OR p.Localidad LIKE @Busqueda OR p.Mail LIKE @Busqueda OR p.Rubro LIKE @Busqueda OR p.Notas LIKE @Busqueda"
        End If

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                If isNumericSearch Then
                    command.Parameters.AddWithValue("@Busqueda", Convert.ToInt32(busqueda))
                Else
                    command.Parameters.AddWithValue("@Busqueda", "%" & busqueda & "%")
                End If

                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    grillaProv.DataSource = dataTable

                    If grillaProv.Columns.Contains("Id") Then
                        grillaProv.Columns("Id").HeaderText = "Id"
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error al buscar los proveedores: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

#End Region

#Region "Estado"
    Private Sub CargarEstados()
        Dim connectionString As String = "data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123"
        Try
            Using conexion As New SqlConnection(connectionString)
                conexion.Open()

                Using comando As New SqlCommand("Cargar_cbo_EstadosProv", conexion)
                    comando.CommandType = CommandType.StoredProcedure

                    Dim dt As New DataTable()
                    Dim adapter As New SqlDataAdapter(comando)
                    adapter.Fill(dt)

                    cboEstado.DataSource = dt
                    cboEstado.DisplayMember = "Nombre"  ' Lo que se muestra
                    cboEstado.ValueMember = "Id_Estado" ' El valor asociado
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "Otros"

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Limpiar()
        CargarGrilla()
    End Sub


    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCUIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCUIT.KeyPress
        Dim allowedChars As String = "0123456789-"
        If Not (Char.IsDigit(e.KeyChar) OrElse allowedChars.Contains(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub


#End Region

#Region "Comparacion"

    Private Sub btnComparacion_Click(sender As Object, e As EventArgs) Handles btnComparacion.Click

    End Sub


#End Region


End Class