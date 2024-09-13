Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Irony.Parsing

Public Class EstadisticaClientes
    Dim conexion As SqlConnection = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
    Dim comando As SqlCommand
    Dim dr As SqlDataReader

    ' Declarar listas separadas para cada gráfico
    Dim ClienteFrecuentes As New List(Of String)()
    Dim CantVent As New List(Of Integer)()
    Dim ClienteGastan As New List(Of String)()
    Dim CantGastan As New List(Of Double)()
    Dim Productos As New List(Of String)()
    Dim Cantprod As New List(Of Integer)()
    Private Sub EstadisticaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grilla()
        ClientesMasFrecuentes()
        ClintesqueMasGastan()
    End Sub

    Public Sub ClientesMasFrecuentes()
        ' Limpiar listas antes de usarlas
        ClienteFrecuentes.Clear()
        CantVent.Clear()

        ' Usar 'Using' para manejar la conexión y el comando
        Using conexion As New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
            comando = New SqlCommand("Estadistica_Clientfrecuentes", conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()
            Using dr As SqlDataReader = comando.ExecuteReader()
                While (dr.Read)
                    ClienteFrecuentes.Add(dr.GetString(0))
                    CantVent.Add(dr.GetInt32(1))
                End While
            End Using ' Cierra el DataReader automáticamente
        End Using ' Cierra la conexión automáticamente

        ' Vincular datos al gráfico
        ChartClientesMasFrecuentes.Series(0).Points.DataBindXY(ClienteFrecuentes, CantVent)
    End Sub

    Public Sub ClintesqueMasGastan()
        ' Limpiar listas antes de usarlas
        ClienteGastan.Clear()
        CantGastan.Clear()

        ' Usar 'Using' para manejar la conexión y el comando
        Using conexion As New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
            comando = New SqlCommand("Est_ClientconMasGastos", conexion)
            comando.CommandType = CommandType.StoredProcedure

            conexion.Open()
            Using dr As SqlDataReader = comando.ExecuteReader()
                While (dr.Read)
                    ClienteGastan.Add(dr.GetString(0))
                    CantGastan.Add(Math.Round(dr.GetDouble(1), 2))
                End While
            End Using ' Cierra el DataReader automáticamente
        End Using ' Cierra la conexión automáticamente

        ' Vincular datos al gráfico
        ChartClienteMasGastan.Series(0).Points.DataBindXY(ClienteGastan, CantGastan)
    End Sub

    Private Sub Cargar_Grilla()
        Dim dt As DataTable

        ' Usar 'Using' para manejar la conexión y el comando
        Using conexion As New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
            Using comando As New SqlCommand("Consultar_Clientes", conexion)
                comando.CommandType = CommandType.StoredProcedure

                conexion.Open()
                Dim datadapter As New SqlDataAdapter(comando)
                Dim oDs As New DataSet

                datadapter.Fill(oDs)
                If oDs.Tables(0).Rows.Count > 0 Then
                    dt = oDs.Tables(0)
                    BunifuDataGridView1.AutoGenerateColumns = True
                    BunifuDataGridView1.DataSource = dt
                    BunifuDataGridView1.Refresh()
                End If
            End Using ' Cierra el SqlCommand automáticamente
        End Using ' Cierra la conexión automáticamente
    End Sub

    ' Evento CellClick para actualizar el gráfico cuando se selecciona una fila en el DataGridView
    Private Sub BunifuDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellClick
        If e.RowIndex >= 0 Then
            ' Obtener el valor de la primera columna de la fila seleccionada
            Dim clienteId As String = BunifuDataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim clientenombre As String = BunifuDataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            ' Llamar a un método para actualizar el gráfico con el cliente seleccionado
            ActualizarGraficoPorCliente(clienteId)
            ChartClienteMasGastan.Titles.Clear() ' Elimina títulos existentes si los hay
            Dim title As New Title("Lo que mas Compra " & clientenombre)
            ChartClienteMasGastan.Titles.Add(title)
        End If

    End Sub

    ' Método para actualizar el gráfico con el cliente seleccionado
    Private Sub ActualizarGraficoPorCliente(clienteId As String)
        ' Limpiar listas antes de usarlas
        Productos.Clear()
        Cantprod.Clear()

        ' Usar 'Using' para manejar la conexión y el comando
        Using conexion As New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
            comando = New SqlCommand("EstProductoxClientes", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@ID", clienteId) ' Pasar el parámetro

            conexion.Open()
            Using dr As SqlDataReader = comando.ExecuteReader()
                While dr.Read()
                    Try
                        ' Asegúrate de que el tipo de datos en la base de datos coincide con el tipo de datos esperado
                        Productos.Add(dr.GetString(0)) ' Obtener el nombre del producto o cliente
                        Cantprod.Add(dr.GetInt32(1)) ' Obtener la cantidad
                    Catch ex As InvalidCastException
                        MessageBox.Show("Error de conversión: " & ex.Message)
                    End Try
                End While
            End Using ' Cierra el DataReader automáticamente
        End Using ' Cierra la conexión automáticamente
        ChartClienteMasGastan.Series(0).Points.DataBindXY(Productos, Cantprod)



    End Sub

    Private Sub ChartClienteMasGastan_Click(sender As Object, e As EventArgs) Handles ChartClienteMasGastan.Click
        ClintesqueMasGastan()
        ChartClienteMasGastan.Titles.Clear() ' Elimina títulos existentes si los hay
        Dim title As New Title("Clientes que Mas Gastan")
        ChartClienteMasGastan.Titles.Add(title)
    End Sub
End Class

