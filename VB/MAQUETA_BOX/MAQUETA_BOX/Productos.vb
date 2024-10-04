Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Wordprocessing
Imports SixLabors.Fonts

Public Class Productos

#Region "Load"
    Private Sub Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Cargar_Grilla()
        cargar_cbo_tipo()
        cargar_cbo_proveedores()
        cargar_cbo_vehiculos()
        cargar_cbo_marcas()

        'Prueba 
        Dim columnaCosto As DataGridViewColumn = BunifuDataGridView1.Columns("ColumnCosto")
        Dim columnaPrecio As DataGridViewColumn = BunifuDataGridView1.Columns("ColumnPrecio")
        Dim columnaGanancia As DataGridViewColumn = BunifuDataGridView1.Columns("ColumnGanancia")

        ' Configuración para la columna de Costo
        columnaCosto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaCosto.DefaultCellStyle.Format = "C2"

        ' Configuración para la columna de Precio
        columnaPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaPrecio.DefaultCellStyle.Format = "C2"

        ' Configuración para la columna de Ganancia
        columnaGanancia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaGanancia.DefaultCellStyle.Format = "C2"


    End Sub
#End Region
#Region "Limpiar"
    Private Sub Limpiar()
        txtDescripcion.Text = Nothing
        txtCantidad.Text = Nothing
        txtCosto.Text = Nothing
        txtGanancia.Text = Nothing
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
        comando.CommandText = ("Consultar_Productos_Gestion")

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
#Region "Cargar Combo Tipo"
    Private Sub cargar_cbo_tipo()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_cbo_Tipo_Producto")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboTipo.DataSource = oDs.Tables(0)
            cboTipo.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboTipo.ValueMember = oDs.Tables(0).Columns(0).ToString
        End If
        oDs = Nothing
        conexion.Close()
    End Sub
#End Region
#Region "Cargar Combo Proveedores"
    Private Sub cargar_cbo_proveedores()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_cbo_Proveedores")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboProveedor.DataSource = oDs.Tables(0)
            cboProveedor.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboProveedor.ValueMember = oDs.Tables(0).Columns(0).ToString
        End If
        oDs = Nothing
        conexion.Close()
    End Sub
#End Region
#Region "Cargar Combo Vehiculos"
    Private Sub cargar_cbo_vehiculos()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_cbo_Vehiculos")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboVehiculo.DataSource = oDs.Tables(0)
            cboVehiculo.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboVehiculo.ValueMember = oDs.Tables(0).Columns(0).ToString
        End If
        oDs = Nothing
        conexion.Close()
    End Sub
#End Region
#Region "Cargar Combo Marcas"
    Private Sub cargar_cbo_marcas()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_cbo_Marcas")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboMarca.DataSource = oDs.Tables(0)
            cboMarca.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboMarca.ValueMember = oDs.Tables(0).Columns(0).ToString
        End If
        oDs = Nothing
        conexion.Close()
    End Sub



#End Region
#Region "Cargar Productos"
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If txtDescripcion.Text <> Nothing And txtCosto.Text <> Nothing And txtGanancia.Text <> Nothing Then

            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Productos")

            With comando.Parameters
                .AddWithValue("@idtipo", cboTipo.SelectedValue)
                .AddWithValue("@descripcion", txtDescripcion.Text)
                .AddWithValue("@idproveedor", cboProveedor.SelectedValue)
                .AddWithValue("@idvehiculo", cboVehiculo.SelectedValue)
                .AddWithValue("@costo", txtCosto.Text)
                .AddWithValue("@ganancia", txtGanancia.Text)
                .AddWithValue("@cantidad", txtCantidad.Text)
                .AddWithValue("@idmarca", cboMarca.SelectedValue)

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
#End Region

#Region "Eliminar Productos"
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtCodigo.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Eliminar_Productos")
            With comando.Parameters
                .AddWithValue("@idproducto", txtCodigo.Text)
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
#Region "Modificar Producto"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtCodigo.Text <> Nothing And txtCantidad.Text <> Nothing And txtCosto.Text <> Nothing And txtDescripcion.Text <> Nothing And txtGanancia.Text Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Modificar_Productos")

            With comando.Parameters
                .AddWithValue("@idproducto", txtCodigo.Text)
                .AddWithValue("@idtipo", cboTipo.SelectedValue)
                .AddWithValue("@descripcion", txtDescripcion.Text)
                .AddWithValue("@idproveedor", cboProveedor.SelectedValue)
                .AddWithValue("@idvehiculo", cboVehiculo.SelectedValue)
                .AddWithValue("@costo", txtCosto.Text)
                .AddWithValue("@ganancia", txtGanancia.Text)
                .AddWithValue("@cantidad", txtCantidad.Text)
                .AddWithValue("@idmarca", cboMarca.SelectedValue)
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
#Region "Cargar textbox productos"
    Private Sub BunifuDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
            txtCodigo.Text = row.Cells("ID").Value.ToString()
            txtDescripcion.Text = row.Cells("Descripción").Value.ToString()
            cboMarca.Text = row.Cells("Marca").Value.ToString()
            cboVehiculo.Text = row.Cells("Vehículo").Value.ToString()
            cboProveedor.Text = row.Cells("Proveedor").Value.ToString()
            txtCantidad.Text = row.Cells("Stock").Value.ToString()
            txtCosto.Text = row.Cells("Costo").Value.ToString()
            txtGanancia.Text = row.Cells("Ganancia").Value.ToString()
        End If
    End Sub
#End Region
#Region "Metodo Filtrar Busqueda"
    Private Sub FiltrarGrilla()
        Dim textoBusqueda As String = txtBuscarProductos.Text.Trim()

        ' Verificar que dt no sea Nothing
        If dt IsNot Nothing Then
            ' Crear un DataView para filtrar los datos
            Dim dataView As New DataView(dt)

            ' Construir el filtro basado en las selecciones
            Dim filtro As String = String.Empty
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

    Private Sub txtBuscarProdcutos_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProductos.TextChanged
        FiltrarGrilla()
    End Sub

#End Region


End Class