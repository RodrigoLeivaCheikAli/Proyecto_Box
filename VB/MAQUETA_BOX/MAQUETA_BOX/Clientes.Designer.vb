﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtRubro = New System.Windows.Forms.TextBox()
        Me.txtCUIL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuDataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.txtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cboEstado)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtMail)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.txtRazonSocial)
        Me.Panel1.Controls.Add(Me.txtRubro)
        Me.Panel1.Controls.Add(Me.txtCUIL)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btnCargar)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 374)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1074, 252)
        Me.Panel1.TabIndex = 3
        '
        'cboEstado
        '
        Me.cboEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(789, 133)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(181, 33)
        Me.cboEstado.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(711, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Estado"
        '
        'txtMail
        '
        Me.txtMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtMail.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(495, 131)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(181, 33)
        Me.txtMail.TabIndex = 7
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(133, 131)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(181, 33)
        Me.txtDireccion.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(789, 77)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(181, 33)
        Me.txtTelefono.TabIndex = 5
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtRazonSocial.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Location = New System.Drawing.Point(495, 77)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(181, 33)
        Me.txtRazonSocial.TabIndex = 4
        '
        'txtRubro
        '
        Me.txtRubro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRubro.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRubro.Location = New System.Drawing.Point(133, 77)
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.Size = New System.Drawing.Size(181, 33)
        Me.txtRubro.TabIndex = 3
        '
        'txtCUIL
        '
        Me.txtCUIL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCUIL.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUIL.Location = New System.Drawing.Point(789, 24)
        Me.txtCUIL.Name = "txtCUIL"
        Me.txtCUIL.Size = New System.Drawing.Size(181, 33)
        Me.txtCUIL.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(406, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Nombre"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(133, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(181, 33)
        Me.txtCodigo.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(495, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(181, 33)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Rubro"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEliminar.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnELIMINAR
        Me.btnEliminar.Location = New System.Drawing.Point(639, 178)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 51)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEliminar.TabIndex = 44
        Me.btnEliminar.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModificar.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnMODIFICAR
        Me.btnModificar.Location = New System.Drawing.Point(472, 181)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 48)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnModificar.TabIndex = 43
        Me.btnModificar.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 25)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Dirección"
        '
        'btnCargar
        '
        Me.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCargar.Image = CType(resources.GetObject("btnCargar.Image"), System.Drawing.Image)
        Me.btnCargar.Location = New System.Drawing.Point(301, 181)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(118, 46)
        Me.btnCargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCargar.TabIndex = 42
        Me.btnCargar.TabStop = False
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(442, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 25)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Mail"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(361, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 25)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Razon Social"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(695, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 25)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Teléfono"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 25)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Codigo"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(728, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 25)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "CUIL"
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
        Me.BunifuDataGridView1.Location = New System.Drawing.Point(147, 80)
        Me.BunifuDataGridView1.Name = "BunifuDataGridView1"
        Me.BunifuDataGridView1.ReadOnly = True
        Me.BunifuDataGridView1.RowHeadersVisible = False
        Me.BunifuDataGridView1.RowTemplate.Height = 40
        Me.BunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView1.Size = New System.Drawing.Size(808, 261)
        Me.BunifuDataGridView1.TabIndex = 41
        Me.BunifuDataGridView1.TabStop = False
        Me.BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'txtBuscarClientes
        '
        Me.txtBuscarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarClientes.Location = New System.Drawing.Point(167, 27)
        Me.txtBuscarClientes.Name = "txtBuscarClientes"
        Me.txtBuscarClientes.Size = New System.Drawing.Size(243, 22)
        Me.txtBuscarClientes.TabIndex = 43
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(416, 23)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(28, 31)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 42
        Me.PictureBox7.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(869, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 34)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Exportar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1074, 626)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBuscarClientes)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.BunifuDataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(103, 157)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BunifuDataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnCargar As PictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents txtRubro As TextBox
    Friend WithEvents txtCUIL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtBuscarClientes As TextBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents Button1 As Button
End Class
