Imports System.Data.SqlClient
Imports System.Configuration

Public Class Proveedores
    Private ReadOnly connectionString As String = "data source = 168.197.51.109; initial catalog = PIN_GRUPO11; user id = PIN_GRUPO11; password = PIN_GRUPO11123"

#Region "Direcciones"

    Private panelContenedor As Panel
    ' Constructor para recibir el panel contenedor
    Public Sub New(panel As Panel)
        InitializeComponent()
        Me.panelContenedor = panel
    End Sub

    Private Sub btnComparacion_Click(sender As Object, e As EventArgs) Handles btnComparacion.Click
        ' Crear una instancia del formulario Productos_Listado
        Dim compaForm As New ProvComparaciones(panelContenedor)

        ' Configurar el formulario Productos_Listado para que no sea de nivel superior
        compaForm.TopLevel = False

        ' Limpiar el panelContenedor antes de agregar el nuevo formulario
        panelContenedor.Controls.Clear()

        ' Agregar el formulario Productos_Listado al panelContenedor
        panelContenedor.Controls.Add(compaForm)

        ' Ajustar el tamaño del formulario al panel
        compaForm.Dock = DockStyle.Fill

        ' Mostrar el formulario dentro del panel
        compaForm.Show()
    End Sub


#End Region

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
            txtId.Text = row.Cells("Id").Value.ToString()
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
            MessageBox.Show("Error al cargar la grilla: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Limpiar"
    Public Sub Limpiar()
        txtId.Clear()
        txtNombre.Clear()
        txtRubro.Clear()
        txtCUIT.Clear()
        txtDireccion.Clear()
        txtLocalidad.Clear()
        txtTelefono.Clear()
        txtMail.Clear()
        txtNotas.Clear()
        txtBuscar.Clear()
        cboEstado.SelectedIndex = -1 ' Restablece el ComboBox
    End Sub
#End Region

#Region "Operaciones de CRUD"
    Private Sub brnGuardar_Click(sender As Object, e As EventArgs) Handles brnGuardar.Click
        If Not String.IsNullOrWhiteSpace(txtNombre.Text) Then
            Try
                Using conexion As New SqlConnection(connectionString)
                    conexion.Open()
                    Using comando As New SqlCommand("Cargar_Proveedores", conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        AsignarParametros(comando)
                        comando.ExecuteScalar()
                    End Using
                End Using
                MessageBox.Show("Se ha cargado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                CargarGrilla()
            Catch ex As Exception
                MessageBox.Show("Error al guardar el proveedor: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Debe ingresar un nombre para cargar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Not String.IsNullOrWhiteSpace(txtId.Text) Then
            Try
                Using conexion As New SqlConnection(connectionString)
                    conexion.Open()
                    Using comando As New SqlCommand("Modificar_Proveedores", conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.AddWithValue("@id", txtId.Text)
                        AsignarParametros(comando)
                        comando.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Se ha modificado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                CargarGrilla()
            Catch ex As Exception
                MessageBox.Show("Error al modificar el proveedor: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Coloque el código del proveedor que desea modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not String.IsNullOrWhiteSpace(txtId.Text) Then
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Try
                    Using conexion As New SqlConnection(connectionString)
                        conexion.Open()
                        Using comando As New SqlCommand("Eliminar_Proveedores", conexion)
                            comando.CommandType = CommandType.StoredProcedure
                            comando.Parameters.AddWithValue("@id", txtId.Text)
                            comando.ExecuteNonQuery()
                        End Using
                    End Using
                    MessageBox.Show("Se ha eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    CargarGrilla()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el proveedor: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Coloque el código del proveedor que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub AsignarParametros(comando As SqlCommand)
        With comando.Parameters
            .AddWithValue("@nombre", txtNombre.Text)
            .AddWithValue("@rubro", txtRubro.Text)
            .AddWithValue("@cuit", txtCUIT.Text)
            .AddWithValue("@direccion", txtDireccion.Text)
            .AddWithValue("@localidad", txtLocalidad.Text)
            .AddWithValue("@telefono", txtTelefono.Text)
            .AddWithValue("@mail", txtMail.Text)
            .AddWithValue("@notas", txtNotas.Text)
            .AddWithValue("@id_estado", If(cboEstado.SelectedValue Is Nothing, DBNull.Value, cboEstado.SelectedValue))
        End With
    End Sub
#End Region

#Region "Buscar"
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

        Try
            Using conexion As New SqlConnection(connectionString)
                Using comando As New SqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@Busqueda", If(isNumericSearch, Convert.ToInt32(busqueda), "%" & busqueda & "%"))

                    Dim datadapter As New SqlDataAdapter(comando)
                    Dim dataTable As New DataTable()
                    datadapter.Fill(dataTable)
                    grillaProv.DataSource = dataTable

                    If grillaProv.Columns.Contains("Id") Then
                        grillaProv.Columns("Id").HeaderText = "Id"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar los proveedores: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Cargar ComboBox"
    Private Sub CargarEstados()
        Try
            Using conexion As New SqlConnection(connectionString)
                conexion.Open()
                Using comando As New SqlCommand("Cargar_cbo_EstadosProv", conexion)
                    comando.CommandType = CommandType.StoredProcedure

                    Dim da As New SqlDataAdapter(comando)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    cboEstado.DataSource = dt
                    cboEstado.DisplayMember = "Nombre"
                    cboEstado.ValueMember = "Id_Estado"
                    cboEstado.SelectedIndex = -1 ' Para no seleccionar ningún estado por defecto
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los estados: " & ex.Message)
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

End Class



