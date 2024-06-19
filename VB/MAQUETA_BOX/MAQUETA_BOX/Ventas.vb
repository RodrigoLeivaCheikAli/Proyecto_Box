Imports System.Data.SqlClient
Imports System.Configuration

Public Class Ventas
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand
    Private addedRows As New Dictionary(Of Integer, Integer)
    Dim Cant As New Dictionary(Of Integer, Integer)
    Dim valor As Integer

    Private Sub Ventas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenarGrilla()
    End Sub

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
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView1.Columns("ImageColumn").Index AndAlso e.RowIndex >= 0 Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
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

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = DataGridView2.Columns("DataGridViewImageColumn1").Index AndAlso e.RowIndex >= 0 Then
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
    End Sub



    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click


        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")




        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_DetalleVentas")

        With comando.Parameters
            .AddWithValue("@ID_Presupuesto", valor)
            .AddWithValue("@ID_Oferta", valor)
            '.AddWithValue("@Cantidad", contadores(e.RowIndex))

        End With
        comando.ExecuteScalar()
        LlenarGrilla()
        conexion.Close()
        MsgBox("La joya se ha insertado correctamente ", vbInformation, "Joyeria Monaco")


    End Sub
End Class