Imports System.Data.SqlClient
Imports System.Configuration

Public Class ProvComparaciones
    Dim connectionString As String = "Data Source=TU_SERVIDOR;Initial Catalog=TU_BASE_DE_DATOS;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

#Region "Load"
    Private Sub ProvComparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()

#Region "Cbo Productos"
            Dim query As String = "SELECT Id_Tipo_Oferta, Tipo FROM Tipos_de_Ofertas"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            cboProducto.DataSource = table
            cboProducto.DisplayMember = "Tipo"
            cboProducto.ValueMember = "Id_Tipo_Oferta"
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
            connection.Open()

            Dim selectedProductId As Integer = cboProducto.SelectedValue
            Dim selectedProviderId As Integer = cboProveedor.SelectedValue
            Dim selectedBrandId As Integer = cboMarca.SelectedValue
            Dim minPrice As Decimal = If(txtPrecioMin.Text = "", 0, Convert.ToDecimal(txtPrecioMin.Text))
            Dim maxPrice As Decimal = If(txtPrecioMax.Text = "", Decimal.MaxValue, Convert.ToDecimal(txtPrecioMax.Text))
            Dim searchDescription As String = txtDescripcion.Text

            Dim query As String = "SELECT O.Descripcion, P.Nombre, O.Precio_Costo 
                                   FROM Ofertas O 
                                   INNER JOIN Proveedores P ON O.Id_Proveedor = P.Id_Proveedor
                                   WHERE O.Id_Tipo_Oferta = @IdProducto
                                   AND O.Id_Proveedor = @IdProveedor
                                   AND O.Precio_Costo BETWEEN @MinPrice AND @MaxPrice
                                   AND O.Id_Marca = @IdMarca
                                   AND O.Descripcion LIKE @Descripcion"

            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdProducto", selectedProductId)
            command.Parameters.AddWithValue("@IdProveedor", selectedProviderId)
            command.Parameters.AddWithValue("@MinPrice", minPrice)
            command.Parameters.AddWithValue("@MaxPrice", maxPrice)
            command.Parameters.AddWithValue("@IdMarca", selectedBrandId)
            command.Parameters.AddWithValue("@Descripcion", "%" & searchDescription & "%")

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error al realizar la comparación: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
#End Region

#Region "Limpiar"
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas limpiar todos los filtros y datos?", "Confirmación", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            cboProducto.SelectedIndex = -1
            cboProveedor.SelectedIndex = -1
            cboMarca.SelectedIndex = -1

            txtPrecioMin.Clear()
            txtPrecioMax.Clear()
            txtDescripcion.Clear()

            CargarGrilla()
        End If
    End Sub
#End Region

#Region "Cargar grilla"
    Private Sub CargarGrilla()
        Try
            connection.Open()

            Dim query As String = "SELECT TOP 100 O.Descripcion, P.Nombre AS Proveedor, M.Nombre AS Marca, O.Precio_Costo 
                                   FROM Ofertas O
                                   INNER JOIN Proveedores P ON O.Id_Proveedor = P.Id_Proveedor
                                   INNER JOIN Marcas M ON O.Id_Marca = M.Id_Marca
                                   ORDER BY O.Precio_Costo DESC"

            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error al cargar la grilla: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
#End Region

End Class
