﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGanancia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.cboVehiculo = New System.Windows.Forms.ComboBox()
        Me.btnCargar = New System.Windows.Forms.PictureBox()
        Me.BunifuDataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnGanancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscarProductos = New System.Windows.Forms.TextBox()
        Me.btnGestion = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnListado = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnListado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(74, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Código"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(419, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Vehículo"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Proveedor"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(155, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(122, 33)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(513, 28)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 33)
        Me.txtDescripcion.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(743, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 25)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Marca"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(86, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 25)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Costo"
        '
        'txtCosto
        '
        Me.txtCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCosto.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Location = New System.Drawing.Point(153, 125)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(122, 33)
        Me.txtCosto.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtGanancia)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cboTipo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboProveedor)
        Me.Panel1.Controls.Add(Me.cboMarca)
        Me.Panel1.Controls.Add(Me.cboVehiculo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnCargar)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtCosto)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 374)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1074, 252)
        Me.Panel1.TabIndex = 31
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(815, 125)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(122, 33)
        Me.txtCantidad.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(717, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 25)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Cantidad"
        '
        'txtGanancia
        '
        Me.txtGanancia.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtGanancia.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGanancia.Location = New System.Drawing.Point(513, 125)
        Me.txtGanancia.Name = "txtGanancia"
        Me.txtGanancia.Size = New System.Drawing.Size(122, 33)
        Me.txtGanancia.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(411, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 25)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Ganancia"
        '
        'cboTipo
        '
        Me.cboTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(815, 28)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(140, 33)
        Me.cboTipo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(760, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Tipo"
        '
        'cboProveedor
        '
        Me.cboProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(155, 78)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(140, 33)
        Me.cboProveedor.TabIndex = 3
        '
        'cboMarca
        '
        Me.cboMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(815, 77)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(140, 33)
        Me.cboMarca.TabIndex = 5
        '
        'cboVehiculo
        '
        Me.cboVehiculo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cboVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVehiculo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculo.FormattingEnabled = True
        Me.cboVehiculo.Location = New System.Drawing.Point(513, 77)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(140, 33)
        Me.cboVehiculo.TabIndex = 4
        '
        'btnCargar
        '
        Me.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCargar.Image = CType(resources.GetObject("btnCargar.Image"), System.Drawing.Image)
        Me.btnCargar.Location = New System.Drawing.Point(276, 183)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(118, 46)
        Me.btnCargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCargar.TabIndex = 15
        Me.btnCargar.TabStop = False
        '
        'BunifuDataGridView1
        '
        Me.BunifuDataGridView1.AllowCustomTheming = False
        Me.BunifuDataGridView1.AllowUserToAddRows = False
        Me.BunifuDataGridView1.AllowUserToDeleteRows = False
        Me.BunifuDataGridView1.AllowUserToResizeColumns = False
        Me.BunifuDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuDataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuDataGridView1.ColumnHeadersHeight = 40
        Me.BunifuDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnTipo, Me.ColumnDescripcion, Me.ColumnMarca, Me.ColumnVehiculo, Me.ColumnProveedor, Me.ColumnCosto, Me.ColumnGanancia, Me.ColumnPrecio, Me.ColumnStock})
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.Name = Nothing
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuDataGridView1.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.BunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.Location = New System.Drawing.Point(91, 91)
        Me.BunifuDataGridView1.Name = "BunifuDataGridView1"
        Me.BunifuDataGridView1.ReadOnly = True
        Me.BunifuDataGridView1.RowHeadersVisible = False
        Me.BunifuDataGridView1.RowTemplate.Height = 40
        Me.BunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView1.Size = New System.Drawing.Size(899, 261)
        Me.BunifuDataGridView1.TabIndex = 40
        Me.BunifuDataGridView1.TabStop = False
        Me.BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'ColumnID
        '
        Me.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnID.DataPropertyName = "ID"
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        Me.ColumnID.ReadOnly = True
        '
        'ColumnTipo
        '
        Me.ColumnTipo.DataPropertyName = "Tipo"
        Me.ColumnTipo.HeaderText = "Tipo"
        Me.ColumnTipo.Name = "ColumnTipo"
        Me.ColumnTipo.ReadOnly = True
        '
        'ColumnDescripcion
        '
        Me.ColumnDescripcion.DataPropertyName = "Descripcion"
        Me.ColumnDescripcion.HeaderText = "Descripción"
        Me.ColumnDescripcion.Name = "ColumnDescripcion"
        Me.ColumnDescripcion.ReadOnly = True
        '
        'ColumnMarca
        '
        Me.ColumnMarca.DataPropertyName = "Marca"
        Me.ColumnMarca.HeaderText = "Marca"
        Me.ColumnMarca.Name = "ColumnMarca"
        Me.ColumnMarca.ReadOnly = True
        '
        'ColumnVehiculo
        '
        Me.ColumnVehiculo.DataPropertyName = "Vehiculo"
        Me.ColumnVehiculo.HeaderText = "Vehiculo"
        Me.ColumnVehiculo.Name = "ColumnVehiculo"
        Me.ColumnVehiculo.ReadOnly = True
        '
        'ColumnProveedor
        '
        Me.ColumnProveedor.DataPropertyName = "Proveedor"
        Me.ColumnProveedor.HeaderText = "Proveedor"
        Me.ColumnProveedor.Name = "ColumnProveedor"
        Me.ColumnProveedor.ReadOnly = True
        '
        'ColumnCosto
        '
        Me.ColumnCosto.DataPropertyName = "Costo"
        Me.ColumnCosto.HeaderText = "Costo"
        Me.ColumnCosto.Name = "ColumnCosto"
        Me.ColumnCosto.ReadOnly = True
        '
        'ColumnGanancia
        '
        Me.ColumnGanancia.DataPropertyName = "Ganancia"
        Me.ColumnGanancia.HeaderText = "Ganancia"
        Me.ColumnGanancia.Name = "ColumnGanancia"
        Me.ColumnGanancia.ReadOnly = True
        '
        'ColumnPrecio
        '
        Me.ColumnPrecio.DataPropertyName = "Precio"
        Me.ColumnPrecio.HeaderText = "Precio"
        Me.ColumnPrecio.Name = "ColumnPrecio"
        Me.ColumnPrecio.ReadOnly = True
        '
        'ColumnStock
        '
        Me.ColumnStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ColumnStock.DataPropertyName = "Stock"
        Me.ColumnStock.HeaderText = "Stock"
        Me.ColumnStock.Name = "ColumnStock"
        Me.ColumnStock.ReadOnly = True
        Me.ColumnStock.Width = 74
        '
        'txtBuscarProductos
        '
        Me.txtBuscarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarProductos.Location = New System.Drawing.Point(206, 35)
        Me.txtBuscarProductos.Name = "txtBuscarProductos"
        Me.txtBuscarProductos.Size = New System.Drawing.Size(243, 22)
        Me.txtBuscarProductos.TabIndex = 41
        '
        'btnGestion
        '
        Me.btnGestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGestion.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnPRODUCTOS_WHITE
        Me.btnGestion.Location = New System.Drawing.Point(665, 15)
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Size = New System.Drawing.Size(115, 50)
        Me.btnGestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGestion.TabIndex = 42
        Me.btnGestion.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(455, 31)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(28, 31)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 29
        Me.PictureBox7.TabStop = False
        '
        'btnListado
        '
        Me.btnListado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListado.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnLISTADO
        Me.btnListado.Location = New System.Drawing.Point(809, 14)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(100, 50)
        Me.btnListado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnListado.TabIndex = 28
        Me.btnListado.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminar.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnELIMINAR
        Me.btnEliminar.Location = New System.Drawing.Point(671, 549)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 65)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModificar.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnMODIFICAR
        Me.btnModificar.Location = New System.Drawing.Point(479, 549)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 65)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.TabStop = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.MinimumWidth = 2
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExportar.FlatAppearance.BorderSize = 0
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ForeColor = System.Drawing.Color.White
        Me.btnExportar.Location = New System.Drawing.Point(933, 23)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(101, 34)
        Me.btnExportar.TabIndex = 43
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Location = New System.Drawing.Point(60, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(973, 297)
        Me.Panel2.TabIndex = 44
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1074, 626)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnGestion)
        Me.Controls.Add(Me.txtBuscarProductos)
        Me.Controls.Add(Me.BunifuDataGridView1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnCargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnListado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnCargar As PictureBox
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btnListado As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboVehiculo As ComboBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents txtGanancia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuDataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBuscarProductos As TextBox
    Friend WithEvents btnGestion As PictureBox
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTipo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnMarca As DataGridViewTextBoxColumn
    Friend WithEvents ColumnVehiculo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnProveedor As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCosto As DataGridViewTextBoxColumn
    Friend WithEvents ColumnGanancia As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnStock As DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As Button
    Friend WithEvents Panel2 As Panel
End Class
