Public Class Productos_Vendidos
#Region "Load"
    Private Sub Productos_Vendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
#Region "Listado"
    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        ' Crear una instancia del formulario Productos_Listado
        Dim listadoForm As New Productos_Listado(panelContenedor)

        ' Configurar el formulario Productos_Listado para que no sea de nivel superior
        listadoForm.TopLevel = False

        ' Limpiar el panelContenedor antes de agregar el nuevo formulario
        panelContenedor.Controls.Clear()

        ' Agregar el formulario Productos_Listado al panelContenedor
        panelContenedor.Controls.Add(listadoForm)

        ' Ajustar el tamaño del formulario al panel
        listadoForm.Dock = DockStyle.Fill

        ' Mostrar el formulario dentro del panel
        listadoForm.Show()
    End Sub
#End Region
#End Region
End Class