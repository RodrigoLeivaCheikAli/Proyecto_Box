﻿Imports System.Data.SqlClient
Imports System.Drawing.Printing


Public Class Productos
    Private currentRowIndex As Integer = 0
    Private panelImpreso As Boolean = False

#Region "Load"
    Private Sub Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Cargar_Grilla()
        cargar_cbo_tipo()
        cargar_cbo_proveedores()
        cargar_cbo_vehiculos()
        cargar_cbo_marcas()

        'Prueba 
        Dim columnaCosto As DataGridViewColumn = BunifuDataGridView1.Columns("ColumnCosto")
        Dim columnaPrecio As DataGridViewColumn = BunifuDataGridView1.Columns("ColumnPrecio")
        Dim columnaGanancia As DataGridViewColumn = BunifuDataGridView1.Columns("ColumnGanancia")

        ' Configuración para la columna de Costo
        columnaCosto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaCosto.DefaultCellStyle.Format = "C2"

        ' Configuración para la columna de Precio
        columnaPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaPrecio.DefaultCellStyle.Format = "C2"

        ' Configuración para la columna de Ganancia
        columnaGanancia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        columnaGanancia.DefaultCellStyle.Format = "P2"


    End Sub
#End Region
#Region "Limpiar"
    Private Sub Limpiar()
        txtDescripcion.Text = Nothing
        txtCantidad.Text = Nothing
        txtCosto.Text = Nothing
        txtGanancia.Text = Nothing
    End Sub
#End Region
#Region "Cargar Grilla"
    Dim dt As DataTable

    Private Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Consultar_Productos_Gestion")

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
#Region "Redirección"
#Region " Recibir Panel"
    Private panelContenedor As Panel
    ' Constructor para recibir el panel contenedor
    Public Sub New(panel As Panel)
        InitializeComponent()
        Me.panelContenedor = panel
    End Sub
#End Region
#Region "Listado"
    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        ' Crear una instancia del formulario Productos_Listado
        Dim listadoForm As New Productos_Listado(panelContenedor)

        ' Configurar el formulario Productos_Listado para que no sea de nivel superior
        listadoForm.TopLevel = False

        ' Limpiar el panelContenedor antes de agregar el nuevo formulario
        panelContenedor.Controls.Clear()

        ' Agregar el formulario Productos_Listado al panelContenedor
        panelContenedor.Controls.Add(listadoForm)

        ' Ajustar el tamaño del formulario al panel
        listadoForm.Dock = DockStyle.Fill

        ' Mostrar el formulario dentro del panel
        listadoForm.Show()
    End Sub
#End Region
#Region "Vendidos"
    Private Sub btnVendidos_Click(sender As Object, e As EventArgs)
        ' Crear una instancia del formulario Productos_Listado
        Dim vendidosForm As New Productos_Vendidos(panelContenedor)

        ' Configurar el formulario Productos_Listado para que no sea de nivel superior
        vendidosForm.TopLevel = False

        ' Limpiar el panelContenedor antes de agregar el nuevo formulario
        panelContenedor.Controls.Clear()

        ' Agregar el formulario Productos_Listado al panelContenedor
        panelContenedor.Controls.Add(vendidosForm)

        ' Ajustar el tamaño del formulario al panel
        vendidosForm.Dock = DockStyle.Fill

        ' Mostrar el formulario dentro del panel
        vendidosForm.Show()
    End Sub
#End Region
#Region "Menú"
    Private mainForm As Inicio

    ' Constructor para recibir la referencia del formulario principal
    Public Sub New(mainForm As Inicio)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub

    'Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
    ' Restaurar el estado inicial del panel
    'mainForm.RestaurarPanel()

    ' Cerrar el formulario actual
    'Me.Close()
    'End Sub
#End Region
#End Region
#Region "Cargar Combo Tipo"
    Private Sub cargar_cbo_tipo()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_cbo_Tipo_Producto")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboTipo.DataSource = oDs.Tables(0)
            cboTipo.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboTipo.ValueMember = oDs.Tables(0).Columns(0).ToString
        End If
        oDs = Nothing
        conexion.Close()
    End Sub
#End Region
#Region "Cargar Combo Proveedores"
    Private Sub cargar_cbo_proveedores()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_cbo_Proveedores")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboProveedor.DataSource = oDs.Tables(0)
            cboProveedor.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboProveedor.ValueMember = oDs.Tables(0).Columns(0).ToString
        End If
        oDs = Nothing
        conexion.Close()
    End Sub
