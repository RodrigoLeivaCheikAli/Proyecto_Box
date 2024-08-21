Imports System.Data.SqlClient
Imports System.Configuration

Public Class Compras

    Dim conexion As SqlConnection
    Dim comando As New SqlCommand
    Private addedRows As New Dictionary(Of Integer, Integer)
    Dim valor As Integer

    Dim Cant As New Dictionary(Of Integer, Integer)
    Private originalValues As New Dictionary(Of Integer, Integer)

    Private formLoaded As Boolean = False
    Public Property IdPresupuesto As Integer

    Dim maxId As Integer
    Dim totalPrecio As Decimal = 0

#Region "FUNCIONES PARA LOS PRECIOS ACTUALIZABLES Y PARA EL TOTAL"
    Private Sub UpdateTotal(rowIndex As Integer)
        ' Índices de columnas en DataGridView1 y DataGridView2
        Dim priceCostIndex As Integer = DataGridView1.Columns(5).Index  ' Índice de la columna de precio costo en DataGridView1
        Dim quantityIndex As Integer = DataGridView2.Columns(DataGridView2.ColumnCount - 1).Index  ' Índice de la columna de cantidad en DataGridView2

        ' Verificar que el índice de fila es válido
        If rowIndex >= 0 AndAlso rowIndex < DataGridView2.Rows.Count Then
            ' Obtener el índice de la fila original en DataGridView1
            Dim selectedRowIndex As Integer = addedRows.FirstOrDefault(Function(x) x.Value = rowIndex).Key

            ' Verificar si el índice encontrado es válido
            If selectedRowIndex <> -1 Then
                Dim priceCostValue As Object = DataGridView1.Rows(selectedRowIndex).Cells(priceCostIndex).Value

                ' Variables para almacenar los valores convertidos
                Dim priceCost As Decimal
                Dim quantity As Integer

                ' Intentar convertir el precio costo y la cantidad
                If Decimal.TryParse(priceCostValue.ToString(), priceCost) AndAlso Integer.TryParse(DataGridView2.Rows(rowIndex).Cells(quantityIndex).Value.ToString(), quantity) Then
                    ' Calcular el total
                    Dim total As Decimal = priceCost * quantity

                    ' Actualizar el total en la grilla
                    DataGridView2.Rows(rowIndex).Cells(priceCostIndex).Value = total.ToString("C")
                Else
                    ' Manejar el caso en que los valores no sean válidos
                    MessageBox.Show("Error al convertir los valores de precio o cantidad.")
                End If
            Else
                MessageBox.Show("No se encontró la fila correspondiente en DataGridView1.")
            End If
        End If


    End Sub


    Public Sub CalcularTotal()
        totalPrecio = 0
        Dim priceCostColumnIndex As Integer = 5

        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                Dim priceCost As Decimal
                Dim cellValue = row.Cells(priceCostColumnIndex).Value.ToString()

                ' Eliminar cualquier símbolo de moneda y otros caracteres no numéricos
                Dim cleanValue As String = System.Text.RegularExpressions.Regex.Replace(cellValue, "[^\d.,-]", "")

                ' Intentar convertir el valor limpiado a Decimal
                If Decimal.TryParse(cleanValue, priceCost) Then
                    totalPrecio += priceCost
                Else
                    MessageBox.Show("No se pudo convertir el valor en la fila " & row.Index)
                End If
            End If
        Next

        ' Mostrar el total en el Label
        lbl_Total.Text = "TOTAL: " & totalPrecio.ToString("C")
    End Sub


#End Region

