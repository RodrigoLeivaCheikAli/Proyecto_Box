Imports MAQUETA_BOX.PIN_GRUPO11DataSetTableAdapters

Public Class Inicio




#Region "LOAD"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized

    End Sub

#End Region






#Region "Botones e Imagenes redirección"
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Ventas() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel

        'newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Dock = DockStyle.Fill
        newForm.Show()
    End Sub
    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Compras() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        'newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Dock = DockStyle.Fill
        newForm.Show() ' Muestra el formulario
    End Sub
    Private Sub btnDocumentos_Click(sender As Object, e As EventArgs) Handles btnDocumentos.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Documentos() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        'newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Dock = DockStyle.Fill
        newForm.Show() ' Muestra el formulario
    End Sub

    Private Sub btnEstadisticas_Click(sender As Object, e As EventArgs) Handles btnEstadisticas.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Estadisticas() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel

        'newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Dock = DockStyle.Fill
        newForm.Show()
    End Sub

#Region "Productos"
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        ' Crear una instancia del formulario Productos
        Dim productosForm As New Productos(Me.Panel1)

        ' Configurar el formulario Productos para que no sea de nivel superior
        productosForm.TopLevel = False

        ' Limpiar el panelContenedor antes de agregar el nuevo formulario
        Panel1.Controls.Clear()

        ' Agregar el formulario Productos al panelContenedor
        Panel1.Controls.Add(productosForm)

        ' Ajustar el tamaño del formulario al panel
        productosForm.Dock = DockStyle.Fill

        ' Mostrar el formulario dentro del panel
        productosForm.Show()
    End Sub

#End Region

#Region "Proveedores"
    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        ' Crear una instancia del formulario Productos
        Dim proveedoresForm As New Proveedores(Me.Panel1)

        ' Configurar el formulario Productos para que no sea de nivel superior
        proveedoresForm.TopLevel = False

        ' Limpiar el panelContenedor antes de agregar el nuevo formulario
        Panel1.Controls.Clear()

        ' Agregar el formulario Productos al panelContenedor
        Panel1.Controls.Add(proveedoresForm)

        ' Ajustar el tamaño del formulario al panel
        proveedoresForm.Dock = DockStyle.Fill

        ' Mostrar el formulario dentro del panel
        proveedoresForm.Show()
    End Sub
#End Region
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        ' Instancia de la clase Clientes pasando el Panel1 como parámetro
        Dim ClientesForm As New Clientes(Me.Panel1)

        ClientesForm.TopLevel = False

        Panel1.Controls.Clear()
        Panel1.Controls.Add(ClientesForm)
        ' Ajustar el tamaño del formulario al panel
        ClientesForm.Dock = DockStyle.Fill

        ' Mostrar el formulario dentro del panel
        ClientesForm.Show()
    End Sub

#End Region
#Region "Estados del Formulario"
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btnRestaurar.Visible = True
        btnMaximizar.Visible = False
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub














#End Region

#Region "Codigo para restaurar el panel (Comentado por error en otra linea)"
    'Private pictureBox As PictureBox
    'Private button As Button

    'Public Sub New()
    'InitializeComponent()

    ' Inicializa los controles (esto puede variar según tu implementación)
    'pictureBox = New PictureBox()
    'button = New Button()

    ' Agrega los controles al panel (esto es solo un ejemplo)
    'Panel1.Controls.Add(PictureBox)
    'Panel1.Controls.Add(Button)
    'End Sub

    ' Método para restaurar el estado inicial del panel
    'Public Sub RestaurarPanel()
    'Panel1.Controls.Clear()
    'Panel1.Controls.Add(PictureBox)
    'Panel1.Controls.Add(Button)
    'End Sub
#End Region

End Class
