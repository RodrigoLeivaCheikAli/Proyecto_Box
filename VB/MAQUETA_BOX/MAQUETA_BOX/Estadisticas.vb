

Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Estadisticas
    Dim conexion As SqlConnection = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
    Dim dr As SqlDataReader
    Dim comando As New SqlCommand
     Dim Rubro As New List(Of String)()
    Dim CantProduct As New List(Of Integer)()
    Dim Producto As New ArrayList
    Dim Cant As New ArrayList
    Dim Productos As New List(Of String)()
    Dim CantidadProductos As New List(Of Integer)()
    Dim vistaInicial As Boolean = True
    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrafCategorias()
        ProdPreferidos()
        DashboardDatos()
    End Sub

    Public Sub GrafCategorias()
        comando = New SqlCommand("ProdPorRubro", conexion)
        comando.CommandType = CommandType.StoredProcedure
        conexion.Open()
        dr = comando.ExecuteReader
        While (dr.Read)
            Rubro.Add(dr.GetString(0))
            CantProduct.Add(dr.GetInt32(1))
        End While
        chartProductoPorCategoria.Series(0).Points.DataBindXY(Rubro, CantProduct)
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

End Class