#Region "GRILLAS"

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView1.Columns("Column1").Index AndAlso e.RowIndex >= 0 Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                Dim lastColumnIndex As Integer = DataGridView1.ColumnCount - 1
                Dim currentValue As Integer = Convert.ToInt32(selectedRow.Cells(lastColumnIndex).Value)

                ' Guardar el valor original si no está en el diccionario
                If Not originalValues.ContainsKey(e.RowIndex) Then
                    originalValues.Add(e.RowIndex, currentValue)
                End If

                Dim newRow As DataGridViewRow = CType(selectedRow.Clone(), DataGridViewRow)
                For i As Integer = 1 To selectedRow.Cells.Count - 1 ' Ignorar la primera columna
                    newRow.Cells(i).Value = selectedRow.Cells(i).Value
                Next

                If addedRows.ContainsKey(selectedRow.Index) Then
                    Cant(selectedRow.Index) += 1
                    Dim targetIndex As Integer = addedRows(selectedRow.Index)

                    ' Verificar si targetIndex es el correcto
                    Debug.WriteLine("targetIndex: " & targetIndex)

                    DataGridView2.Rows(targetIndex).Cells(DataGridView2.ColumnCount - 1).Value = Cant(selectedRow.Index)

                    ' Llamada a UpdateTotal
                    UpdateTotal(targetIndex)

                Else
                    ' Si la fila no fue agregada, agregarla al DataGridView2 y al diccionario
                    Cant.Add(selectedRow.Index, 1)
                    Dim newIndex As Integer = DataGridView2.Rows.Add(newRow)
                    addedRows.Add(selectedRow.Index, newIndex)

                    ' Establecer la cantidad inicial
                    DataGridView2.Rows(newIndex).Cells(DataGridView2.ColumnCount - 1).Value = Cant(selectedRow.Index)

                    ' Llamada a UpdateTotal
                    UpdateTotal(newIndex)
                End If
            End If
        End If



        CalcularTotal()
    End Sub


    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView2.Columns("Column2").Index AndAlso e.RowIndex >= 0 Then
                ' Eliminar la fila seleccionada
                Dim originalIndex As Integer = -1
                For Each pair In addedRows
                    If pair.Value = selectedRow.Index Then
                        originalIndex = pair.Key
                        Exit For
                    End If
                Next

                If Cant.ContainsKey(originalIndex) Then
                    Cant(originalIndex) -= 1
                    If Cant(originalIndex) > 0 Then
                        DataGridView2.Rows(e.RowIndex).Cells(DataGridView2.ColumnCount - 1).Value = Cant(originalIndex)

                        ' Actualizar el total de la fila en la grilla 2
                        UpdateTotal(e.RowIndex)
                    Else
                        ' Eliminar de addedRows y Cant antes de eliminar la fila
                        addedRows.Remove(originalIndex)
                        Cant.Remove(originalIndex)
                        DataGridView2.Rows.RemoveAt(e.RowIndex)

                        ' Actualizar los índices en addedRows
                        Dim updatedAddedRows As New Dictionary(Of Integer, Integer)
                        For Each pair In addedRows
                            If pair.Value > e.RowIndex Then
                                updatedAddedRows.Add(pair.Key, pair.Value - 1)
                            Else
                                updatedAddedRows.Add(pair.Key, pair.Value)
                            End If
                        Next
                        addedRows = updatedAddedRows
                    End If
                End If
            End If
        End If
        CalcularTotal()
    End Sub

#End Region


#Region "LLENAR GRILLAS"

    Dim dt As DataTable

    Private Sub Llenar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Consultar_Productos_Compras")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet

        datadapter.Fill(oDs)
        If oDs.Tables(0).Rows.Count > 0 Then
            dt = oDs.Tables(0)
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

#End Region

#Region "FORMULARIO"

    Private Sub Compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Llenar_Grilla()
        Dim columnaPrecio As DataGridViewColumn = DataGridView1.Columns(5)
        columnaPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaPrecio.DefaultCellStyle.Format = "C2"

        Dim columnaPrecio2 As DataGridViewColumn = DataGridView2.Columns(5)
        columnaPrecio2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaPrecio2.DefaultCellStyle.Format = "C2"


        SeleccionarUltimoID()
    End Sub

#End Region

