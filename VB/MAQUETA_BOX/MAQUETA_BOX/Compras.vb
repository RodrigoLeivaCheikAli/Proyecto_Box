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
    End Sub

#End Region


#Region "Barra Busqueda"

    Private Sub txtBusqueda_Compras_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusqueda_Compras.TextChanged



    End Sub






#End Region


#Region "Prueba"
    Private Sub BunifuDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = BunifuDataGridView1.Columns("Column1").Index AndAlso e.RowIndex >= 0 Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
                Dim newRow As DataGridViewRow = CType(selectedRow.Clone(), DataGridViewRow)
                For i As Integer = 2 To selectedRow.Cells.Count - 2 ' Ignorar la primera columna
                    newRow.Cells(i).Value = selectedRow.Cells(i).Value
                Next

                ' Agregar la nueva fila al DataGridView2
                If addedRows.ContainsKey(selectedRow.Index) Then
                    ' Si la fila ya fue agregada, incrementar la cantidad
                    Cant(selectedRow.Index) += 1
                    Dim targetIndex As Integer = addedRows(selectedRow.Index)
                    BunifuDataGridView2.Rows(targetIndex).Cells(BunifuDataGridView2.ColumnCount - 2).Value = Cant(selectedRow.Index)
                Else
                    ' Si la fila no fue agregada, agregarla al DataGridView2 y al diccionario
                    Cant.Add(selectedRow.Index, 1)
                    Dim newIndex As Integer = BunifuDataGridView2.Rows.Add(newRow)
                    addedRows.Add(selectedRow.Index, newIndex)
                    BunifuDataGridView2.Rows(newIndex).Cells(BunifuDataGridView2.ColumnCount - 2).Value = Cant(selectedRow.Index)
                End If
            End If
        End If
    End Sub

    Private Sub BunifuDataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView2.CellContentClick
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
                        BunifuDataGridView2.Rows(e.RowIndex).Cells(BunifuDataGridView2.ColumnCount - 1).Value = Cant(originalIndex)
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