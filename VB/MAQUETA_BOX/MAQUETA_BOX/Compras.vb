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
        Cargar_Combo()
        Dim columnaPrecio As DataGridViewColumn = BunifuDataGridView1.Columns(5)
        columnaPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaPrecio.DefaultCellStyle.Format = "C2"

        Dim columnaPrecio2 As DataGridViewColumn = BunifuDataGridView2.Columns(6)
        columnaPrecio2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaPrecio2.DefaultCellStyle.Format = "C2"
    End Sub

    Private Sub Cargar_Combo()
        cboColumna.Items.Clear()
        For Each column As DataColumn In dt.Columns
            cboColumna.Items.Add(column.ColumnName)
        Next
        If cboColumna.Items.Count > 0 Then
            cboColumna.SelectedIndex = 0
        End If

    End Sub

#End Region

#Region "Barra Busqueda"

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If dt IsNot Nothing AndAlso cboColumna.SelectedIndex >= 0 Then
            Dim selectedColumn As String = cboColumna.SelectedItem.ToString()
            Dim columnType As Type = dt.Columns(selectedColumn).DataType

            Dim filter As String
            If columnType Is GetType(String) Then
                filter = String.Format("[{0}] LIKE '%{1}%'", selectedColumn, txtBusqueda.Text)
            Else
                filter = String.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", selectedColumn, txtBusqueda.Text)
            End If

            Dim dv As DataView = dt.DefaultView
            dv.RowFilter = filter
            BunifuDataGridView1.DataSource = dv
        End If
    End Sub


#End Region


    '#Region "GRILLAS"

    '    Private Sub BunifuDataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellContentClick
    '        Dim senderGrid = DirectCast(sender, DataGridView)

    '        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
    '            If e.ColumnIndex = BunifuDataGridView1.Columns("Column1").Index AndAlso e.RowIndex >= 0 Then
    '                ' Obtener la fila seleccionada
    '                Dim selectedRow As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
    '                Dim newRow As DataGridViewRow = CType(selectedRow.Clone(), DataGridViewRow)
    '                For i As Integer = 2 To selectedRow.Cells.Count - 2
    '                    newRow.Cells(i).Value = selectedRow.Cells(i).Value
    '                Next

    '                ' Agregar la nueva fila al DataGridView2
    '                If addedRows.ContainsKey(selectedRow.Index) Then
    '                    ' Si la fila ya fue agregada, incrementar la cantidad
    '                    Cant(selectedRow.Index) += 1
    '                    Dim targetIndex As Integer = addedRows(selectedRow.Index)
    '                    BunifuDataGridView2.Rows(targetIndex).Cells(BunifuDataGridView2.ColumnCount - 2).Value = Cant(selectedRow.Index)
    '                Else
    '                    ' Si la fila no fue agregada, agregarla al DataGridView2 y al diccionario
    '                    Cant.Add(selectedRow.Index, 1)
    '                    Dim newIndex As Integer = BunifuDataGridView2.Rows.Add(newRow)
    '                    addedRows.Add(selectedRow.Index, newIndex)
    '                    BunifuDataGridView2.Rows(newIndex).Cells(BunifuDataGridView2.ColumnCount - 2).Value = Cant(selectedRow.Index)
    '                End If
    '            End If
    '        End If
    '    End Sub

    '    Private Sub BunifuDataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView2.CellContentClick
    '        Dim senderGrid = DirectCast(sender, DataGridView)
    '        Dim selectedRow As DataGridViewRow = BunifuDataGridView2.Rows(e.RowIndex)

    '        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
    '            If e.ColumnIndex = BunifuDataGridView2.Columns("DataGridViewImageColumn1").Index AndAlso e.RowIndex >= 0 Then
    '                ' Eliminar la fila seleccionada
    '                Dim originalIndex As Integer = -1
    '                For Each pair In addedRows
    '                    If pair.Value = selectedRow.Index Then
    '                        originalIndex = pair.Key
    '                        Exit For
    '                    End If
    '                Next

    '                If originalIndex <> -1 AndAlso Cant.ContainsKey(originalIndex) Then
    '                    Cant(originalIndex) -= 1
    '                    If Cant(originalIndex) > 0 Then
    '                        BunifuDataGridView2.Rows(e.RowIndex).Cells(BunifuDataGridView2.ColumnCount - 2).Value = Cant(originalIndex)
    '                    Else
    '                        ' Eliminar de addedRows y Cant antes de eliminar la fila
    '                        addedRows.Remove(originalIndex)
    '                        Cant.Remove(originalIndex)
    '                        BunifuDataGridView2.Rows.RemoveAt(e.RowIndex)

    '                        ' Actualizar los índices en addedRows
    '                        Dim updatedAddedRows As New Dictionary(Of Integer, Integer)
    '                        For Each pair In addedRows
    '                            If pair.Value > e.RowIndex Then
    '                                updatedAddedRows.Add(pair.Key, pair.Value - 1)
    '                            Else
    '                                updatedAddedRows.Add(pair.Key, pair.Value)
    '                            End If
    '                        Next
    '                        addedRows = updatedAddedRows
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End Sub


    '#End Region

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