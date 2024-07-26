Imports System.Data.SqlClient

Public Class Presupuesto





    Private Sub Presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idPresupuesto()
        Modulo.Presupuesto = Modulo.Presupuesto + 1
        Cargar_Combo_MediosP()
        CargarCBOClientes()
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
            If Not row.IsNewRow Then
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(DataGridView3)

                ' Copiar las celdas, omitiendo la primera celda
                For i As Integer = 1 To row.Cells.Count - 1
                    newRow.Cells(i - 1).Value = row.Cells(i).Value
                Next

                ' Agregar la nueva fila al DataGridView destino


                DataGridView3.Rows.Add(newRow)
            End If
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

    Private Sub idPresupuesto()
        Using conn As New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conn.Open()
            Dim consultaSQL As String = "  SELECT  MAX ([Id_Presupuesto] ) FROM Presupuestos "
            Dim cmd As New SqlCommand(consultaSQL, conn)
            cmd.Parameters.AddWithValue("@ID", 1) ' Supongamos que quieres obtener el nombre para el ID 1
            Dim resultado As Object = cmd.ExecuteScalar()
            If resultado IsNot Nothing Then
                Modulo.Presupuesto = resultado.ToString()
                ' Ahora puedes usar la variable 'nombre'
            Else
                ' El resultado fue nulo (no se encontró ningún registro)
            End If
        End Using

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
        lblSubtotal.Text = total.ToString()
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

    Private Sub CargarCBOClientes()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_cboClientes_Presupuesto")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboCliente.DataSource = oDs.Tables(0)
            cboCliente.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboCliente.ValueMember = oDs.Tables(0).Columns(0).ToString

        End If
        oDs = Nothing
        conexion.Close()
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
    Private Sub CargarDetallesV()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "Cargar_DetallesV"

        ' Suponiendo que tienes un DataGridView llamado DataGridView3
        For Each fila As DataGridViewRow In DataGridView3.Rows
            ' Verifica si la fila no está vacía
            If Not fila.IsNewRow Then
                Dim idOferta As Integer = Convert.ToInt32(fila.Cells("colOferta").Value)
                Dim cantidad As Integer = Convert.ToInt32(fila.Cells("quantity").Value)

                With comando.Parameters
                    .Clear() ' Limpia los parámetros antes de agregar nuevos valores
                    .AddWithValue("@ID_Presupuesto", Modulo.Presupuesto)
                    .AddWithValue("@ID_Oferta", idOferta)
                    .AddWithValue("@Cantidad", cantidad)
                End With

                comando.ExecuteNonQuery() ' Ejecuta el comando para cada fila
            End If
        Next

        conexion.Close()
        MsgBox("Se realizó la operación correctamente", vbInformation, "Joyería Mónaco")
    End Sub



    Private Sub CargarPresupuesto()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand
        Dim total As Double = lblTotal.Text
        Dim subtotal As Double = lblSubtotal.Text
        Dim nota As String = "a"
        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Presupuesto")
        With comando.Parameters
            .AddWithValue("@ID_Cliente", cboCliente.SelectedValue)
            .AddWithValue("@Fecha", BunifuDatePicker1.Value)
            .AddWithValue("@Subtotal", subtotal)
            .AddWithValue("@ID_MediosP", cboMediosP.SelectedValue)
            .AddWithValue("@Total", total)
            .AddWithValue("@notas", nota)
        End With
        comando.ExecuteScalar()
        conexion.Close()
        MsgBox("Se realizo la Venta correctamente ", vbInformation, "Joyeria Monaco")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        CargarDetallesV()
        CargarPresupuesto()

    End Sub
End Class