Public Class Productos_Listado
#Region "Load"
    Private Sub Productos_Listado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
#End Region
#Region "Redirección"
#Region "Recibir Panel"
    Private panelContenedor As Panel

    ' Constructor para recibir el panel contenedor
    Public Sub New(panel As Panel)
        InitializeComponent()
        Me.panelContenedor = panel
    End Sub
#End Region
#Region "Gestion"
    Private Sub btnGestion_Click(sender As Object, e As EventArgs) Handles btnGestion.Click
        ' Crear una instancia del formulario Productos_Listado
        Dim gestionForm As New Productos(panelContenedor)

        ' Configurar el formulario Productos_Listado para que no sea de nivel superior
        gestionForm.TopLevel = False

        ' Limpiar el panelContenedor antes de agregar el nuevo formulario
        panelContenedor.Controls.Clear()

        ' Agregar el formulario Productos_Listado al panelContenedor
        panelContenedor.Controls.Add(gestionForm)

        ' Ajustar el tamaño del formulario al panel
        gestionForm.Dock = DockStyle.Fill

        ' Mostrar el formulario dentro del panel
        gestionForm.Show()
    End Sub
#End Region
#Region "Vendidos"
    Private Sub btnVendidos_Click(sender As Object, e As EventArgs) Handles btnVendidos.Click
        ' Crear una instancia del formulario Productos_Listado
        Dim vendidosForm As New Productos_Vendidos(panelContenedor)

        ' Configurar el formulario Productos_Listado para que no sea de nivel superior
        vendidosForm.TopLevel = False

        ' Limpiar el panelContenedor antes de agregar el nuevo formulario
        panelContenedor.Controls.Clear()

        ' Agregar el formulario Productos_Listado al panelContenedor
        panelContenedor.Controls.Add(vendidosForm)

        ' Ajustar el tamaño del formulario al panel
        vendidosForm.Dock = DockStyle.Fill

        ' Mostrar el formulario dentro del panel
        vendidosForm.Show()
    End Sub
#End Region
#End Region
End Class