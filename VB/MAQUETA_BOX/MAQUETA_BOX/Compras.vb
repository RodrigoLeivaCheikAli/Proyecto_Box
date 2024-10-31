Imports System.Data.SqlClient
Imports System.Configuration
Imports Bunifu.UI.WinForms

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
        BunifuLabel1.Text = "TOTAL: " & totalPrecio.ToString("C")
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
            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123") ' Cambia por tu cadena de conexión
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Consultar_Detalle_Presupuestos_Compras_2"
            comando.Parameters.AddWithValue("@Id_Presupuesto", IdPresupuesto)

            Dim oAdapter As New SqlDataAdapter(comando)
            Dim oDS As New DataSet()

            Try
                conexion.Open()
                oAdapter.Fill(oDS)

                If oDS.Tables(0).Rows.Count > 0 Then
                    ' Desactivar la generación automática de columnas
                    DataGridView2.AutoGenerateColumns = False

                    ' Limpiar las filas actuales
                    DataGridView2.Rows.Clear()

                    ' Recorrer cada fila del DataTable y agregarla manualmente al DataGridView
                    For Each row As DataRow In oDS.Tables(0).Rows
                        DataGridView2.Rows.Add(
                    Nothing, ' Para la columna de "Quitar", si es de tipo imagen o botón
                    row("N° PRODUCTO"),
                    row("NOMBRE"),
                    row("VEHICULO"),
                    row("PROVEEDOR"),
                    row("PRECIO COSTO"),
                    row("CANTIDAD")
                )
                    Next

                    ' Refrescar el DataGridView para que se muestren los cambios
                    DataGridView2.Refresh()
                    CalcularTotal()
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
        Dim frmPresupuestos As New Presupuestos_Compras(Me) ' Pasa la referencia de Compras
        frmPresupuestos.Show()
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

            maxId = Convert.ToInt32(comando.ExecuteScalar())

        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID máximo: " & ex.Message)
        Finally
            conexion.Close()
        End Try
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
                    Dim idOferta As Integer = Convert.ToInt32(fila.Cells(1).Value)
                    Dim cantidad As Integer = Convert.ToInt32(fila.Cells(6).Value)

                    With comando.Parameters
                        .Clear()
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

    Public Sub CargarPedido(fechaPedido As DateTime)
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


    Public Sub AgregarProductoAPresupuesto(IdPresupuesto As Integer, IdProducto As Integer, Cantidad As Integer)
        Try
            Using conexion As New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
                Using comando As New SqlCommand("Agregar_Producto_A_Presupuesto", conexion)
                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.AddWithValue("@Id_Presupuesto", IdPresupuesto)
                    comando.Parameters.AddWithValue("@Id_Producto", IdProducto)
                    comando.Parameters.AddWithValue("@Cantidad", Cantidad)

                    conexion.Open()
                    comando.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Producto agregado al presupuesto correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto al presupuesto: " & ex.Message)
        End Try
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        IdPresupuesto = 0
        DataGridView2.Rows.Clear()


        addedRows.Clear()
        Cant.Clear()
        originalValues.Clear()
        CalcularTotal()

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)
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

                    ' Verificar si targetIndex es válido
                    If targetIndex >= 0 AndAlso targetIndex < DataGridView2.Rows.Count Then
                        DataGridView2.Rows(targetIndex).Cells(DataGridView2.ColumnCount - 1).Value = Cant(selectedRow.Index)

                        ' Llamada a UpdateTotal
                        UpdateTotal(targetIndex)
                    Else
                        MessageBox.Show("El índice de la fila es inválido, no se puede actualizar la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
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

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView1.Columns("Column9").Index AndAlso e.RowIndex >= 0 Then
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

                    ' Verificar si targetIndex es válido
                    If targetIndex >= 0 AndAlso targetIndex < DataGridView2.Rows.Count Then
                        DataGridView2.Rows(targetIndex).Cells(DataGridView2.ColumnCount - 1).Value = Cant(selectedRow.Index)

                        ' Llamada a UpdateTotal
                        UpdateTotal(targetIndex)
                    Else
                        MessageBox.Show("El índice de la fila es inválido, no se puede actualizar la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
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

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView2.Columns("Column1").Index AndAlso e.RowIndex >= 0 Then
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

                        UpdateTotal(e.RowIndex)
                    Else
                        addedRows.Remove(originalIndex)
                        Cant.Remove(originalIndex)
                        DataGridView2.Rows.RemoveAt(e.RowIndex)

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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim fechaForm As New FechaForm()

        If fechaForm.ShowDialog() = DialogResult.OK Then
            Dim fechaSeleccionada As DateTime = fechaForm.FechaSeleccionada

            CargarPedido(fechaSeleccionada)
            SeleccionarUltimoID()
            CargarDetallePedido()
            ExportarTablaAPedidoCSV()

            MsgBox("Pedido guardado correctamente", vbInformation, "Pedidos")

            totalPrecio = 0
            If IdPresupuesto = 0 Then
                DataGridView2.Rows.Clear()
                addedRows.Clear()
                Cant.Clear()
                originalValues.Clear()
                CalcularTotal()
                IdPresupuesto = 0
            Else
                ActualizarEstadoPresupuesto(IdPresupuesto, "Pedido")
                DataGridView2.Rows.Clear()
                addedRows.Clear()
                Cant.Clear()
                originalValues.Clear()
                CalcularTotal()
                IdPresupuesto = 0
            End If
        End If
    End Sub


#End Region


#Region "Exportar"
    Private Sub ExportarTablaAPedidoCSV()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv"
        saveFileDialog.Title = "Guardar pedido como"
        saveFileDialog.FileName = "Pedido.csv"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta seleccionada por el usuario
            Dim rutaArchivo As String = saveFileDialog.FileName

            Try
                ' Crear el archivo CSV
                Using sw As New System.IO.StreamWriter(rutaArchivo)
                    ' Escribir encabezados de las columnas
                    For Each columna As DataGridViewColumn In DataGridView2.Columns
                        sw.Write(columna.HeaderText & ",")
                    Next
                    sw.WriteLine()

                    ' Escribir las filas
                    For Each fila As DataGridViewRow In DataGridView2.Rows
                        If Not fila.IsNewRow Then
                            For Each celda As DataGridViewCell In fila.Cells
                                sw.Write(celda.Value.ToString() & ",")
                            Next
                            sw.WriteLine()
                        End If
                    Next
                End Using

                ' Mostrar mensaje de éxito
                MessageBox.Show("Pedido exportado exitosamente a " & rutaArchivo, "Exportar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al exportar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
#End Region
End Class