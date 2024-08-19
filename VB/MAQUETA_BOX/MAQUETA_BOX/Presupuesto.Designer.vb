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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presupuesto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.colOferta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPanel1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
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
        Me.Panel1.Controls.Add(Me.DataGridView3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1123, 635)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(911, 35)
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
        Me.BunifuCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.BunifuCheckBox1.Location = New System.Drawing.Point(1059, 35)
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
        Me.cboCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(178, 48)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(160, 21)
        Me.cboCliente.TabIndex = 38
        '
        'cboMediosP
        '
        Me.cboMediosP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboMediosP.FormattingEnabled = True
        Me.cboMediosP.Location = New System.Drawing.Point(767, 47)
        Me.cboMediosP.Name = "cboMediosP"
        Me.cboMediosP.Size = New System.Drawing.Size(121, 21)
        Me.cboMediosP.TabIndex = 29
        '
        'BunifuDatePicker1
        '
        Me.BunifuDatePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.BunifuDatePicker1.Location = New System.Drawing.Point(418, 37)
        Me.BunifuDatePicker1.MinimumSize = New System.Drawing.Size(4, 32)
        Me.BunifuDatePicker1.Name = "BunifuDatePicker1"
        Me.BunifuDatePicker1.Size = New System.Drawing.Size(220, 32)
        Me.BunifuDatePicker1.TabIndex = 27
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox2.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnCANCELAR_1
        Me.PictureBox2.Location = New System.Drawing.Point(605, 533)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox1.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnACEPTAR_BLUE
        Me.PictureBox1.Location = New System.Drawing.Point(418, 533)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AllowParentOverrides = False
        Me.BunifuLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.CursorType = Nothing
        Me.BunifuLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel6.Location = New System.Drawing.Point(655, 48)
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
        Me.BunifuLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.Location = New System.Drawing.Point(367, 48)
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
        Me.BunifuLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(113, 48)
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
        Me.BunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.BunifuPanel1.Location = New System.Drawing.Point(776, 396)
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
        'DataGridView3
        '
        Me.DataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView3.ColumnHeadersHeight = 27
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOferta, Me.Column2, Me.Column3, Me.Column4, Me.rate, Me.quantity, Me.price})
        Me.DataGridView3.EnableHeadersVisualStyles = False
        Me.DataGridView3.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView3.Location = New System.Drawing.Point(125, 98)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView3.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView3.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(893, 292)
        Me.DataGridView3.TabIndex = 20
        '
        'colOferta
        '
        Me.colOferta.HeaderText = "Nº"
        Me.colOferta.Name = "colOferta"
        Me.colOferta.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tipo"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descripcion"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Vehiculo"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 130
        '
        'rate
        '
        Me.rate.HeaderText = "Precio"
        Me.rate.Name = "rate"
        Me.rate.Width = 120
        '
        'quantity
        '
        Me.quantity.HeaderText = "Cantidad"
        Me.quantity.Name = "quantity"
        Me.quantity.Width = 70
        '
        'price
        '
        Me.price.HeaderText = "Total"
        Me.price.Name = "price"
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPanel1.ResumeLayout(False)
        Me.BunifuPanel1.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents BunifuCheckBox1 As Bunifu.UI.WinForms.BunifuCheckBox
    Friend WithEvents colOferta As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents rate As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
