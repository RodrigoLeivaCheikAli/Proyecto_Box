
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Ventas
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand
    Private contadores As New Dictionary(Of Integer, Integer)
    Dim Cant As Integer = 0
    Dim valor As Integer
    Private Sub Ventas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LlenarGrilla()
        Cant = Cant + 1
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
            'TODO - Aquí va el código que quieres que se ejecute cuando se presiona el botón
            If e.ColumnIndex = DataGridView1.Columns("ImageColumn").Index AndAlso e.RowIndex >= 0 Then
                ' Obtener la fila seleccionada
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                ' Crear una nueva fila en el DataGridView2 con los mismos valores
                Dim newRow As DataGridViewRow = CType(selectedRow.Clone(), DataGridViewRow)
                For i As Integer = 1 To selectedRow.Cells.Count - 2 ' Ignorar la primera y la última columna
                    newRow.Cells(i).Value = selectedRow.Cells(i).Value
                Next

                ' Agregar la nueva fila al DataGridView2
                DataGridView2.Rows.Add(newRow)
            End If
        End If
    End Sub

 Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewImageColumn AndAlso e.RowIndex >= 0 Then
            'TODO - Aquí va el código que quieres que se ejecute cuando se presiona el botón
            If e.ColumnIndex = DataGridView2.Columns("DataGridViewImageColumn1").Index AndAlso e.RowIndex >= 0 Then
                ' Eliminar la fila seleccionada
                DataGridView2.Rows.RemoveAt(e.RowIndex)
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