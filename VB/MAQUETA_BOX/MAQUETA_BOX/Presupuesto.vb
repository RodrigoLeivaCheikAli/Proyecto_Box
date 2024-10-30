Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class Presupuesto
    Dim cant As New Dictionary(Of Integer, Integer)
    Dim PresupuestoVendido As Boolean
    Public Property IDPresu As Integer

    Private Sub Presupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idPresupuesto()
        PresupuestoVendido = False
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
    Public Sub LoadData(ByVal data As Dictionary(Of Integer, Integer))
        For Each item In data
            cant.Add(item.Key, item.Value)
        Next
    End Sub

    ' Método para actualizar la base de datos
    Public Sub ActualizarCant()
        ' Conexión a la base de datos
        Dim conn As New SqlConnection("data source=168.197.51.109;initial catalog=PIN_GRUPO11;user id=PIN_GRUPO11;password=PIN_GRUPO11123")
        Dim comando As New SqlCommand

        Try
            conn.Open()

            ' Recorrer el diccionario cant y actualizar la base de datos
            For Each kvp As KeyValuePair(Of Integer, Integer) In cant
                Dim id As Integer = kvp.Key ' La clave del diccionario es el ID del producto (segunda columna)
                Dim value As Integer = kvp.Value ' El valor del diccionario es la cantidad (última columna)

                comando.Connection = conn
                comando.CommandType = CommandType.StoredProcedure
                comando.CommandText = "Modificar_CantidadProductos"
                comando.Parameters.Clear() ' Limpiar parámetros anteriores
                comando.Parameters.AddWithValue("@idproducto", id)
                comando.Parameters.AddWithValue("@Cantidad", value)

                comando.ExecuteNonQuery()
            Next

            MessageBox.Show("Base de datos actualizada correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la base de datos: " & ex.Message)
        Finally
            ' Asegurarse de cerrar la conexión
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
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
        If Double.TryParse(Convert.ToString(DataGridView3.Rows(rowIndex).Cells("ColumnCantidad").Value), quantity) AndAlso
       Double.TryParse(Convert.ToString(DataGridView3.Rows(rowIndex).Cells("ColumnPrecio").Value), rate) Then
            Dim price As Double = quantity * rate

            ' Aplicar formato de moneda al total y asignar el valor
            DataGridView3.Rows(rowIndex).Cells("ColumnTotal").Value = price.ToString("C2")

        Else
            ' Manejar el caso donde la conversión falló
            ' Por ejemplo, podrías mostrar un mensaje de error o reiniciar el valor de la celda 'price'
            DataGridView3.Rows(rowIndex).Cells("ColumnTotal").Value = String.Empty
        End If
    End Sub


    Private Function SumarColumnaPrice() As Double
        Dim total As Double = 0

        For Each row As DataGridViewRow In DataGridView3.Rows
            If Not row.IsNewRow Then
                Dim price As String = Convert.ToString(row.Cells("ColumnTotal").Value)

                ' Eliminar el signo de moneda y convertir a Double
                Dim precio As Double
                If Double.TryParse(price.Replace("€", "").Replace("$", "").Trim(), precio) Then
                    total += precio
                End If
            End If
        Next

        Return total
    End Function

    Private Sub ActualizarTotal()
        Dim total As Double = SumarColumnaPrice()
        lblSubtotal.Text = total.ToString("C2") ' Mostrar subtotal como moneda
        lblTotal.Text = total.ToString("C2")    ' Mostrar total como moneda

        Dim valor As String
        If cboMediosP.SelectedIndex().ToString() IsNot Nothing Then

            If cboMediosP.SelectedIndex = 0 Then
                lblTotal.Text = (total - (total * 0.1)).ToString("C2") ' Descuento del 10%
            ElseIf cboMediosP.SelectedIndex = 1 Then
                lblTotal.Text = (total - (total * 0.05)).ToString("C2") ' Descuento del 5%
            Else
                lblTotal.Text = total.ToString("C2") ' Sin descuento
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


        For Each fila As DataGridViewRow In DataGridView3.Rows
            ' Verifica si la fila no está vacía
            If Not fila.IsNewRow Then
                Dim idOferta As Integer = Convert.ToInt32(fila.Cells("ColumnID").Value)
                Dim cantidad As Integer = Convert.ToInt32(fila.Cells("ColumnCantidad").Value)

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

    End Sub



    Private Sub CargarPresupuesto()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand
        Dim total As Double = lblTotal.Text
        Dim subtotal As Double = lblSubtotal.Text
        Dim estado As Integer
        If BunifuCheckBox1.Checked Then
            ' El CheckBox está marcado
            estado = 3
        Else
            If BunifuCheckBox2.Checked Then
                ' El CheckBox está marcado
                estado = 1006
            Else
                ' El CheckBox no está marcado
                estado = 4
            End If
        End If


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
            .AddWithValue("@Estado", estado)
        End With
        comando.ExecuteScalar()
        conexion.Close()
        If BunifuCheckBox1.Checked Then
            ' El CheckBox está marcado
            MsgBox("Se realizo el Pedido correctamente ", vbInformation, "TTK")
        Else
            If BunifuCheckBox2.Checked Then
                ' El CheckBox está marcado
                MsgBox("Se realizo el Presupuesto correctamente ", vbInformation, "TTK")
            Else
                ' El CheckBox no está marcado
                MsgBox("Se realizo la Venta correctamente ", vbInformation, "TTK")
            End If
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If BunifuCheckBox2.Checked Then
            CargarDetallesV()
            CargarPresupuesto()
            Panel1.Controls.Clear()
            Dim newForm As New Ventas() ' Crea una nueva instancia del formulario que deseas agregar
            newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
            Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
            newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
            newForm.Show() ' Muestra el formulario
        Else
            If PresupuestoVendido = True Then

                EliminarPresupuesto(Modulo.IdPres)
            End If
            ActualizarCant()
            CargarDetallesV()
            CargarPresupuesto()
            Panel1.Controls.Clear()
            Dim newForm As New Ventas() ' Crea una nueva instancia del formulario que deseas agregar
            newForm.TopLevel = False ' Establece la propiedad TopLevel en False para poder agregarlo a un control
            Panel1.Controls.Add(newForm) ' Agrega el formulario al panel
            newForm.WindowState = FormWindowState.Maximized ' Muestra el formulario
            newForm.Show() ' Muestra el formulario
        End If

    End Sub



    Private Sub DataGridView3_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellEndEdit
        Dim columnName As String = DataGridView3.Columns(e.ColumnIndex).Name

        If columnName = "ColumnCantidad" Or columnName = "ColumnPrecio" Then
            CalcularPrecio(e.RowIndex)
            ' Actualizar la vista del DataGridView para mostrar los cambios
            DataGridView3.Refresh()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim Presupuesto_Ventas As New Presupuesto_Ventas(Me)
        Presupuesto_Ventas.Show()

    End Sub

    Public Sub CargarDetalles()
        If IDPresu <> 0 Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand
            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Consultar_Presupuestos_Ventas2"
            comando.Parameters.AddWithValue("@Id_Presupuesto", IDPresu)

            Dim oAdapter As New SqlDataAdapter(comando)
            Dim oDS As New DataSet()

            Try
                conexion.Open()
                oAdapter.Fill(oDS)
              
                If oDS.Tables(0).Rows.Count > 0 Then
                    DataGridView3.AutoGenerateColumns = False
                    DataGridView3.Rows.Clear()

                    ' Agregar filas a DataGridView3
                    For Each row As DataRow In oDS.Tables(0).Rows
                        DataGridView3.Rows.Add(row("N°"), row("Tipo"), row("Descripcion"), row("Vehiculo"), row("Precio"), row("Cantidad"), row("Total"))
                    Next

                    DataGridView3.Refresh()
                    ActualizarTotal()

                    ' Obtener el valor de la primera columna y primera fila de DataGridView3


                    ' Llamar a la función para cargar ComboBoxes
                    CargarCombos(Modulo.IdPres)
                Else

                    DataGridView3.DataSource = Nothing
                End If
                PresupuestoVendido = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar los detalles: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        End If
    End Sub

    ' Función para cargar cboClientes y cboMediodePago
    Private Sub CargarCombos(idPresupuesto As Integer)
        Dim conexion As New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
        Dim comando As New SqlCommand("Obtener_Cliente_y_MedioPago", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@Id_Presupuesto", idPresupuesto)

        Dim oAdapter As New SqlDataAdapter(comando)
        Dim oDS As New DataSet()

        Try
            conexion.Open()
            oAdapter.Fill(oDS)

            If oDS.Tables(0).Rows.Count > 0 Then
                ' Asignar valores a los ComboBoxes
                cboCliente.Text = oDS.Tables(0).Rows(0)("Cliente").ToString()
                cboMediosP.Text = oDS.Tables(0).Rows(0)("Medio de Pago").ToString()


            End If

        Catch ex As Exception
            MessageBox.Show("Error al cargar los ComboBoxes: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub EliminarPresupuesto(idPresupuesto As Integer)
        ' Configura la conexión a la base de datos
        Dim conexion As New SqlConnection("data source=168.197.51.109; initial catalog=PIN_GRUPO11; user id=PIN_GRUPO11; password=PIN_GRUPO11123")

        Try
            ' Abre la conexión
            conexion.Open()

            ' Configura el comando para el procedimiento almacenado
            Dim comando As New SqlCommand("Eliminar_Presupuesto", conexion)
            comando.CommandType = CommandType.StoredProcedure

            ' Agrega el parámetro de entrada
            comando.Parameters.AddWithValue("@Id_Presupuesto", idPresupuesto)

            ' Configura el parámetro de salida
            Dim resultado As New SqlParameter("@Resultado", SqlDbType.Int)
            resultado.Direction = ParameterDirection.Output
            comando.Parameters.Add(resultado)

            ' Ejecuta el procedimiento
            comando.ExecuteNonQuery()

            ' Verifica el valor del parámetro de salida
            Dim filasAfectadas As Integer = CInt(resultado.Value)

            If filasAfectadas > 0 Then
                MessageBox.Show("Presupuesto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf filasAfectadas = 0 Then
                MessageBox.Show("No se encontró el presupuesto especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Ocurrió un error al eliminar el presupuesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' Maneja cualquier error que ocurra durante la ejecución
            MessageBox.Show("Error al eliminar el presupuesto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Cierra la conexión
            conexion.Close()
        End Try
    End Sub


    Private Sub BunifuCheckBox2_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles BunifuCheckBox2.CheckedChanged
        If BunifuCheckBox2.Checked Then
            ' El CheckBox está marcado
            BunifuCheckBox1.Checked = False

        End If
    End Sub

    Private Sub BunifuCheckBox1_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles BunifuCheckBox1.CheckedChanged
        If BunifuCheckBox1.Checked Then
            ' El CheckBox está marcado
            BunifuCheckBox2.Checked = False

        End If
    End Sub

End Class