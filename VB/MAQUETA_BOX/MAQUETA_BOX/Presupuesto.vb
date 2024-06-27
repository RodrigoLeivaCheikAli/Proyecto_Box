Imports System.Data.SqlClient

Public Class Presupuesto



    Private Sub Presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_MediosP()


    End Sub
    Public Sub CopiarDatos(dgvOrigen As DataGridView)
        ' Limpiar cualquier dato existente en el DataGridView destino
        DataGridView3.Rows.Clear()


        ' Copiar las columnas, omitiendo la primera columna
        For i As Integer = 1 To dgvOrigen.Columns.Count - 1
            DataGridView3.Columns.Add(CType(dgvOrigen.Columns(i).Clone(), DataGridViewColumn))
        Next

        ' Copiar las filas
        For Each row As DataGridViewRow In dgvOrigen.Rows
            ' Crear una nueva fila en lugar de clonar la fila completa
            Dim newRow As DataGridViewRow = New DataGridViewRow()
            newRow.CreateCells(DataGridView3)

            ' Copiar las celdas, omitiendo la primera celda
            For i As Integer = 1 To row.Cells.Count - 1
                newRow.Cells(i - 1).Value = row.Cells(i).Value
            Next

            ' Agregar la nueva fila al DataGridView destino


            DataGridView3.Rows.Add(newRow)
        Next


    End Sub
    Private Sub DataGridView3_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellEndEdit
        Dim columnName As String = DataGridView3.Columns(e.ColumnIndex).Name

        If columnName = "quantity" Or columnName = "rate" Then
            Dim quantity As Integer
            Dim rate As Integer

            ' Intentar convertir los valores de las celdas a Integer
            If Integer.TryParse(Convert.ToString(DataGridView3.Rows(e.RowIndex).Cells("quantity").Value), quantity) AndAlso
           Integer.TryParse(Convert.ToString(DataGridView3.Rows(e.RowIndex).Cells("rate").Value), rate) Then
                Dim price As Integer = quantity * rate
                DataGridView3.Rows(e.RowIndex).Cells("price").Value = price.ToString()

                ' Actualizar la vista del DataGridView para mostrar los cambios
                DataGridView3.Refresh()
            Else
                ' Manejar el caso donde la conversión falló
                ' Por ejemplo, podrías mostrar un mensaje de error o reiniciar el valor de la celda 'price'
                DataGridView3.Rows(e.RowIndex).Cells("price").Value = String.Empty
            End If
        End If
    End Sub





    Private Sub Cargar_Combo_MediosP()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Consultar_listPrecio")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboMediosP.DataSource = oDs.Tables(0)
            cboMediosP.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboMediosP.ValueMember = oDs.Tables(0).Columns(0).ToString

        End If
        oDs = Nothing
        conexion.Close()

    End Sub


    Private Sub Descuento()
        Dim valor As String
        If cboMediosP.SelectedIndex().ToString IsNot Nothing Then


            If cboMediosP.SelectedIndex = 0 Then
                valor = "10%"
            ElseIf cboMediosP.SelectedIndex = 1 Then
                valor = "5%"
            Else
                valor = "0%"
            End If
        Else
            valor = "0%"
        End If

        lblDescuento.Text = valor
    End Sub




    Private Sub cboMediosP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMediosP.SelectedIndexChanged
        Descuento()
    End Sub
End Class