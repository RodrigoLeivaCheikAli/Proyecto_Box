Imports System.Data.SqlClient
Imports System.Configuration

Public Class Ventas

    Private Sub Ventas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Redimensionar()
        LlenarGrilla()
        'AddHandler DataGridView1.CellPainting, AddressOf DataGridView1_CellPainting
        'AddHandler DataGridView2.CellPainting, AddressOf DataGridView2_CellPainting
    End Sub

#Region "Variables"
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand
    Private addedRows As New Dictionary(Of Integer, Integer)
    Dim Cant As New Dictionary(Of Integer, Integer)
    Private originalValues As New Dictionary(Of Integer, Integer)
    Dim valor As Integer
    Private formLoaded As Boolean = False
#End Region

#Region "Codigos para redimensionar"
    Public Sub Redimensionar()
        DataGridView1.Width = Me.ClientSize.Width * 0.5
        'DataGridView1.Height = Me.ClientSize.Height * 0.65
        DataGridView2.Width = Me.ClientSize.Width * 0.5
        'DataGridView2.Height = Me.ClientSize.Height * 0.65
        'PictureBox1.Width = Me.ClientSize.Width * 0.1
        ''PictureBox1.Height = Me.ClientSize.Height * 0.09
        'PictureBox3.Width = Me.ClientSize.Width * 0.1
        'PictureBox3.Height = Me.ClientSize.Height * 0.09
    End Sub

#Region "CellPainting"
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
        e.CellStyle.WrapMode = DataGridViewTriState.True
        e.CellStyle.Font = New Font("Arial", CalculateFontSize(e.CellBounds.Size, e.FormattedValue.ToString()))
    End Sub

    Private Sub DataGridView2_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
        e.CellStyle.WrapMode = DataGridViewTriState.True
        e.CellStyle.Font = New Font("Arial", CalculateFontSize(e.CellBounds.Size, e.FormattedValue.ToString()))
    End Sub

    Private Function CalculateFontSize(size As Size, text As String) As Single
        Dim maxFontSize As Single = 8.0F
        Dim minFontSize As Single = 6.0F
        Dim currentSize As Single = maxFontSize
        Using g As Graphics = Graphics.FromImage(New Bitmap(1, 1))
            Do While currentSize > minFontSize
                Dim testFont As New Font("Arial", currentSize)
                Dim textSize As SizeF = g.MeasureString(text, testFont)
                If textSize.Width <= size.Width AndAlso textSize.Height <= size.Height Then
                    Exit Do
                End If
                currentSize -= 0.5F
            Loop
        End Using
        Return currentSize
    End Function
#End Region
#End Region

#Region "Funcion Cargar Grilla"
    Private Sub LlenarGrilla()
        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Consultar_Productos_Ventas")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = oDs.Tables(0)
            DataGridView1.Refresh()
        End If
        oDs = Nothing
        conexion.Close()
        'AdjustColumnWidths()
        Dim columnaPrecio As DataGridViewColumn = DataGridView1.Columns("ColumnPrecio")
        columnaPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaPrecio.DefaultCellStyle.Format = "C2"
    End Sub
#End Region

#Region "Botones"
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel1.Controls.Clear()
        Dim newForm As New Presupuesto() ' Crea una nueva instancia del formulario que deseas agregar
        Dim lastColumnValues As New Dictionary(Of Integer, Integer)

        ' Recorrer las filas de DataGridView1 y copiar los valores de la segunda y última columna
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim secondColumnIndex As Integer = 1 ' Suponiendo que la segunda columna tiene el índice 1
                Dim lastColumnIndex As Integer = DataGridView1.ColumnCount - 1
                Dim key As Integer = Convert.ToInt32(row.Cells(secondColumnIndex).Value)
                Dim value As Integer = Convert.ToInt32(row.Cells(lastColumnIndex).Value)
                lastColumnValues.Add(key, value)
            End If
        Next
        newForm.LoadData(lastColumnValues)
        newForm.CopiarDatos(DataGridView2)
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show() ' Muestra el formulario
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel1.Controls.Clear()
        Dim newForm As New Ventas() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show() ' Muestra el formulario
    End Sub
