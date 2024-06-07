Public Class Productos

#Region "Load"
    Private Sub Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
#End Region


#Region "Redirección"
#Region " Recibir Panel"
    Private panelContenedor As Panel
    ' Constructor para recibir el panel contenedor
    Public Sub New(panel As Panel)
        InitializeComponent()
        Me.panelContenedor = panel
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
End Class