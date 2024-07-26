Imports System.Data.SqlClient

Public Class Clientes
#Region "Panel"
    Private _panel As Panel

    ' Constructor que acepta un Panel como parámetro
    Public Sub New(panel As Panel)
        ' Inicialización de la clase
        InitializeComponent() ' Llama al método para inicializar los componentes del formulario

        ' Asigna el panel recibido a una variable de la clase
        _panel = panel
    End Sub
#End Region
#Region "Redirección"
#Region " Recibir Panel"
    Private panelContenedor As Panel
    ' Constructor para recibir el panel contenedor
    Public Sub e(panel As Panel)
        InitializeComponent()
        Me.panelContenedor = panel
    End Sub
#End Region
#Region "Listado"
    ''Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
    ' Crear una instancia del formulario Productos_Listado
    ''Dim listadoForm As New Productos_Listado(panelContenedor)

    ' Configurar el formulario Productos_Listado para que no sea de nivel superior
    ''listadoForm.TopLevel = False

    ' Limpiar el panelContenedor antes de agregar el nuevo formulario
    ''panelContenedor.Controls.Clear()

    ' Agregar el formulario Productos_Listado al panelContenedor
    ''  panelContenedor.Controls.Add(listadoForm)

    ' Ajustar el tamaño del formulario al panel
    ''    listadoForm.Dock = DockStyle.Fill

    ' Mostrar el formulario dentro del panel
    ''  listadoForm.Show()
    ''End Sub
#End Region
#Region "Vendidos"
    '' Private Sub btnVendidos_Click(sender As Object, e As EventArgs) Handles btnVendidos.Click
    ' Crear una instancia del formulario Productos_Listado
    ''Dim vendidosForm As New Productos_Vendidos(panelContenedor)

    ' Configurar el formulario Productos_Listado para que no sea de nivel superior
    ''vendidosForm.TopLevel = False

    ' Limpiar el panelContenedor antes de agregar el nuevo formulario
    ' panelContenedor.Controls.Clear()

    ' Agregar el formulario Productos_Listado al panelContenedor
    'panelContenedor.Controls.Add(vendidosForm)

    ' Ajustar el tamaño del formulario al panel
    'vendidosForm.Dock = DockStyle.Fill

    ' Mostrar el formulario dentro del panel
    'vendidosForm.Show()
    'End Sub
#End Region
#Region "Menú"
    Private mainForm As Inicio

    ' Constructor para recibir la referencia del formulario principal
    Public Sub New(mainForm As Inicio)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub

    'Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
    ' Restaurar el estado inicial del panel
    'mainForm.RestaurarPanel()

    ' Cerrar el formulario actual
    'Me.Close()
    'End Sub
#End Region
#End Region
#Region "Cargar Grilla"
    Dim dt As DataTable

    Private Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Consultar_Clientes")

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
#Region "Limpiar"
    Private Sub Limpiar()
        txtNombre.Text = Nothing
        txtCodigo.Text = Nothing
        txtCUIL.Text = Nothing
        txtDireccion.Text = Nothing
        txtMail.Text = Nothing
        txtRazonSocial.Text = Nothing
        txtRubro.Text = Nothing
        txtTelefono.Text = Nothing
    End Sub
#End Region
#Region "Load"
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grilla()
    End Sub
#End Region
#Region "Cargar Clientes"
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If txtNombre.Text <> Nothing And txtTelefono.Text <> Nothing Then

            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Clientes")

            With comando.Parameters
                .AddWithValue("@nombre", txtNombre.Text)
                .AddWithValue("@cuil", txtCUIL.Text)
                .AddWithValue("@rubro", txtRubro.Text)
                .AddWithValue("@razonsocial", txtRazonSocial.Text)
                .AddWithValue("@telefono", txtTelefono.Text)
                .AddWithValue("@mail", txtMail.Text)
                .AddWithValue("@direccion", txtDireccion.Text)

            End With

            comando.ExecuteScalar()
            conexion.Close()
            MsgBox("Se ha cargado correctamente", vbInformation, Me.Text)
            Limpiar()
            Cargar_Grilla()
        Else
            MsgBox("Complete los datos", vbInformation, Me.Text)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtCodigo.Text <> Nothing And txtNombre.Text <> Nothing And txtTelefono.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Modificar_Clientes")

            With comando.Parameters
                .AddWithValue("@idcliente", txtCodigo.Text)
                .AddWithValue("@nombre", txtNombre.Text)
                .AddWithValue("@cuil", txtCUIL.Text)
                .AddWithValue("@rubro", txtRubro.Text)
                .AddWithValue("@razonsocial", txtRazonSocial.Text)
                .AddWithValue("@telefono", txtTelefono.Text)
                .AddWithValue("@mail", txtMail.Text)
                .AddWithValue("@direccion", txtDireccion.Text)
            End With

            comando.ExecuteNonQuery()
            MsgBox("Se ha modificado con exito", vbInformation, Me.Text)
            Limpiar()
            Cargar_Grilla()
            conexion.Close()
        Else
            MsgBox("Complete los datos para modificar", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub


#End Region
#Region "Eliminar Clientes"
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtCodigo.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Eliminar_Clientes")
            With comando.Parameters
                .AddWithValue("@idcliente", txtCodigo.Text)
            End With

            comando.ExecuteNonQuery()
            MsgBox("Se ha eliminado correctamente", vbInformation, Me.Text)
            Limpiar()
            Cargar_Grilla()
            conexion.Close()
        Else
            MsgBox("Complete datos para eliminar", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
#End Region
    Private Sub BunifuDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
            txtCodigo.Text = row.Cells("ID").Value.ToString()
            txtNombre.Text = row.Cells("Nombre").Value.ToString()
            txtCUIL.Text = row.Cells("CUIL").Value.ToString()
            txtRubro.Text = row.Cells("Rubro").Value.ToString()
            txtRazonSocial.Text = row.Cells("Razon Social").Value.ToString()
            txtTelefono.Text = row.Cells("Telefono").Value.ToString()
            txtMail.Text = row.Cells("Mail").Value.ToString()
            txtDireccion.Text = row.Cells("Direccion").Value.ToString()
        End If
    End Sub
End Class