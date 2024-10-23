

Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Estadisticas
    Dim conexion As SqlConnection = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
    Dim dr As SqlDataReader
    Dim comando As New SqlCommand
    Dim produc As New List(Of String)()
    Dim CantProduct As New List(Of Integer)()
    Dim Producto As New ArrayList
    Dim Cant As New ArrayList
    Dim Productos As New List(Of String)()
    Dim CantidadProductos As New List(Of Integer)()
    Dim vistaInicial As Boolean = True
    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProductosMasVendidosDelDia()
        ProdPreferidos()
        DashboardDatos()
    End Sub

    ' Variable para controlar si se están mostrando productos del mes o del día
    Private mostrandoProductosDelMes As Boolean = False
    Dim hayVentas As Boolean = False
    ' Variable para controlar si se están mostrando las ventas del mes o del día
    Private mostrandoVentasDelMes As Boolean = False

    ' Método para mostrar los productos más vendidos del día
    Private Sub MostrarProductosMasVendidosDelDia()
        ' Configurar conexión
        Dim connectionString As String = "data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123"
        Dim query As String = "ProductosMasVendidosDelDia"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure

                connection.Open()

                ' Ejecutar el comando y obtener los resultados
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Limpiar series anteriores
                chartProductodelDia.Series.Clear()

                ' Crear una nueva serie para el día
                Dim series As New Series("Productos Más Vendidos del Día")
                series.ChartType = SeriesChartType.Bar
                series.Palette = ChartColorPalette.BrightPastel
                series.IsValueShownAsLabel = True
                series.CustomProperties = "BarLabelStyle=Center"
                series.LabelForeColor = Color.White
                chartProductodelDia.Series.Add(series)

                ' Variable para controlar si hay ventas
                Dim hayVentas As Boolean = False

                ' Rellenar la serie con los datos del reader
                While reader.Read()
                    Dim descripcionProducto As String = reader("Descripcion").ToString()
                    Dim totalVendidos As Integer = Convert.ToInt32(reader("TotalVendidos"))

                    ' Añadir los datos a la serie
                    series.Points.AddXY(descripcionProducto, totalVendidos)
                    hayVentas = True ' Al menos un producto fue vendido hoy
                End While

                reader.Close()

                ' Verificar si hubo ventas
                If hayVentas Then
                    ' Cambiar el título del gráfico para reflejar que ahora muestra datos del día
                    chartProductodelDia.Titles.Clear()
                    chartProductodelDia.Titles.Add("Productos Más Vendidos del Día")
                    mostrandoVentasDelMes = False ' Ahora estamos mostrando las ventas del día
                Else
                    ' Si no hubo ventas hoy, llamar al método para mostrar productos del mes
                    MostrarProductosMasVendidosDelMesActual()
                End If
            End Using
        End Using
    End Sub

    ' Método para mostrar los productos más vendidos del mes actual
    Private Sub MostrarProductosMasVendidosDelMesActual()
        ' Configurar conexión
        Dim connectionString As String = "data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123"
        Dim query As String = "ProductosMasVendidosDelMesActual"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.CommandType = CommandType.StoredProcedure

                connection.Open()

                ' Ejecutar el comando y obtener los resultados
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Limpiar series anteriores
                chartProductodelDia.Series.Clear()

                ' Crear una nueva serie para el mes
                Dim series As New Series("Productos Más Vendidos del Mes")
                series.ChartType = SeriesChartType.Bar
                series.Palette = ChartColorPalette.BrightPastel
                series.IsValueShownAsLabel = True
                series.CustomProperties = "BarLabelStyle=Center"
                series.LabelForeColor = Color.White
                chartProductodelDia.Series.Add(series)

                ' Rellenar la serie con los datos del reader
                While reader.Read()
                    Dim descripcionProducto As String = reader("Descripcion").ToString()
                    Dim totalVendidos As Integer = Convert.ToInt32(reader("TotalVendidos"))

                    series.Points.AddXY(descripcionProducto, totalVendidos)
                End While

                reader.Close()
            End Using
        End Using

        ' Cambiar el título del gráfico para reflejar que ahora muestra datos del mes
        chartProductodelDia.Titles.Clear()
        chartProductodelDia.Titles.Add("Productos Más Vendidos del Mes")
        mostrandoVentasDelMes = True ' Ahora estamos mostrando las ventas del mes
    End Sub

    ' Método que alterna entre productos del día y del mes al hacer clic en el gráfico
    Private Sub chartProductodelDia_Click(sender As Object, e As EventArgs) Handles chartProductodelDia.Click
        If mostrandoVentasDelMes Then
            ' Si actualmente se muestran los productos del mes, cambiar a los productos del día
            MostrarProductosMasVendidosDelDia()
        Else
            ' Si actualmente se muestran los productos del día, cambiar a los productos del mes
            MostrarProductosMasVendidosDelMesActual()
        End If
    End Sub



    Public Sub GrafCategorias2()
        comando = New SqlCommand("ProductosMasVendidosDelMesActual", conexion)
        comando.CommandType = CommandType.StoredProcedure
        conexion.Open()
        dr = comando.ExecuteReader
        While (dr.Read)
            produc.Add(dr.GetString(0))
            CantProduct.Add(dr.GetInt32(1))
        End While
        chartProductodelDia.Series(0).Points.DataBindXY(produc, CantProduct)
        dr.Close()
        conexion.Close()


    End Sub

    Public Sub ProdPreferidos()
        comando = New SqlCommand("ProdPreferidos", conexion)
        comando.CommandType = CommandType.StoredProcedure
        conexion.Open()
        dr = comando.ExecuteReader
        While (dr.Read)
            Producto.Add(dr.GetString(0))
            Cant.Add(dr.GetInt32(1))
        End While
        ChartProdPreferidos.Series(0).Points.DataBindXY(Producto, Cant)
        dr.Close()
        conexion.Close()


    End Sub
    Public Sub DashboardDatos()
        Dim comando As New SqlCommand("Dashboard", conexion)
        comando.CommandType = CommandType.StoredProcedure
        Dim Total As New SqlParameter("@TotVentas", SqlDbType.Int)
        Total.Direction = ParameterDirection.Output
        Dim TotalP As New SqlParameter("@TotPedidos", SqlDbType.Int)
        TotalP.Direction = ParameterDirection.Output
        Dim CantProduc As New SqlParameter("@CantProducto", SqlDbType.Int)
        CantProduc.Direction = ParameterDirection.Output
        Dim CantClientes As New SqlParameter("@CantClientes", SqlDbType.Int)
        CantClientes.Direction = ParameterDirection.Output
        Dim CantRubros As New SqlParameter("@CantRubros", SqlDbType.Int)
        CantRubros.Direction = ParameterDirection.Output
        Dim CantProveedores As New SqlParameter("@CantProveedores", SqlDbType.Int)
        CantProveedores.Direction = ParameterDirection.Output
        comando.Parameters.Add(Total)
        comando.Parameters.Add(TotalP)
        comando.Parameters.Add(CantProduc)
        comando.Parameters.Add(CantClientes)
        comando.Parameters.Add(CantRubros)
        comando.Parameters.Add(CantProveedores)
        conexion.Open()
        comando.ExecuteNonQuery()
        lblVentas.Text = comando.Parameters("@TotVentas").Value.ToString()
        lblProductos.Text = comando.Parameters("@CantProducto").Value.ToString()
        lblPresupuesto.Text = comando.Parameters("@TotPedidos").Value.ToString()
        lblProveedores.Text = comando.Parameters("@CantProveedores").Value.ToString()
        lblClientes.Text = comando.Parameters("@CantClientes").Value.ToString()
        lblCategorias.Text = comando.Parameters("@CantRubros").Value.ToString()
        conexion.Close()
    End Sub





    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Panel1.Controls.Clear()
        Dim newForm As New EstadisticaVentas() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show() ' Muestra el formulario
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Panel1.Controls.Clear()
        Dim newForm As New EstadisticaClientes() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show() ' Muestra el formulario
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Panel1.Controls.Clear()
        Dim newForm As New EstadisticaCategoria() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show() ' Muestra el formulario
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Panel1.Controls.Clear()
        Dim newForm As New EstadisticaProductos() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show() ' Muestra el formulario
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Panel1.Controls.Clear()
        Dim newForm As New EstadisticaProveedores() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show() ' Muestra el formulario
    End Sub
End Class