#End Region
#Region "Cargar Combo Vehiculos"
    Private Sub cargar_cbo_vehiculos()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_cbo_Vehiculos")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboVehiculo.DataSource = oDs.Tables(0)
            cboVehiculo.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboVehiculo.ValueMember = oDs.Tables(0).Columns(0).ToString
        End If
        oDs = Nothing
        conexion.Close()
    End Sub
#End Region
#Region "Cargar Combo Marcas"
    Private Sub cargar_cbo_marcas()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")



        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_cbo_Marcas")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            cboMarca.DataSource = oDs.Tables(0)
            cboMarca.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cboMarca.ValueMember = oDs.Tables(0).Columns(0).ToString
        End If
        oDs = Nothing
        conexion.Close()
    End Sub



#End Region
#Region "Cargar Productos"
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If txtDescripcion.Text <> Nothing And txtCosto.Text <> Nothing And txtGanancia.Text <> Nothing Then

            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Productos")

            With comando.Parameters
                .AddWithValue("@idtipo", cboTipo.SelectedValue)
                .AddWithValue("@descripcion", txtDescripcion.Text)
                .AddWithValue("@idproveedor", cboProveedor.SelectedValue)
                .AddWithValue("@idvehiculo", cboVehiculo.SelectedValue)
                .AddWithValue("@costo", txtCosto.Text)
                .AddWithValue("@ganancia", txtGanancia.Text)
                .AddWithValue("@cantidad", txtCantidad.Text)
                .AddWithValue("@idmarca", cboMarca.SelectedValue)

            End With

            comando.ExecuteScalar()
            conexion.Close()
            MsgBox("Se ha cargado correctamente", vbInformation, Me.Text)
            Limpiar()
            Cargar_Grilla()
        Else
            MsgBox("Complete los datos", vbInformation, Me.Text)
        End If
    End Sub
#End Region

