Imports System.Data.SqlClient

Public Class Presupuesto

    Dim Presupuesto As Integer = 0

    Private Sub Presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Presupuesto = Presupuesto + 1
        Cargar_Combo_MediosP()
        For Each row As DataGridViewRow In DataGridView3.Rows
            If Not row.IsNewRow Then
                CalcularPrecio(row.Index)
            End If
        Next
        ActualizarTotal()
        ' Actualizar la vista del DataGridView para mostrar los cambios
        DataGridView3.Refresh()
    End Sub
    Public Sub CopiarDatos(dgvOrigen As DataGridView)
        ' Limpiar cualquier dato existente en el DataGridView destino
        DataGridView3.Rows.Clear()




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
    Private Sub DataGridView3_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        Dim columnName As String = DataGridView3.Columns(e.ColumnIndex).Name

        If columnName = "quantity" Or columnName = "rate" Then
            CalcularPrecio(e.RowIndex)
            ' Actualizar la vista del DataGridView para mostrar los cambios
            DataGridView3.Refresh()
        End If
    End Sub

    Private Sub CalcularPrecio(rowIndex As Integer)
        Dim quantity As Double
        Dim rate As Double

        ' Intentar convertir los valores de las celdas a Double
        If Double.TryParse(Convert.ToString(DataGridView3.Rows(rowIndex).Cells("quantity").Value), quantity) AndAlso
       Double.TryParse(Convert.ToString(DataGridView3.Rows(rowIndex).Cells("rate").Value), rate) Then
            Dim price As Double = quantity * rate
            DataGridView3.Rows(rowIndex).Cells("price").Value = price.ToString()
        Else
            ' Manejar el caso donde la conversión falló
            ' Por ejemplo, podrías mostrar un mensaje de error o reiniciar el valor de la celda 'price'
            DataGridView3.Rows(rowIndex).Cells("price").Value = String.Empty
        End If
    End Sub

    Private Function SumarColumnaPrice() As Double
        Dim total As Double = 0

        For Each row As DataGridViewRow In DataGridView3.Rows
            If Not row.IsNewRow Then
                Dim price As Double
                If Double.TryParse(Convert.ToString(row.Cells("price").Value), price) Then
                    total += price
                End If
            End If
        Next

        Return total
    End Function
    Private Sub ActualizarTotal()
        Dim total As Double = SumarColumnaPrice()
        lblSubtotal.Text = "$ " & total.ToString()
        lblTotal.Text = total
        Dim valor As String
        If cboMediosP.SelectedIndex().ToString IsNot Nothing Then


            If cboMediosP.SelectedIndex = 0 Then
                lblTotal.Text = total - (total / 10%)
            ElseIf cboMediosP.SelectedIndex = 1 Then

                lblTotal.Text = total - ((total * 5) / 100)
            Else
                lblTotal.Text = total
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
        ActualizarTotal()
        lblDescuento.Text = valor
    End Sub






    Private Sub cboMediosP_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboMediosP.SelectedIndexChanged
        Descuento()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel1.Controls.Clear()
        Dim newForm As New Ventas() ' Crea una nueva instancia del formulario que deseas agregar
        newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
        Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
        newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
        newForm.Show() ' Muestra el formulario
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_DetallesV")

            With comando.Parameters
                .AddWithValue("@ID_Presupuesto", Presupuesto)
                .AddWithValue("@ID_Oferta", colOferta)
                .AddWithValue("@Cantidad", quantity)

            End With
            comando.ExecuteScalar()

            comando.CommandText = ("Cargar_Presupuesto")
            With comando.Parameters
                .AddWithValue("@ID_Presupuesto", Presupuesto)
                .AddWithValue("@ID_Oferta", colOferta)
                .AddWithValue("@Cantidad", quantity)

            End With
            conexion.Close()
            MsgBox("La joya se ha insertado correctamente ", vbInformation, "Joyeria Monaco")


    End Sub
End Class