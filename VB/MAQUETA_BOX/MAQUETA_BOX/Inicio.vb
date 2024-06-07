Public Class Inicio
    ' Variables para manejar las dimensiones y el radio de las esquinas redondeadas
    Private Const CS_DROPSHADOW As Integer = &H20000
    Private Const borderRadius As Integer = 30


    Public Sub New()
        ' Esta llamada es requerida por el diseñador.
        InitializeComponent()

        ' Agrega cualquier inicialización después de la llamada a InitializeComponent().
        Me.FormBorderStyle = FormBorderStyle.None ' Elimina los bordes estándar del formulario
        Me.SetStyle(ControlStyles.ResizeRedraw, True) ' Permite redibujar el formulario al cambiar tamaño
    End Sub

    ' Maneja el evento Paint para dibujar el borde redondeado
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Llama al método OnPaint del formulario base
        MyBase.OnPaint(e)

        ' Crea un nuevo objeto GraphicsPath para el borde redondeado
        Dim graphicsPath As New Drawing2D.GraphicsPath()

        ' Define los puntos para las esquinas redondeadas
        graphicsPath.StartFigure()
        graphicsPath.AddArc(New Rectangle(0, 0, borderRadius, borderRadius), 180, 90)
        graphicsPath.AddLine(borderRadius, 0, Me.Width - borderRadius, 0)
        graphicsPath.AddArc(New Rectangle(Me.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90)
        graphicsPath.AddLine(Me.Width, borderRadius, Me.Width, Me.Height - borderRadius)
        graphicsPath.AddArc(New Rectangle(Me.Width - borderRadius, Me.Height - borderRadius, borderRadius, borderRadius), 0, 90)
        graphicsPath.AddLine(Me.Width - borderRadius, Me.Height, borderRadius, Me.Height)
        graphicsPath.AddArc(New Rectangle(0, Me.Height - borderRadius, borderRadius, borderRadius), 90, 90)
        graphicsPath.CloseFigure()

        ' Establece la región del formulario con el borde redondeado
        Me.Region = New Region(graphicsPath)

        ' Libera los recursos del objeto GraphicsPath
        graphicsPath.Dispose()
    End Sub

#Region " Permite mover el formulario sin borde"

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Constante para el mensaje WM_NCLBUTTONDBLCLK
        Const WM_NCLBUTTONDBLCLK As Integer = &HA3
        ' Constante para el mensaje WM_NCHITTEST
        Const WM_NCHITTEST As Integer = &H84

        ' Interceptar el mensaje de doble clic en la barra de título
        If m.Msg = WM_NCLBUTTONDBLCLK Then
            ' No hacer nada para evitar que el formulario se maximice
            Return
        End If

        ' Llamar al método WndProc base para manejar otros mensajes
        MyBase.WndProc(m)

        ' Manejar el mensaje WM_NCHITTEST para permitir mover el formulario sin borde
        If m.Msg = WM_NCHITTEST Then
            Dim pos As Point = Me.PointToClient(New Point(m.LParam.ToInt32()))
            If pos.Y < borderRadius Then
                m.Result = New IntPtr(2) ' HTCAPTION
            End If
        End If
    End Sub

#End Region




#Region "LOAD"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

#End Region






#Region "Botones e Imagenes redirección"

    Private Sub lbl_Ventas_Click(sender As System.Object, e As System.EventArgs) Handles lbl_Ventas.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Ventas() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.Show() ' Muestra el formulario
    End Sub

    Private Sub lbl_Compras_Click(sender As System.Object, e As System.EventArgs) Handles lbl_Compras.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Compras() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.Show() ' Muestra el formulario
    End Sub
#Region "Productos"
    Private Sub lbl_Productos_Click(sender As System.Object, e As System.EventArgs) Handles lbl_Productos.Click
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
    Private Sub lbl_Documentos_Click(sender As System.Object, e As System.EventArgs) Handles lbl_Documentos.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Documentos() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.Show() ' Muestra el formulario
    End Sub
    Private Sub lbl_Proveedores_Click(sender As System.Object, e As System.EventArgs) Handles lbl_Proveedores.Click
        PictureBox1.Visible = False
        Panel1.Controls.Clear()
        Dim newForm As New Proveedores() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.Show() ' Muestra el formulario
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
