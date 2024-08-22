Imports System.Data.SqlClient

Public Class Productos_Listado
#Region "Load"
    Private Sub Productos_Listado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cboTipo.Items.Add("Todos")
        cboTipo.Items.Add("Producto")
        cboTipo.Items.Add("Servicio")
        cboTipo.SelectedIndex = 0
        Cargar_Grilla()
        CargarComboVehiculo()
        CargarComboProducto()
        CargarComboServicio()
        CargarComboTipo()
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
    Private Sub btnVendidos_Click(sender As Object, e As EventArgs)
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
    Private Sub CargarComboTipo()
        If dt IsNot Nothing Then
            Dim tipos = dt.AsEnumerable().Select(Function(row) row.Field(Of String)("Tipo")).Distinct().ToList()
            cboTipo.Items.Clear()
            cboTipo.Items.Add("Todos")
            cboTipo.Items.AddRange(tipos.ToArray())
            cboTipo.SelectedIndex = 0
        End If
    End Sub
    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged

        ' Filtrar el DataGridView
        FiltrarGrilla()
    End Sub
#End Region

#Region "Filtrar Por Vehículo"
    Private Sub CargarComboVehiculo()
        If dt IsNot Nothing Then
            Dim vehiculos = dt.AsEnumerable().Select(Function(row) row.Field(Of String)("Vehículo")).Distinct().ToList()
            cboVehiculo.Items.Clear()
            cboVehiculo.Items.Add("Todos")
            cboVehiculo.Items.AddRange(vehiculos.ToArray())
            cboVehiculo.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVehiculo.SelectedIndexChanged
        FiltrarGrilla()
    End Sub
#End Region

#Region "Filtrar por Producto"
    Private Sub CargarComboProducto()
        If dt IsNot Nothing Then
            ' Filtrar las filas donde la columna Tipo es "Producto" y obtener los valores únicos de la columna Descripción
            Dim productos = dt.AsEnumerable().
                         Where(Function(row) row.Field(Of String)("Tipo") <> "Servicio").
                         Select(Function(row) row.Field(Of String)("Descripción")).
                         Distinct().
                         ToList()

            cboProducto.Items.Clear()
            cboProducto.Items.Add("Todos")
            cboProducto.Items.AddRange(productos.ToArray())
            cboProducto.SelectedIndex = 0
        End If
    End Sub
    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged
        FiltrarGrilla()
    End Sub
#End Region

#Region "Filtrar por Servicio"
    Private Sub CargarComboServicio()
        If dt IsNot Nothing Then
            ' Filtrar las filas donde la columna Tipo es "Servicio" y obtener los valores únicos de la columna Descripción
            Dim servicios = dt.AsEnumerable().
                         Where(Function(row) row.Field(Of String)("Tipo") = "Servicio").
                         Select(Function(row) row.Field(Of String)("Descripción")).
                         Distinct().
                         ToList()

            cboServicio.Items.Clear()
            cboServicio.Items.Add("Todos")
            cboServicio.Items.AddRange(servicios.ToArray())
            cboServicio.SelectedIndex = 0
        End If
    End Sub
    Private Sub cboServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServicio.SelectedIndexChanged
        FiltrarGrilla()
    End Sub
#End Region

#Region "Metodo Filtrar Grilla"
    Private Sub FiltrarGrilla()
        ' Asegúrate de que haya elementos seleccionados en todos los ComboBoxes
        If cboTipo.SelectedItem Is Nothing OrElse cboVehiculo.SelectedItem Is Nothing OrElse cboProducto.SelectedItem Is Nothing OrElse cboServicio.SelectedItem Is Nothing Then Exit Sub

        Dim tipoSeleccionado As String = cboTipo.SelectedItem.ToString()
        Dim vehiculoSeleccionado As String = cboVehiculo.SelectedItem.ToString()
        Dim productoSeleccionado As String = cboProducto.SelectedItem.ToString()
        Dim servicioSeleccionado As String = cboServicio.SelectedItem.ToString()
        Dim textoBusqueda As String = txtBuscarProductos.Text.Trim()

        ' Verificar que dt no sea Nothing
        If dt IsNot Nothing Then
            ' Crear un DataView para filtrar los datos
            Dim dataView As New DataView(dt)

            ' Construir el filtro basado en las selecciones
            Dim filtro As String = String.Empty
            If tipoSeleccionado <> "Todos" Then
                filtro = $"Tipo = '{tipoSeleccionado}'"
            End If
            If vehiculoSeleccionado <> "Todos" Then
                If filtro <> String.Empty Then filtro &= " AND "
                filtro &= $"Vehículo = '{vehiculoSeleccionado}'"
            End If
            If productoSeleccionado <> "Todos" Then
                If filtro <> String.Empty Then filtro &= " AND "
                filtro &= $"Descripción = '{productoSeleccionado}'"
            End If
            If servicioSeleccionado <> "Todos" Then
                If filtro <> String.Empty Then filtro &= " AND "
                filtro &= $"Descripción = '{servicioSeleccionado}'"
            End If
            If Not String.IsNullOrEmpty(textoBusqueda) Then
                If filtro <> String.Empty Then filtro &= " AND "
                filtro &= $"Descripción LIKE '%{textoBusqueda}%'"
            End If

            ' Aplicar el filtro
            dataView.RowFilter = filtro

            ' Asignar el DataView como origen de datos del DataGridView
            BunifuDataGridView1.DataSource = dataView
        End If
    End Sub
#End Region

#Region "Busqueda inteligente"
    Private Sub txtBuscarProductos_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProductos.TextChanged
        FiltrarGrilla()
    End Sub
#End Region
#Region "Otros"
    Private Sub BunifuDataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles BunifuDataGridView1.CellFormatting
        ' Verifica si la columna es la que deseas formatear
        If e.ColumnIndex = BunifuDataGridView1.Columns("Precio").Index Then
            ' Verifica si el valor es un número
            If e.Value IsNot Nothing AndAlso IsNumeric(e.Value) Then
                ' Formatea el valor a dos decimales
                e.Value = String.Format("{0:F2}", Convert.ToDecimal(e.Value))
                e.FormattingApplied = True
            End If
        End If
    End Sub
#End Region
End Class