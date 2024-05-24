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






    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Clientes.Show()
        Me.Hide()
    End Sub
End Class
