Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections
Imports System.Windows.Forms.DataVisualization.Charting
Public Class EstadisticaProductos
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
End Class