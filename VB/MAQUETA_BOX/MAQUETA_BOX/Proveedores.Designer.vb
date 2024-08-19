<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnComparacion = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.brnGuardar = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRubro = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCUIT = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.grillaProv = New Bunifu.UI.WinForms.BunifuDataGridView()
        CType(Me.btnComparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brnGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grillaProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.MinimumWidth = 2
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewImageColumn1.Width = 45
        '
        'btnComparacion
        '
        Me.btnComparacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComparacion.Image = CType(resources.GetObject("btnComparacion.Image"), System.Drawing.Image)
        Me.btnComparacion.InitialImage = Nothing
        Me.btnComparacion.Location = New System.Drawing.Point(931, 12)
        Me.btnComparacion.Name = "btnComparacion"
        Me.btnComparacion.Size = New System.Drawing.Size(135, 65)
        Me.btnComparacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnComparacion.TabIndex = 49
        Me.btnComparacion.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(415, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 48
        Me.PictureBox3.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(166, 16)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(243, 20)
        Me.txtBuscar.TabIndex = 46
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cboEstado)
        Me.Panel3.Controls.Add(Me.txtNotas)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtMail)
        Me.Panel3.Controls.Add(Me.txtTelefono)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.btnEliminar)
        Me.Panel3.Controls.Add(Me.btnModificar)
        Me.Panel3.Controls.Add(Me.brnGuardar)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtLocalidad)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txtRubro)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.txtDireccion)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.txtCUIT)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.txtId)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Location = New System.Drawing.Point(-1, 407)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1107, 269)
        Me.Panel3.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(787, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 25)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(912, 35)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(181, 33)
        Me.cboEstado.TabIndex = 28
        '
        'txtNotas
        '
        Me.txtNotas.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtNotas.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtNotas.Location = New System.Drawing.Point(912, 203)
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(181, 33)
        Me.txtNotas.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(793, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Notas"
        '
        'txtMail
        '
        Me.txtMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtMail.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtMail.Location = New System.Drawing.Point(544, 140)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(181, 33)
        Me.txtMail.TabIndex = 22
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtTelefono.Location = New System.Drawing.Point(544, 33)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(181, 33)
        Me.txtTelefono.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(454, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Mail"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(419, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 25)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Teléfono"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEliminar.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnELIMINAR
        Me.btnEliminar.Location = New System.Drawing.Point(662, 192)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 65)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModificar.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnMODIFICAR
        Me.btnModificar.Location = New System.Drawing.Point(503, 192)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 65)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.TabStop = False
        '
        'brnGuardar
        '
        Me.brnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.brnGuardar.Image = CType(resources.GetObject("brnGuardar.Image"), System.Drawing.Image)
        Me.brnGuardar.Location = New System.Drawing.Point(343, 192)
        Me.brnGuardar.Name = "brnGuardar"
        Me.brnGuardar.Size = New System.Drawing.Size(118, 65)
        Me.brnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.brnGuardar.TabIndex = 17
        Me.brnGuardar.TabStop = False
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(411, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 25)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Localidad"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtLocalidad.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtLocalidad.Location = New System.Drawing.Point(544, 92)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(181, 33)
        Me.txtLocalidad.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(792, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 25)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Rubro"
        '
        'txtRubro
        '
        Me.txtRubro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtRubro.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtRubro.Location = New System.Drawing.Point(912, 92)
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.Size = New System.Drawing.Size(181, 33)
        Me.txtRubro.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(39, 143)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 25)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtDireccion.Location = New System.Drawing.Point(208, 140)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(181, 33)
        Me.txtDireccion.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(49, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 25)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Nombre"
        '
        'txtCUIT
        '
        Me.txtCUIT.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtCUIT.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtCUIT.Location = New System.Drawing.Point(912, 143)
        Me.txtCUIT.Name = "txtCUIT"
        Me.txtCUIT.Size = New System.Drawing.Size(181, 33)
        Me.txtCUIT.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtNombre.Location = New System.Drawing.Point(208, 92)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(181, 33)
        Me.txtNombre.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(59, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 25)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Código"
        '
        'txtId
        '
        Me.txtId.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtId.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtId.Location = New System.Drawing.Point(208, 35)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(181, 33)
        Me.txtId.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(803, 143)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 25)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "CUIT"
        '
        'grillaProv
        '
        Me.grillaProv.AllowCustomTheming = False
        Me.grillaProv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.grillaProv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grillaProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grillaProv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grillaProv.BackgroundColor = System.Drawing.Color.White
        Me.grillaProv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grillaProv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grillaProv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grillaProv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grillaProv.ColumnHeadersHeight = 40
        Me.grillaProv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grillaProv.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grillaProv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.grillaProv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grillaProv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grillaProv.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.grillaProv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grillaProv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.grillaProv.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.grillaProv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grillaProv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grillaProv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.grillaProv.CurrentTheme.Name = Nothing
        Me.grillaProv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grillaProv.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grillaProv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.grillaProv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grillaProv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grillaProv.DefaultCellStyle = DataGridViewCellStyle3
        Me.grillaProv.EnableHeadersVisualStyles = False
        Me.grillaProv.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grillaProv.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.grillaProv.HeaderBgColor = System.Drawing.Color.Empty
        Me.grillaProv.HeaderForeColor = System.Drawing.Color.White
        Me.grillaProv.Location = New System.Drawing.Point(22, 67)
        Me.grillaProv.Name = "grillaProv"
        Me.grillaProv.ReadOnly = True
        Me.grillaProv.RowHeadersVisible = False
        Me.grillaProv.RowTemplate.Height = 40
        Me.grillaProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grillaProv.Size = New System.Drawing.Size(1053, 308)
        Me.grillaProv.TabIndex = 47
        Me.grillaProv.TabStop = False
        Me.grillaProv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1105, 674)
        Me.Controls.Add(Me.btnComparacion)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.grillaProv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form1"
        Me.Text = "Proveedores"
        CType(Me.btnComparacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brnGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grillaProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btnComparacion As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents brnGuardar As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtRubro As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCUIT As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents grillaProv As Bunifu.UI.WinForms.BunifuDataGridView
End Class