#Region "Eliminar Productos"
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtCodigo.Text <> Nothing Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Eliminar_Productos")
            With comando.Parameters
                .AddWithValue("@idproducto", txtCodigo.Text)
            End With

            comando.ExecuteNonQuery()
            MsgBox("Se ha eliminado correctamente", vbInformation, Me.Text)
            Limpiar()
            Cargar_Grilla()
            conexion.Close()
        Else
            MsgBox("Complete datos para eliminar", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
#End Region
#Region "Modificar Producto"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtCodigo.Text <> Nothing And txtCantidad.Text <> Nothing And txtCosto.Text <> Nothing And txtDescripcion.Text <> Nothing And txtGanancia.Text Then
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("data source = 168.197.51.109; initial catalog = PIN_GRUPO11 ; user id = PIN_GRUPO11; password = PIN_GRUPO11123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Modificar_Productos")

            With comando.Parameters
                .AddWithValue("@idproducto", txtCodigo.Text)
                .AddWithValue("@idtipo", cboTipo.SelectedValue)
                .AddWithValue("@descripcion", txtDescripcion.Text)
                .AddWithValue("@idproveedor", cboProveedor.SelectedValue)
                .AddWithValue("@idvehiculo", cboVehiculo.SelectedValue)
                .AddWithValue("@costo", txtCosto.Text)
                .AddWithValue("@ganancia", txtGanancia.Text)
                .AddWithValue("@cantidad", txtCantidad.Text)
                .AddWithValue("@idmarca", cboMarca.SelectedValue)
            End With

            comando.ExecuteNonQuery()
            MsgBox("Se ha modificado con exito", vbInformation, Me.Text)
            Limpiar()
            Cargar_Grilla()
            conexion.Close()
        Else
            MsgBox("Complete los datos para modificar", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
#End Region
#Region "Cargar textbox productos"
    Private Sub BunifuDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuDataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = BunifuDataGridView1.Rows(e.RowIndex)
            txtCodigo.Text = row.Cells("ColumnID").Value.ToString()
            cboTipo.Text = row.Cells("ColumnTipo").Value.ToString
            txtDescripcion.Text = row.Cells("ColumnDescripcion").Value.ToString()
            cboMarca.Text = row.Cells("ColumnMarca").Value.ToString()
            cboVehiculo.Text = row.Cells("ColumnVehiculo").Value.ToString()
            cboProveedor.Text = row.Cells("ColumnProveedor").Value.ToString()
            txtCantidad.Text = row.Cells("ColumnStock").Value.ToString()
            txtCosto.Text = row.Cells("ColumnCosto").Value.ToString()
            txtGanancia.Text = row.Cells("ColumnGanancia").Value.ToString()
        End If
    End Sub
#End Region
#Region "Metodo Filtrar Busqueda"
    Private Sub FiltrarGrilla()
        Dim textoBusqueda As String = txtBuscarProductos.Text.Trim()

        ' Verificar que dt no sea Nothing
        If dt IsNot Nothing Then
            ' Crear un DataView para filtrar los datos
            Dim dataView As New DataView(dt)

            ' Construir el filtro basado en las selecciones
            Dim filtro As String = String.Empty
            If Not String.IsNullOrEmpty(textoBusqueda) Then
                If filtro <> String.Empty Then filtro &= " AND "
                filtro &= $"Descripcion LIKE '%{textoBusqueda}%'"
            End If

            ' Aplicar el filtro
            dataView.RowFilter = filtro

            ' Asignar el DataView como origen de datos del DataGridView
            BunifuDataGridView1.DataSource = dataView
        End If
    End Sub

    Private Sub txtBuscarProdcutos_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProductos.TextChanged
        FiltrarGrilla()
    End Sub

#End Region

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress, txtCantidad.KeyPress, txtCosto.KeyPress, txtGanancia.KeyPress
        ' Solo permite números y controla la tecla Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Public Sub ExportarGrillaAPDF()
    '    ' Crear un PrintDocument
    '    Dim printDocument As New PrintDocument()

    '    ' Manejar el evento PrintPage para personalizar la impresión
    '    AddHandler printDocument.PrintPage, AddressOf Me.PrintGrilla

    '    ' Crear el diálogo de impresión
    '    Dim printDialog As New PrintDialog()
    '    printDialog.Document = printDocument
    '    printDialog.PrinterSettings.PrinterName = "Microsoft Print To PDF" ' Seleccionar "Microsoft Print To PDF"

    '    ' Mostrar el diálogo de impresión y ejecutar la impresión si el usuario hace clic en OK
    '    If printDialog.ShowDialog() = DialogResult.OK Then
    '        printDocument.Print()
    '    End If
    'End Sub


    Private Sub PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Tamaño y posición del panel en el PDF
        Dim panelWidth As Integer = Panel2.Width
        Dim panelHeight As Integer = Panel2.Height

        ' Margen superior e izquierdo
        Dim marginX As Integer = e.MarginBounds.Left
        Dim marginY As Integer = e.MarginBounds.Top

        ' Imprimir el Panel solo una vez
        If Not panelImpreso Then
            ' Capturar el Panel con los gráficos
            Dim panelBitmap As New Bitmap(panelWidth, panelHeight)
            Panel2.DrawToBitmap(panelBitmap, New Rectangle(0, 0, panelWidth, panelHeight))
            e.Graphics.DrawImage(panelBitmap, marginX, marginY)

            ' Dejar un espacio debajo del panel antes de empezar con el DataGridView
            Dim spacing As Integer = 20
            marginY += panelHeight + spacing

            ' Marcar el panel como impreso para que no se imprima en las siguientes páginas
            panelImpreso = True
        End If

        ' Variables para manejar el dibujo del DataGridView
        Dim cellHeight As Integer = 30
        Dim cellWidth As Integer
        Dim startX As Integer = marginX
        Dim availableHeight As Integer = e.MarginBounds.Height - marginY ' Altura restante para el DataGridView

        If currentRowIndex = 0 Then
            startX = marginX
            For Each column As DataGridViewColumn In BunifuDataGridView1.Columns
                ' Aumentar el ancho de ColumnDescripcion
                If column.Name = "ColumnDescripcion" Then
                    cellWidth = 200 ' Ajusta el valor según el espacio que necesites
                Else
                    cellWidth = column.Width
                End If

                e.Graphics.FillRectangle(Brushes.SteelBlue, New Rectangle(startX, marginY, cellWidth, cellHeight)) ' Fondo de encabezado
                e.Graphics.DrawString(column.HeaderText, BunifuDataGridView1.Font, Brushes.White, startX + 5, marginY + 5) ' Texto del encabezado
                startX += cellWidth
            Next
            marginY += cellHeight ' Avanzar a la siguiente línea después de los encabezados
        End If

        ' Dibujar filas del DataGridView
        startX = marginX
        While currentRowIndex < BunifuDataGridView1.Rows.Count
            Dim row As DataGridViewRow = BunifuDataGridView1.Rows(currentRowIndex)

            ' Verificar si hay suficiente espacio para la fila actual
            If marginY + cellHeight > e.MarginBounds.Bottom Then
                ' No hay suficiente espacio, saltar a la siguiente página
                e.HasMorePages = True
                Exit Sub
            End If

            ' Dibujar las celdas de la fila
            startX = marginX
            For Each cell As DataGridViewCell In row.Cells
                ' Aumentar el ancho de ColumnDescripcion en las filas también
                If BunifuDataGridView1.Columns(cell.ColumnIndex).Name = "ColumnDescripcion" Then
                    cellWidth = 200 ' Ajusta el valor según el espacio necesario
                Else
                    cellWidth = BunifuDataGridView1.Columns(cell.ColumnIndex).Width
                End If

                ' Dibuja el fondo de la celda
                Dim brush As Brush = New SolidBrush(row.DefaultCellStyle.BackColor)
                e.Graphics.FillRectangle(brush, New Rectangle(startX, marginY, cellWidth, cellHeight)) ' Fondo de la celda
                e.Graphics.DrawRectangle(Pens.Black, startX, marginY, cellWidth, cellHeight) ' Dibuja el borde de la celda

                ' Formatear la celda si es la columna de precio
                If BunifuDataGridView1.Columns(cell.ColumnIndex).Name = "Total" Then
                    Dim precio As Decimal
                    If Decimal.TryParse(cell.Value?.ToString(), precio) Then
                        e.Graphics.DrawString(precio.ToString("C2"), BunifuDataGridView1.Font, Brushes.Black, startX + 5, marginY + 5) ' Dibuja el texto con formato de precio
                    Else
                        e.Graphics.DrawString(cell.Value?.ToString(), BunifuDataGridView1.Font, Brushes.Black, startX + 5, marginY + 5) ' Dibuja el texto sin formatear
                    End If
                ElseIf BunifuDataGridView1.Columns(cell.ColumnIndex).Name = "Fecha" Then
                    Dim fecha As DateTime
                    If DateTime.TryParse(cell.Value?.ToString(), fecha) Then
                        e.Graphics.DrawString(fecha.ToString("dd/MM/yyyy"), BunifuDataGridView1.Font, Brushes.Black, startX + 5, marginY + 5) ' Dibuja el texto con formato de fecha
                    Else
                        e.Graphics.DrawString(cell.Value?.ToString(), BunifuDataGridView1.Font, Brushes.Black, startX + 5, marginY + 5) ' Dibuja el texto sin formatear
                    End If
                Else
                    e.Graphics.DrawString(cell.Value?.ToString(), BunifuDataGridView1.Font, Brushes.Black, startX + 5, marginY + 5) ' Dibuja el texto para otras columnas
                End If

                startX += cellWidth
            Next

            ' Moverse a la siguiente fila
            marginY += cellHeight
            currentRowIndex += 1
        End While

        ' Si no hay más filas, detener el proceso de impresión
        e.HasMorePages = False
    End Sub


    ' Manejar el evento PrintPage para dibujar la grilla en el PDF
    Private Sub PrintGrilla(sender As Object, e As PrintPageEventArgs)
        Dim font As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)
        Dim xPos As Integer = e.MarginBounds.Left
        Dim yPos As Integer = e.MarginBounds.Top
        Dim cellHeight As Integer = 20

        ' Imprimir encabezados de las columnas
        For Each column As DataGridViewColumn In BunifuDataGridView1.Columns
            e.Graphics.DrawString(column.HeaderText, font, brush, xPos, yPos)
            xPos += column.Width
        Next

        ' Imprimir las filas
        yPos += cellHeight ' Saltar una línea para las filas
        For Each row As DataGridViewRow In BunifuDataGridView1.Rows
            xPos = e.MarginBounds.Left ' Reiniciar la posición horizontal
            For Each cell As DataGridViewCell In row.Cells
                ' Verificar si el valor de la celda no es Nothing
                Dim cellValue As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), String.Empty)
                e.Graphics.DrawString(cellValue, font, brush, xPos, yPos)
                xPos += BunifuDataGridView1.Columns(cell.ColumnIndex).Width
            Next
            yPos += cellHeight ' Saltar a la siguiente fila
        Next
    End Sub

    Public Sub ExportarFormularioAPDF()
        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf Me.PrintPage

        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument
        printDialog.PrinterSettings.PrinterName = "Microsoft Print To PDF"

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
        Cargar_Grilla()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        'ExportarGrillaAPDF()
        ExportarFormularioAPDF()
    End Sub
End Class