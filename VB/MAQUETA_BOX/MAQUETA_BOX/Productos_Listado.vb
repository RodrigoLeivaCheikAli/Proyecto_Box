Imports System.Data.SqlClient

Public Class Productos_Listado
#Region "Load"
    Private Sub Productos_Listado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cboTipo.Items.Add("Todos")
        cboTipo.Items.Add("Producto")
        cboTipo.Items.Add("Servicio")
        cboTipo.SelectedIndex = 0
        Cargar_Grilla()
    End Sub
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
        comando.CommandText = ("Consultar_Productos_Stock")

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
#Region "Filtrar por Tipo"
    Private Sub FiltrarGrilla()
        ' Asegúrate de que haya un elemento seleccionado en el ComboBox
        If cboTipo.SelectedItem Is Nothing Then Exit Sub

        Dim tipoSeleccionado As String = cboTipo.SelectedItem.ToString()

        ' Verificar que dt no sea Nothing
        If dt IsNot Nothing Then
            ' Crear un DataView para filtrar los datos
            Dim dataView As New DataView(dt)

            ' Aplicar el filtro basado en la selección del ComboBox
            If tipoSeleccionado = "Todos" Then
                dataView.RowFilter = String.Empty
            Else
                dataView.RowFilter = $"Tipo = '{tipoSeleccionado}'"
            End If

            ' Asignar el DataView como origen de datos del DataGridView
            BunifuDataGridView1.DataSource = dataView
        End If
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        ' Filtrar el DataGridView
        FiltrarGrilla()
    End Sub
#End Region
End Class