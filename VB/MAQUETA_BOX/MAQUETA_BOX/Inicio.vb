Imports MAQUETA_BOX.PIN_GRUPO11DataSetTableAdapters

Public Class Inicio




#Region "LOAD"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized

    End Sub

#End Region






#Region "Botones e Imagenes redirección"

    Private Sub lbl_Ventas_Click_1(sender As Object, e As EventArgs) Handles lbl_Ventas.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Ventas() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel

        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show()
    End Sub

    Private Sub lbl_Compras_Click(sender As Object, e As EventArgs) Handles lbl_Compras.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Compras() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show() ' Muestra el formulario
    End Sub
    Private Sub lbl_Documentos_Click(sender As Object, e As EventArgs) Handles lbl_Documentos.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Documentos() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show() ' Muestra el formulario
    End Sub
    Private Sub lbl_Proveedores_Click(sender As Object, e As EventArgs) Handles lbl_Proveedores.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Proveedores() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel

        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show()
    End Sub
    Private Sub lbl_Estadisticas_Click(sender As Object, e As EventArgs) Handles lbl_Estadisticas.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Estadisticas() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel

        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show()
    End Sub

#Region "Productos"
    Private Sub lbl_Productos_Click(sender As Object, e As EventArgs) Handles lbl_Productos.Click

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



    Private Sub lbl_Clientes_Click(sender As Object, e As EventArgs) Handles lbl_Clientes.Click
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



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
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
