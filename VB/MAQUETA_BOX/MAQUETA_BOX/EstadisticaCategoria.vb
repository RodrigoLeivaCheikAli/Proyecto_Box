Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections
Imports System.Windows.Forms.DataVisualization.Charting
Public Class EstadisticaCategoria
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
    Private Sub EstadisticaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrafCategorias()
    End Sub
    Public Sub GrafCategorias()
        Rubro.Clear()
        CantProduct.Clear()

        comando = New SqlCommand("ProdPorRubro", conexion)
        comando.CommandType = CommandType.StoredProcedure
        conexion.Open()
        dr = comando.ExecuteReader()
        While dr.Read()
            Rubro.Add(dr.GetString(0)) ' Nombre de la categoría
            CantProduct.Add(dr.GetInt32(1)) ' Cantidad de productos
        End While
        chartProductoPorCategoria.Series.Clear()

        ' Crear una serie nueva para las categorías
        Dim series As New Series("Categorías")
        series.ChartType = SeriesChartType.Bar
        series.Points.DataBindXY(Rubro, CantProduct)
        series.Palette = ChartColorPalette.BrightPastel
        series.IsValueShownAsLabel = True
        series.CustomProperties = "BarLabelStyle=Center"
        series.LabelForeColor = Color.White
        series.Font = New Font("Arial", 20, FontStyle.Bold)

        chartProductoPorCategoria.Series.Add(series)


        dr.Close()
        conexion.Close()
        vistaInicial = True ' Volver a la vista inicial
    End Sub

    ' Cargar el gráfico con productos de una categoría específica
    Public Sub MostrarProductosPorCategoria(categoria As String)
        comando = New SqlCommand("Est_ProductosPorCategoria", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@Categoria", categoria)
        conexion.Open()
        dr = comando.ExecuteReader()

        Dim Productos As New List(Of String)()
        Dim CantidadProductos As New List(Of Integer)()

        While dr.Read()
            Productos.Add(dr.GetString(0)) ' Nombre del producto
            CantidadProductos.Add(dr.GetInt32(1)) ' Cantidad vendida
        End While

        ' Limpiar las series anteriores
        chartProductoPorCategoria.Series.Clear()

        ' Crear una nueva serie para los productos
        Dim series As New Series(categoria)
        series.ChartType = SeriesChartType.Bar
        series.Points.DataBindXY(Productos, CantidadProductos)
        series.Palette = ChartColorPalette.BrightPastel
        series.IsValueShownAsLabel = True
        series.CustomProperties = "BarLabelStyle=Center"
        series.LabelForeColor = Color.White
        series.Font = New Font("Arial", 20, FontStyle.Bold)
        chartProductoPorCategoria.Series.Add(series)

        dr.Close()
        conexion.Close()
        vistaInicial = False ' Ahora estamos viendo productos, no categorías
    End Sub

    ' Evento cuando se hace clic en el gráfico
    Private Sub chartProductoPorCategoria_MouseClick(sender As Object, e As MouseEventArgs) Handles chartProductoPorCategoria.MouseClick
        Dim hit As HitTestResult = chartProductoPorCategoria.HitTest(e.X, e.Y)

        ' Verificar si el clic fue en un punto de datos (barra)
        If hit.ChartElementType = ChartElementType.DataPoint Then
            If vistaInicial Then
                ' Si estamos en la vista de categorías, mostrar productos
                Dim selectedPoint As DataPoint = chartProductoPorCategoria.Series(0).Points(hit.PointIndex)
                Dim categoria As String = selectedPoint.AxisLabel ' Obtener el nombre de la categoría

                ' Llamar al método para mostrar los productos de la categoría seleccionada
                MostrarProductosPorCategoria(categoria)
            Else
                ' Si estamos viendo productos, volver a mostrar las categorías
                GrafCategorias()
            End If
        End If
    End Sub
End Class