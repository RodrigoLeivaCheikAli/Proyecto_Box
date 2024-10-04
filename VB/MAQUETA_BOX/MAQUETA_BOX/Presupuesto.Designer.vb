<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presupuesto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presupuesto))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCheckBox1 = New Bunifu.UI.WinForms.BunifuCheckBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.cboMediosP = New System.Windows.Forms.ComboBox()
        Me.BunifuDatePicker1 = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.lblTotal = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblSubtotal = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel9 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblDescuento = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel7 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BunifuCheckBox1)
        Me.Panel1.Controls.Add(Me.cboCliente)
        Me.Panel1.Controls.Add(Me.cboMediosP)
        Me.Panel1.Controls.Add(Me.BunifuDatePicker1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BunifuLabel6)
        Me.Panel1.Controls.Add(Me.BunifuLabel5)
        Me.Panel1.Controls.Add(Me.BunifuLabel2)
        Me.Panel1.Controls.Add(Me.BunifuPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1123, 635)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView3.ColumnHeadersHeight = 40
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnTipo, Me.ColumnDescripcion, Me.ColumnVehiculo, Me.ColumnPrecio, Me.ColumnCantidad, Me.ColumnTotal})
        Me.DataGridView3.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView3.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView3.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView3.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView3.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView3.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.DataGridView3.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView3.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView3.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView3.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView3.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DataGridView3.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView3.CurrentTheme.Name = Nothing
        Me.DataGridView3.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView3.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView3.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView3.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView3.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView3.EnableHeadersVisualStyles = False
        Me.DataGridView3.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView3.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView3.HeaderBgColor = System.Drawing.Color.Empty
        Me.DataGridView3.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView3.Location = New System.Drawing.Point(103, 102)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowTemplate.Height = 40
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(935, 292)
        Me.DataGridView3.TabIndex = 42
        Me.DataGridView3.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'ColumnID
        '
        Me.ColumnID.HeaderText = "N°"
        Me.ColumnID.Name = "ColumnID"
        '
        'ColumnTipo
        '
        Me.ColumnTipo.HeaderText = "Tipo"
        Me.ColumnTipo.Name = "ColumnTipo"
        '
        'ColumnDescripcion
        '
        Me.ColumnDescripcion.HeaderText = "Descripcion"
        Me.ColumnDescripcion.Name = "ColumnDescripcion"
        '
        'ColumnVehiculo
        '
        Me.ColumnVehiculo.HeaderText = "Vehiculo"
        Me.ColumnVehiculo.Name = "ColumnVehiculo"
        '
        'ColumnPrecio
        '
        Me.ColumnPrecio.HeaderText = "Precio"
        Me.ColumnPrecio.Name = "ColumnPrecio"
        '
        'ColumnCantidad
        '
        Me.ColumnCantidad.HeaderText = "Cantidad"
        Me.ColumnCantidad.Name = "ColumnCantidad"
        '
        'ColumnTotal
        '
        Me.ColumnTotal.HeaderText = "Total"
        Me.ColumnTotal.Name = "ColumnTotal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(869, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 24)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Realizar Pedido"
        '
        'BunifuCheckBox1
        '
        Me.BunifuCheckBox1.AllowBindingControlAnimation = True
        Me.BunifuCheckBox1.AllowBindingControlColorChanges = False
        Me.BunifuCheckBox1.AllowBindingControlLocation = True
        Me.BunifuCheckBox1.AllowCheckBoxAnimation = False
        Me.BunifuCheckBox1.AllowCheckmarkAnimation = True
        Me.BunifuCheckBox1.AllowOnHoverStates = True
        Me.BunifuCheckBox1.AutoCheck = True
        Me.BunifuCheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.BackgroundImage = CType(resources.GetObject("BunifuCheckBox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right
        Me.BunifuCheckBox1.BorderRadius = 12
        Me.BunifuCheckBox1.Checked = True
        Me.BunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked
        Me.BunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuCheckBox1.CustomCheckmarkImage = Nothing
        Me.BunifuCheckBox1.Location = New System.Drawing.Point(1017, 41)
        Me.BunifuCheckBox1.MinimumSize = New System.Drawing.Size(17, 17)
        Me.BunifuCheckBox1.Name = "BunifuCheckBox1"
        Me.BunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCheckBox1.OnCheck.BorderRadius = 12
        Me.BunifuCheckBox1.OnCheck.BorderThickness = 2
        Me.BunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox1.OnCheck.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox1.OnDisable.BorderRadius = 12
        Me.BunifuCheckBox1.OnDisable.BorderThickness = 2
        Me.BunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray
        Me.BunifuCheckBox1.OnDisable.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverChecked.BorderRadius = 12
        Me.BunifuCheckBox1.OnHoverChecked.BorderThickness = 2
        Me.BunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White
        Me.BunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderRadius = 12
        Me.BunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1
        Me.BunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.DarkGray
        Me.BunifuCheckBox1.OnUncheck.BorderRadius = 12
        Me.BunifuCheckBox1.OnUncheck.BorderThickness = 1
        Me.BunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent
        Me.BunifuCheckBox1.Size = New System.Drawing.Size(21, 21)
        Me.BunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu
        Me.BunifuCheckBox1.TabIndex = 40
        Me.BunifuCheckBox1.ThreeState = False
        Me.BunifuCheckBox1.ToolTipText = Nothing
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(136, 45)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(160, 21)
        Me.cboCliente.TabIndex = 38
        '
        'cboMediosP
        '
        Me.cboMediosP.FormattingEnabled = True
        Me.cboMediosP.Location = New System.Drawing.Point(725, 44)
        Me.cboMediosP.Name = "cboMediosP"
        Me.cboMediosP.Size = New System.Drawing.Size(121, 21)
        Me.cboMediosP.TabIndex = 29
        '
        'BunifuDatePicker1
        '
        Me.BunifuDatePicker1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDatePicker1.BorderRadius = 1
        Me.BunifuDatePicker1.Color = System.Drawing.Color.Silver
        Me.BunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.BunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.BunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDatePicker1.DisplayWeekNumbers = False
        Me.BunifuDatePicker1.DPHeight = 0
        Me.BunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.BunifuDatePicker1.FillDatePicker = False
        Me.BunifuDatePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuDatePicker1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDatePicker1.Icon = CType(resources.GetObject("BunifuDatePicker1.Icon"), System.Drawing.Image)
        Me.BunifuDatePicker1.IconColor = System.Drawing.Color.Gray
        Me.BunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.BunifuDatePicker1.LeftTextMargin = 5
        Me.BunifuDatePicker1.Location = New System.Drawing.Point(376, 34)
        Me.BunifuDatePicker1.MinimumSize = New System.Drawing.Size(4, 32)
        Me.BunifuDatePicker1.Name = "BunifuDatePicker1"
        Me.BunifuDatePicker1.Size = New System.Drawing.Size(220, 32)
        Me.BunifuDatePicker1.TabIndex = 27
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox2.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnCANCELAR_1
        Me.PictureBox2.Location = New System.Drawing.Point(585, 533)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(118, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnACEPTAR_BLUE
        Me.PictureBox1.Location = New System.Drawing.Point(446, 533)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AllowParentOverrides = False
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.CursorType = Nothing
        Me.BunifuLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel6.Location = New System.Drawing.Point(613, 45)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(106, 20)
        Me.BunifuLabel6.TabIndex = 24
        Me.BunifuLabel6.Text = "Medio de Pago"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.Location = New System.Drawing.Point(325, 45)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(45, 20)
        Me.BunifuLabel5.TabIndex = 23
        Me.BunifuLabel5.Text = "Fecha"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(71, 45)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(49, 20)
        Me.BunifuLabel2.TabIndex = 22
        Me.BunifuLabel2.Text = "Cliente"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 3
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Controls.Add(Me.lblTotal)
        Me.BunifuPanel1.Controls.Add(Me.lblSubtotal)
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel9)
        Me.BunifuPanel1.Controls.Add(Me.lblDescuento)
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel7)
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel4)
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel3)
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel1)
        Me.BunifuPanel1.Location = New System.Drawing.Point(796, 400)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(242, 123)
        Me.BunifuPanel1.TabIndex = 21
        '
        'lblTotal
        '
        Me.lblTotal.AllowParentOverrides = False
        Me.lblTotal.AutoEllipsis = False
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotal.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(85, 77)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(0, 0)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblTotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AllowParentOverrides = False
        Me.lblSubtotal.AutoEllipsis = False
        Me.lblSubtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSubtotal.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.Color.White
        Me.lblSubtotal.Location = New System.Drawing.Point(122, 7)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSubtotal.Size = New System.Drawing.Size(0, 0)
        Me.lblSubtotal.TabIndex = 15
        Me.lblSubtotal.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblSubtotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel9
        '
        Me.BunifuLabel9.AllowParentOverrides = False
        Me.BunifuLabel9.AutoEllipsis = False
        Me.BunifuLabel9.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel9.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel9.Location = New System.Drawing.Point(79, 94)
        Me.BunifuLabel9.Name = "BunifuLabel9"
        Me.BunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel9.Size = New System.Drawing.Size(0, 0)
        Me.BunifuLabel9.TabIndex = 14
        Me.BunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblDescuento
        '
        Me.lblDescuento.AllowParentOverrides = False
        Me.lblDescuento.AutoEllipsis = False
        Me.lblDescuento.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescuento.CursorType = System.Windows.Forms.Cursors.Default
        Me.lblDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.ForeColor = System.Drawing.Color.White
        Me.lblDescuento.Location = New System.Drawing.Point(139, 42)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescuento.Size = New System.Drawing.Size(0, 0)
        Me.lblDescuento.TabIndex = 13
        Me.lblDescuento.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblDescuento.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel7
        '
        Me.BunifuLabel7.AllowParentOverrides = False
        Me.BunifuLabel7.AutoEllipsis = False
        Me.BunifuLabel7.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel7.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel7.Location = New System.Drawing.Point(122, 7)
        Me.BunifuLabel7.Name = "BunifuLabel7"
        Me.BunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel7.Size = New System.Drawing.Size(0, 0)
        Me.BunifuLabel7.TabIndex = 12
        Me.BunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel4.Location = New System.Drawing.Point(12, 77)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(61, 29)
        Me.BunifuLabel4.TabIndex = 11
        Me.BunifuLabel4.Text = "Total:"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel3.Location = New System.Drawing.Point(12, 42)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(121, 29)
        Me.BunifuLabel3.TabIndex = 10
        Me.BunifuLabel3.Text = "Descuento:"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(12, 7)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(104, 29)
        Me.BunifuLabel1.TabIndex = 9
        Me.BunifuLabel1.Text = "SubTotal:"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1123, 635)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Presupuesto"
        Me.Text = "Presupuesto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPanel1.ResumeLayout(False)
        Me.BunifuPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboMediosP As ComboBox
    Friend WithEvents BunifuDatePicker1 As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents lblTotal As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblSubtotal As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel9 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblDescuento As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel7 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents BunifuCheckBox1 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView3 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTipo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnVehiculo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotal As DataGridViewTextBoxColumn
End Class