#End Region


#Region "Barra Busqueda"

    Private Sub txtBuqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBuqueda.TextChanged
        busqueda(txtBuqueda.Text)
    End Sub

    Private connectionString As String = "data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123"

    Private Sub busqueda(busqueda As String)
        Dim query As String
        Dim isNumericSearch As Boolean = IsNumeric(busqueda)

        If isNumericSearch Then
            query = "select Id_Oferta as [N°] , T.Tipo as Tipo, Descripcion as Descripcion, V.Tipo as Vehiculo,O.Precio_Costo + (O.Precio_Costo*O.Ganancia) as Precio, Cantidad
                 from Ofertas O
                 join Tipos_de_Ofertas T
                 on O.Id_Tipo_Oferta = T.Id_Tipos_Ofertas
                 join Vehiculos V
                 on O.Id_Vehiculo = V.Id_Vehiculo
                WHERE O.Id_Oferta = @Busqueda OR ROUND(O.Precio_Costo + (O.Precio_Costo * O.Ganancia), 2) = @Busqueda"
        Else
            query = "SELECT Id_Oferta AS [N°], T.Tipo AS Tipo, Descripcion AS Descripcion, V.Tipo AS Vehiculo, 
                        ROUND(O.Precio_Costo + (O.Precio_Costo * O.Ganancia), 2) AS Precio, Cantidad
                 FROM Ofertas O
                 JOIN Tipos_de_Ofertas T ON O.Id_Tipo_Oferta = T.Id_Tipos_Ofertas
                 JOIN Vehiculos V ON O.Id_Vehiculo = V.Id_Vehiculo
                 JOIN Proveedores p ON O.Id_Proveedor = p.Id_Proveedor
                 WHERE O.Descripcion LIKE @Busqueda OR 
                       V.Tipo LIKE @Busqueda OR 
                       T.Tipo like @Busqueda OR 
                       p.Nombre LIKE @Busqueda"
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

                    '' Renombra las columnas del DataGridView si es necesario
                    'For Each column As DataGridViewColumn In DataGridView1.Columns
                    '    If column.Name = "Id_Oferta" Then
                    '        column.HeaderText = "PRODUCTO"
                    '    ElseIf column.Name = "Descripcion" Then
                    '        column.HeaderText = "NOMBRE"
                    '    ElseIf column.Name = "Tipo" Then
                    '        column.HeaderText = "VEHICULO"
                    '    ElseIf column.Name = "Nombre" Then
                    '        column.HeaderText = "PROVEEDOR"
                    '    ElseIf column.Name = "Precio_Costo" Then
                    '        column.HeaderText = "PRECIO_COSTO"
                    '    End If
                    'Next

                    ' Establece el estilo y formato para la columna de precio
                    Dim columnaPrecio As DataGridViewColumn = DataGridView1.Columns("ColumnPrecio")
                    columnaPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    columnaPrecio.DefaultCellStyle.Format = "C2"

                Catch ex As Exception
                    MessageBox.Show("Error al buscar los proveedores: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

#End Region

#Region "Eventos click de la grilla"

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView1.Columns("ColumnSumar").Index AndAlso e.RowIndex >= 0 Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                Dim lastColumnIndex As Integer = DataGridView1.ColumnCount - 1
                Dim currentValue As Integer = Convert.ToInt32(selectedRow.Cells(lastColumnIndex).Value)

                ' Guardar el valor original si no está en el diccionario
                If Not originalValues.ContainsKey(e.RowIndex) Then
                    originalValues.Add(e.RowIndex, currentValue)
                End If

                ' Verificar si el valor es mayor que 0 antes de restar
                If currentValue > 0 Then
                    If Not selectedRow.Cells(2).Value.ToString().Equals("Servicio", StringComparison.OrdinalIgnoreCase) Then
                        selectedRow.Cells(lastColumnIndex).Value = currentValue - 1
                    Else

                    End If

                Else
                    If Not formLoaded Then
                        MsgBox("No Existe Mas Stock Disponible de Este Producto, Para Continuar Esta Venta Debera Realizarse un Pedido ", vbInformation, "TTK")

                        formLoaded = True
                    End If
                End If

                Dim newRow As DataGridViewRow = CType(selectedRow.Clone(), DataGridViewRow)
                For i As Integer = 1 To selectedRow.Cells.Count - 1 ' Ignorar la primera columna
                    newRow.Cells(i).Value = selectedRow.Cells(i).Value
                Next

                ' Agregar la nueva fila al DataGridView2
                If addedRows.ContainsKey(selectedRow.Index) Then
                    ' Si la fila ya fue agregada, incrementar la cantidad
                    Cant(selectedRow.Index) += 1
                    Dim targetIndex As Integer = addedRows(selectedRow.Index)
                    DataGridView2.Rows(targetIndex).Cells(DataGridView2.ColumnCount - 1).Value = Cant(selectedRow.Index)
                Else
                    ' Si la fila no fue agregada, agregarla al DataGridView2 y al diccionario
                    Cant.Add(selectedRow.Index, 1)
                    Dim newIndex As Integer = DataGridView2.Rows.Add(newRow)
                    addedRows.Add(selectedRow.Index, newIndex)
                    DataGridView2.Rows(newIndex).Cells(DataGridView2.ColumnCount - 1).Value = Cant(selectedRow.Index)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView2.Columns("ColumnRestar").Index AndAlso e.RowIndex >= 0 Then
                ' Eliminar la fila seleccionada
                Dim originalIndex As Integer = -1
                For Each pair In addedRows
                    If pair.Value = selectedRow.Index Then
                        originalIndex = pair.Key
                        Exit For
                    End If
                Next

                If originalIndex <> -1 Then
                    ' Sumar 1 al valor de la última columna en DataGridView1 sin exceder el original
                    Dim lastColumnIndex As Integer = DataGridView1.ColumnCount - 1
                    Dim currentValue As Integer = Convert.ToInt32(DataGridView1.Rows(originalIndex).Cells(lastColumnIndex).Value)
                    Dim originalValue As Integer = originalValues(originalIndex)
                    If currentValue < originalValue Then
                        DataGridView1.Rows(originalIndex).Cells(lastColumnIndex).Value = currentValue + 1
                    End If

                    If Cant.ContainsKey(originalIndex) Then
                        Cant(originalIndex) -= 1
                        If Cant(originalIndex) > 0 Then
                            DataGridView2.Rows(e.RowIndex).Cells(DataGridView2.ColumnCount - 1).Value = Cant(originalIndex)
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
        End If
    End Sub
#End Region

    'Private Sub AdjustColumnWidths()
    '    ' Ajustar el tamaño de las columnas de acuerdo a su contenido
    '    'For Each column As DataGridViewColumn In DataGridView1.Columns
    '    '    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    'Next

    '    '' Agregar un margen adicional al ancho de cada columna
    '    'Dim extraWidth As Integer = 40 ' Ajustar este valor según sea necesario
    '    'For Each column As DataGridViewColumn In DataGridView1.Columns
    '    '    column.Width += extraWidth
    '    'Next
    '    'For Each column As DataGridViewColumn In DataGridView1.Columns
    '    '    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    'Next

    '    ' Ajustar el tamaño de una columna específica por nombre
    '    If DataGridView1.Columns.Contains("Descripcion") Then
    '        DataGridView1.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    '    End If

    '    ' Ajustar el tamaño de una columna específica por índice
    '    If DataGridView1.Columns.Count > 0 Then
    '        DataGridView1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '    End If
    'End Sub
End Class