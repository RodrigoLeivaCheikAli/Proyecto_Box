Imports System.Data.SqlClient
Imports System.Configuration

Public Class ProvComparaciones
    Dim connectionString As String = "data source = 168.197.51.109; initial catalog = PIN_GRUPO11; user id = PIN_GRUPO11; password = PIN_GRUPO11123"
    Dim connection As New SqlConnection(connectionString)

    Private panelContenedor As Panel
    Public Sub New(panel As Panel)
        InitializeComponent()
        Me.panelContenedor = panel
    End Sub

#Region "Load"
    Private Sub ProvComparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()

#Region "Cbo Productos"
            Dim query As String = "SELECT * FROM Tipos_de_Ofertas"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            cboProducto.DataSource = table
            cboProducto.DisplayMember = "Tipo"
            cboProducto.ValueMember = "Id_Tipos_Ofertas"
#End Region

#Region "cbo Proveedores"
            Dim providerQuery As String = "SELECT Id_Proveedor, Nombre FROM Proveedores"
            Dim providerAdapter As New SqlDataAdapter(providerQuery, connection)
            Dim providerTable As New DataTable()
            providerAdapter.Fill(providerTable)
            cboProveedor.DataSource = providerTable
            cboProveedor.DisplayMember = "Nombre"
            cboProveedor.ValueMember = "Id_Proveedor"
#End Region

#Region "cbo Marcas"
            Dim brandQuery As String = "SELECT Id_Marca, Nombre FROM Marcas"
            Dim brandAdapter As New SqlDataAdapter(brandQuery, connection)
            Dim brandTable As New DataTable()
            brandAdapter.Fill(brandTable)
            cboMarca.DataSource = brandTable
            cboMarca.DisplayMember = "Nombre"
            cboMarca.ValueMember = "Id_Marca"
#End Region

            Limpiar()
            CargarGrilla()

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
#End Region

#Region "Comparar"
    Private Sub ButtonComparar_Click(sender As Object, e As EventArgs) Handles ButtonComparar.Click
        Try
            Dim query As New Text.StringBuilder("SELECT  P.Nombre AS Proveedor,T.Tipo, O.Descripcion, M.Nombre as Marca, O.Precio_Costo AS Precio
                                            FROM Ofertas O
                                            INNER JOIN Proveedores P ON O.Id_Proveedor = P.Id_Proveedor
                                            INNER JOIN Marcas M ON O.Id_Marca = M.Id_Marca
                                            INNER JOIN Tipos_de_Ofertas T ON O.Id_Tipo_Oferta = T.Id_Tipos_Ofertas
                                            WHERE 1=1")
            Dim command As New SqlCommand()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Agregar filtro de Tipo de Oferta si está seleccionado
                If cboProducto.SelectedIndex <> -1 AndAlso cboProducto.SelectedValue IsNot Nothing Then
                    Dim tipoOfertaId As Integer
                    If Integer.TryParse(cboProducto.SelectedValue.ToString(), tipoOfertaId) Then
                        query.Append(" AND T.Id_Tipos_Ofertas = @IdProducto")
                        command.Parameters.AddWithValue("@IdProducto", tipoOfertaId)
                    End If
                End If

                ' Agregar filtro de Proveedor si está seleccionado
                If cboProveedor.SelectedIndex <> -1 AndAlso cboProveedor.SelectedValue IsNot Nothing Then
                    Dim proveedorId As Integer
                    If Integer.TryParse(cboProveedor.SelectedValue.ToString(), proveedorId) Then
                        query.Append(" AND O.Id_Proveedor = @IdProveedor")
                        command.Parameters.AddWithValue("@IdProveedor", proveedorId)
                    End If
                End If

                ' Agregar filtro de Marca si está seleccionado
                If cboMarca.SelectedIndex <> -1 AndAlso cboMarca.SelectedValue IsNot Nothing Then
                    Dim marcaId As Integer
                    If Integer.TryParse(cboMarca.SelectedValue.ToString(), marcaId) Then
                        query.Append(" AND O.Id_Marca = @IdMarca")
                        command.Parameters.AddWithValue("@IdMarca", marcaId)
                    End If
                End If

                ' Agregar filtro de Precio Mínimo
                Dim minPrice As Decimal = If(String.IsNullOrEmpty(txtPrecioMin.Text), 0, Convert.ToDecimal(txtPrecioMin.Text))
                query.Append(" AND O.Precio_Costo >= @MinPrice")
                command.Parameters.AddWithValue("@MinPrice", minPrice)

                ' Agregar filtro de Precio Máximo
                Dim maxPrice As Decimal = If(String.IsNullOrEmpty(txtPrecioMax.Text), Decimal.MaxValue, Convert.ToDecimal(txtPrecioMax.Text))
                query.Append(" AND O.Precio_Costo <= @MaxPrice")
                command.Parameters.AddWithValue("@MaxPrice", maxPrice)

                ' Agregar filtro de Descripción
                Dim searchDescription As String = txtDescripcion.Text
                If Not String.IsNullOrEmpty(searchDescription) Then
                    query.Append(" AND O.Descripcion LIKE @Descripcion")
                    command.Parameters.AddWithValue("@Descripcion", "%" & searchDescription & "%")
                End If

                command.CommandText = query.ToString()
                command.Connection = connection

                Using adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al realizar la comparación: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "Limpiar"
    Public Sub Limpiar()
        cboProducto.SelectedIndex = -1
        cboProveedor.SelectedIndex = -1
        cboMarca.SelectedIndex = -1

        txtPrecioMin.Clear()
        txtPrecioMax.Clear()
        txtDescripcion.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas limpiar todos los filtros y datos?", "Confirmación", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Limpiar()
            CargarGrilla()
        End If
    End Sub

#End Region

#Region "Cargar grilla"
    Private Sub CargarGrilla()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT TOP 100 P.Nombre AS Proveedor,T.Tipo, O.Descripcion, M.Nombre as Marca, O.Precio_Costo AS Precio
                                   FROM Ofertas O
                                   INNER JOIN Proveedores P ON O.Id_Proveedor = P.Id_Proveedor
                                   INNER JOIN Marcas M ON O.Id_Marca = M.Id_Marca
                                   INNER JOIN Tipos_de_Ofertas T ON O.Id_Tipo_Oferta = T.Id_Tipos_Ofertas
                                   ORDER BY O.Precio_Costo DESC"

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    DataGridView1.DataSource = table
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar la grilla: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "Otros"
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        ' Verifica si la columna es la que deseas formatear
        If e.ColumnIndex = DataGridView1.Columns("Precio").Index Then
            ' Verifica si el valor es un número
            If e.Value IsNot Nothing AndAlso IsNumeric(e.Value) Then
                ' Formatea el valor a dos decimales
                e.Value = String.Format("{0:F2}", Convert.ToDecimal(e.Value))
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub txtPrecioMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioMin.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecioMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioMax.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region

End Class