#Region "BUSQUEDA"

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Buscar(txtBusqueda.Text)

    End Sub

    Private connectionString As String = "data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123"

    Private Sub Buscar(busqueda As String)
        Dim query As String
        Dim isNumericSearch As Boolean = IsNumeric(busqueda)

        If isNumericSearch Then
            query = "SELECT o.Id_Oferta AS PRODUCTO, o.Descripcion AS NOMBRE, v.Tipo AS VEHICULO, p.Nombre AS PROVEEDOR, o.Precio_Costo AS PRECIO_COSTO
                 FROM Ofertas o
                 JOIN Vehiculos v ON o.Id_Vehiculo = v.Id_Vehiculo
                 JOIN Proveedores p ON o.Id_Proveedor = p.Id_Proveedor
                 WHERE o.Id_Oferta = @Busqueda OR o.Precio_Costo = @Busqueda"
        Else
            query = "SELECT o.Id_Oferta AS PRODUCTO, o.Descripcion AS NOMBRE, v.Tipo AS VEHICULO, p.Nombre AS PROVEEDOR, o.Precio_Costo AS PRECIO_COSTO
                 FROM Ofertas o
                 JOIN Vehiculos v ON o.Id_Vehiculo = v.Id_Vehiculo
                 JOIN Proveedores p ON o.Id_Proveedor = p.Id_Proveedor
                 WHERE o.Descripcion LIKE @Busqueda OR v.Tipo LIKE @Busqueda OR p.Nombre LIKE @Busqueda"
        End If

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                If isNumericSearch Then
                    command.Parameters.AddWithValue("@Busqueda", Convert.ToInt32(busqueda))
                Else
                    command.Parameters.AddWithValue("@Busqueda", "%" & busqueda & "%")
                End If

                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    DataGridView1.DataSource = dataTable

                    ' Renombra las columnas del DataGridView si es necesario
                    For Each column As DataGridViewColumn In DataGridView1.Columns
                        If column.Name = "Id_Oferta" Then
                            column.HeaderText = "PRODUCTO"
                        ElseIf column.Name = "Descripcion" Then
                            column.HeaderText = "NOMBRE"
                        ElseIf column.Name = "Tipo" Then
                            column.HeaderText = "VEHICULO"
                        ElseIf column.Name = "Nombre" Then
                            column.HeaderText = "PROVEEDOR"
                        ElseIf column.Name = "Precio_Costo" Then
                            column.HeaderText = "PRECIO_COSTO"
                        End If
                    Next

                    ' Establece el estilo y formato para la columna de precio
                    Dim columnaPrecio As DataGridViewColumn = DataGridView1.Columns("PRECIO_COSTO")
                    columnaPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    columnaPrecio.DefaultCellStyle.Format = "C2"

                Catch ex As Exception
                    MessageBox.Show("Error al buscar los proveedores: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


#End Region

#Region "PRESUPUESTOS"
    Public Sub CargarDetalles()
        If IdPresupuesto <> 0 Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Consultar_Detalle_Presupuestos_Compras_2"
            comando.Parameters.AddWithValue("@Id_Presupuesto", IdPresupuesto)

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet

            Try
                conexion.Open()
                datadapter.Fill(oDs)
                If oDs.Tables(0).Rows.Count > 0 Then
                    ' Guardar las primeras columnas
                    Dim firstColumns As New List(Of DataGridViewColumn)
                    For i As Integer = 0 To 0 ' Conservar solo la primera columna
                        firstColumns.Add(DataGridView2.Columns(i))
                    Next

                    ' Limpiar columnas excepto las primeras
                    DataGridView2.Columns.Clear()
                    For Each col As DataGridViewColumn In firstColumns
                        DataGridView2.Columns.Add(col)
                    Next

                    ' Asignar el DataSource
                    Dim dtDetalles As DataTable = oDs.Tables(0)
                    DataGridView2.AutoGenerateColumns = True
                    DataGridView2.DataSource = dtDetalles
                    DataGridView2.Refresh()
                    DataGridView2.Show()

                    CalcularTotal()
                    Dim columnaPrecio2 As DataGridViewColumn = DataGridView2.Columns(5)
                    columnaPrecio2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    columnaPrecio2.DefaultCellStyle.Format = "C2"

                Else
                    DataGridView2.DataSource = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar los detalles: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Presupuestos_Compras.Show()
    End Sub

#End Region

#Region "GUARDAR PEDIDO"

    Private Sub SeleccionarUltimoID()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand


        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

        Try
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Maximo_Id_Orden_Compra"

            ' Ejecutar el comando y obtener el valor
            maxId = Convert.ToInt32(comando.ExecuteScalar())

        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID máximo: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        CargarPedido()
        SeleccionarUltimoID()
        CargarDetallePedido()
        MsgBox("Pedido guardado correctamente", vbInformation, "Pedidos")
        totalPrecio = 0
        If IdPresupuesto = 0 Then
            DataGridView2.Rows.Clear()
        End If

        If IdPresupuesto <> 0 Then
            ActualizarEstadoPresupuesto(IdPresupuesto, "Pedido")
        End If
    End Sub

    Private Sub ActualizarEstadoPresupuesto(idPresupuesto As Integer, nuevoEstado As String)
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "Actualizar_Estado_Presupuesto"
        comando.Parameters.AddWithValue("@Id_Presupuesto", idPresupuesto)

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el estado del presupuesto: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub CargarDetallePedido()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

        Try
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Cargar_Detalles_Compras"

            For Each fila As DataGridViewRow In DataGridView2.Rows
                If Not fila.IsNewRow Then
                    ' Toma los valores de la columna 1 y la columna 6
                    Dim idOferta As Integer = Convert.ToInt32(fila.Cells(1).Value)
                    Dim cantidad As Integer = Convert.ToInt32(fila.Cells(6).Value)

                    With comando.Parameters
                        .Clear() ' Limpia los parámetros antes de agregar nuevos valores
                        .AddWithValue("@ID_Orden_Compra", maxId)
                        .AddWithValue("@ID_Oferta", idOferta)
                        .AddWithValue("@Cantidad", cantidad)
                    End With
                    comando.ExecuteNonQuery()
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error al cargar los detalles: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub CargarPedido()
        Dim fechaPedido As DateTime

        Using frmFecha As New FechaForm
            If frmFecha.ShowDialog() = DialogResult.OK Then
                fechaPedido = frmFecha.FechaSeleccionada
            Else
                MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End Using


        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

        Try
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Cargar_Pedido_Compras"

            With comando.Parameters
                .AddWithValue("@fecha", fechaPedido)
                .AddWithValue("@total", totalPrecio)
            End With

            comando.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show("Error al cargar los detalles: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

#End Region
End Class