Imports System.Data.SqlClient
Imports System.Configuration

Public Class Compras

    Dim conexion As SqlConnection
    Dim comando As New SqlCommand
    Private addedRows As New Dictionary(Of Integer, Integer)
    Dim Cant As New Dictionary(Of Integer, Integer)
    Dim valor As Integer

#Region "Llenar Grilla"

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
            BunifuDataGridView1.AutoGenerateColumns = True
            BunifuDataGridView1.DataSource = dt
            BunifuDataGridView1.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

#End Region

#Region "Load Formulario"

    Private Sub Compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Llenar_Grilla()
        Dim columnaPrecio As DataGridViewColumn = BunifuDataGridView1.Columns(5)
        columnaPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaPrecio.DefaultCellStyle.Format = "C2"

        Dim columnaPrecio2 As DataGridViewColumn = BunifuDataGridView2.Columns(6)
        columnaPrecio2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaPrecio2.DefaultCellStyle.Format = "C2"
    End Sub

#End Region

#Region "Barra Busqueda"

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
                    BunifuDataGridView1.DataSource = dataTable

                    ' Renombra las columnas del DataGridView si es necesario
                    For Each column As DataGridViewColumn In BunifuDataGridView1.Columns
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
                    Dim columnaPrecio As DataGridViewColumn = BunifuDataGridView1.Columns("PRECIO_COSTO")
                    columnaPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    columnaPrecio.DefaultCellStyle.Format = "C2"

                Catch ex As Exception
                    MessageBox.Show("Error al buscar los proveedores: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


#End Region

#Region "GRILLAS ACT"
    Private Sub BunifuDataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = BunifuDataGridView1.Columns("Column1").Index AndAlso e.RowIndex >= 0 Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
                Dim newRow As DataGridViewRow = CType(selectedRow.Clone(), DataGridViewRow)

                ' Copiar valores de las celdas, incluyendo la columna 4
                For i As Integer = 0 To selectedRow.Cells.Count - 1
                    newRow.Cells(i).Value = selectedRow.Cells(i).Value
                Next

                ' Obtener el precio de la columna 4
                Dim price As Double = selectedRow.Cells(5).Value

                ' Agregar la nueva fila al DataGridView2
                If addedRows.ContainsKey(selectedRow.Index) Then
                    ' Si la fila ya fue agregada, incrementar la cantidad
                    Cant(selectedRow.Index) += 1
                    Dim targetIndex As Integer = addedRows(selectedRow.Index)
                    BunifuDataGridView2.Rows(targetIndex).Cells(BunifuDataGridView2.ColumnCount - 2).Value = Cant(selectedRow.Index)
                    ' Multiplicar el precio y actualizar la columna correspondiente en la segunda grilla
                    BunifuDataGridView2.Rows(targetIndex).Cells(BunifuDataGridView2.ColumnCount - 1).Value = price * Cant(selectedRow.Index)
                Else
                    ' Si la fila no fue agregada, agregarla al DataGridView2 y al diccionario
                    Cant.Add(selectedRow.Index, 1)
                    Dim newIndex As Integer = BunifuDataGridView2.Rows.Add(newRow)
                    addedRows.Add(selectedRow.Index, newIndex)
                    BunifuDataGridView2.Rows(newIndex).Cells(BunifuDataGridView2.ColumnCount - 2).Value = Cant(selectedRow.Index)
                    ' Multiplicar el precio y actualizar la columna correspondiente en la segunda grilla
                    BunifuDataGridView2.Rows(newIndex).Cells(BunifuDataGridView2.ColumnCount - 1).Value = price * Cant(selectedRow.Index)
                End If
            End If
        End If
    End Sub

    Private Sub BunifuDataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim selectedRow As DataGridViewRow = BunifuDataGridView2.Rows(e.RowIndex)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = BunifuDataGridView2.Columns("DataGridViewImageColumn1").Index AndAlso e.RowIndex >= 0 Then
                ' Eliminar la fila seleccionada
                Dim originalIndex As Integer = -1
                For Each pair In addedRows
                    If pair.Value = selectedRow.Index Then
                        originalIndex = pair.Key
                        Exit For
                    End If
                Next

                If originalIndex <> -1 AndAlso Cant.ContainsKey(originalIndex) Then
                    Cant(originalIndex) -= 1
                    If Cant(originalIndex) > 0 Then
                        BunifuDataGridView2.Rows(e.RowIndex).Cells(BunifuDataGridView2.ColumnCount - 2).Value = Cant(originalIndex)
                        ' Obtener el precio original
                        Dim price As Decimal = Convert.ToDecimal(BunifuDataGridView1.Rows(originalIndex).Cells(4).Value)
                        ' Actualizar el precio multiplicado
                        BunifuDataGridView2.Rows(e.RowIndex).Cells(BunifuDataGridView2.ColumnCount - 1).Value = price * Cant(originalIndex)
                    Else
                        ' Eliminar de addedRows y Cant antes de eliminar la fila
                        addedRows.Remove(originalIndex)
                        Cant.Remove(originalIndex)
                        BunifuDataGridView2.Rows.RemoveAt(e.RowIndex)

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
    End Sub

#End Region

End Class