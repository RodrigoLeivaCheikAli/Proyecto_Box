<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProvComparaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProvComparaciones))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.DataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.ButtonComparar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.txtPrecioMin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecioMax = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowCustomTheming = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.Name = Nothing
        Me.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(140, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(820, 308)
        Me.DataGridView1.TabIndex = 48
        Me.DataGridView1.TabStop = False
        Me.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'cboProveedor
        '
        Me.cboProveedor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(217, 64)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(181, 33)
        Me.cboProveedor.TabIndex = 49
        '
        'cboProducto
        '
        Me.cboProducto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProducto.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(217, 138)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(181, 33)
        Me.cboProducto.TabIndex = 50
        '
        'ButtonComparar
        '
        Me.ButtonComparar.AllowAnimations = True
        Me.ButtonComparar.AllowMouseEffects = True
        Me.ButtonComparar.AllowToggling = False
        Me.ButtonComparar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonComparar.AnimationSpeed = 200
        Me.ButtonComparar.AutoGenerateColors = False
        Me.ButtonComparar.AutoRoundBorders = False
        Me.ButtonComparar.AutoSizeLeftIcon = True
        Me.ButtonComparar.AutoSizeRightIcon = True
        Me.ButtonComparar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonComparar.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.ButtonComparar.BackgroundImage = CType(resources.GetObject("ButtonComparar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonComparar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ButtonComparar.ButtonText = "Comparar"
        Me.ButtonComparar.ButtonTextMarginLeft = 0
        Me.ButtonComparar.ColorContrastOnClick = 45
        Me.ButtonComparar.ColorContrastOnHover = 45
        Me.ButtonComparar.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.ButtonComparar.CustomizableEdges = BorderEdges1
        Me.ButtonComparar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ButtonComparar.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ButtonComparar.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonComparar.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ButtonComparar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.ButtonComparar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonComparar.ForeColor = System.Drawing.Color.White
        Me.ButtonComparar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonComparar.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.ButtonComparar.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.ButtonComparar.IconMarginLeft = 11
        Me.ButtonComparar.IconPadding = 10
        Me.ButtonComparar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonComparar.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.ButtonComparar.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.ButtonComparar.IconSize = 25
        Me.ButtonComparar.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.ButtonComparar.IdleBorderRadius = 1
        Me.ButtonComparar.IdleBorderThickness = 1
        Me.ButtonComparar.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.ButtonComparar.IdleIconLeftImage = Nothing
        Me.ButtonComparar.IdleIconRightImage = Nothing
        Me.ButtonComparar.IndicateFocus = False
        Me.ButtonComparar.Location = New System.Drawing.Point(943, 239)
        Me.ButtonComparar.Name = "ButtonComparar"
        Me.ButtonComparar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ButtonComparar.OnDisabledState.BorderRadius = 1
        Me.ButtonComparar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ButtonComparar.OnDisabledState.BorderThickness = 1
        Me.ButtonComparar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ButtonComparar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.ButtonComparar.OnDisabledState.IconLeftImage = Nothing
        Me.ButtonComparar.OnDisabledState.IconRightImage = Nothing
        Me.ButtonComparar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonComparar.onHoverState.BorderRadius = 1
        Me.ButtonComparar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ButtonComparar.onHoverState.BorderThickness = 1
        Me.ButtonComparar.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonComparar.onHoverState.ForeColor = System.Drawing.Color.White
        Me.ButtonComparar.onHoverState.IconLeftImage = Nothing
        Me.ButtonComparar.onHoverState.IconRightImage = Nothing
        Me.ButtonComparar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ButtonComparar.OnIdleState.BorderRadius = 1
        Me.ButtonComparar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ButtonComparar.OnIdleState.BorderThickness = 1
        Me.ButtonComparar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.ButtonComparar.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.ButtonComparar.OnIdleState.IconLeftImage = Nothing
        Me.ButtonComparar.OnIdleState.IconRightImage = Nothing
        Me.ButtonComparar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ButtonComparar.OnPressedState.BorderRadius = 1
        Me.ButtonComparar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.ButtonComparar.OnPressedState.BorderThickness = 1
        Me.ButtonComparar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ButtonComparar.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.ButtonComparar.OnPressedState.IconLeftImage = Nothing
        Me.ButtonComparar.OnPressedState.IconRightImage = Nothing
        Me.ButtonComparar.Size = New System.Drawing.Size(150, 39)
        Me.ButtonComparar.TabIndex = 52
        Me.ButtonComparar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonComparar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.ButtonComparar.TextMarginLeft = 0
        Me.ButtonComparar.TextPadding = New System.Windows.Forms.Padding(0)
        Me.ButtonComparar.UseDefaultRadiusAndThickness = True
        '
        'cboMarca
        '
        Me.cboMarca.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(594, 64)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(181, 33)
        Me.cboMarca.TabIndex = 53
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AllowAnimations = True
        Me.btnLimpiar.AllowMouseEffects = True
        Me.btnLimpiar.AllowToggling = False
        Me.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLimpiar.AnimationSpeed = 200
        Me.btnLimpiar.AutoGenerateColors = False
        Me.btnLimpiar.AutoRoundBorders = False
        Me.btnLimpiar.AutoSizeLeftIcon = True
        Me.btnLimpiar.AutoSizeRightIcon = True
        Me.btnLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnLimpiar.ButtonText = "Limpiar"
        Me.btnLimpiar.ButtonTextMarginLeft = 0
        Me.btnLimpiar.ColorContrastOnClick = 45
        Me.btnLimpiar.ColorContrastOnHover = 45
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnLimpiar.CustomizableEdges = BorderEdges2
        Me.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLimpiar.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnLimpiar.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLimpiar.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnLimpiar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnLimpiar.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnLimpiar.IconMarginLeft = 11
        Me.btnLimpiar.IconPadding = 10
        Me.btnLimpiar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnLimpiar.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnLimpiar.IconSize = 25
        Me.btnLimpiar.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnLimpiar.IdleBorderRadius = 1
        Me.btnLimpiar.IdleBorderThickness = 1
        Me.btnLimpiar.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnLimpiar.IdleIconLeftImage = Nothing
        Me.btnLimpiar.IdleIconRightImage = Nothing
        Me.btnLimpiar.IndicateFocus = False
        Me.btnLimpiar.Location = New System.Drawing.Point(943, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnLimpiar.OnDisabledState.BorderRadius = 1
        Me.btnLimpiar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnLimpiar.OnDisabledState.BorderThickness = 1
        Me.btnLimpiar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLimpiar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnLimpiar.OnDisabledState.IconLeftImage = Nothing
        Me.btnLimpiar.OnDisabledState.IconRightImage = Nothing
        Me.btnLimpiar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLimpiar.onHoverState.BorderRadius = 1
        Me.btnLimpiar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnLimpiar.onHoverState.BorderThickness = 1
        Me.btnLimpiar.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLimpiar.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.onHoverState.IconLeftImage = Nothing
        Me.btnLimpiar.onHoverState.IconRightImage = Nothing
        Me.btnLimpiar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnLimpiar.OnIdleState.BorderRadius = 1
        Me.btnLimpiar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnLimpiar.OnIdleState.BorderThickness = 1
        Me.btnLimpiar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnLimpiar.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.OnIdleState.IconLeftImage = Nothing
        Me.btnLimpiar.OnIdleState.IconRightImage = Nothing
        Me.btnLimpiar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnLimpiar.OnPressedState.BorderRadius = 1
        Me.btnLimpiar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnLimpiar.OnPressedState.BorderThickness = 1
        Me.btnLimpiar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnLimpiar.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.OnPressedState.IconLeftImage = Nothing
        Me.btnLimpiar.OnPressedState.IconRightImage = Nothing
        Me.btnLimpiar.Size = New System.Drawing.Size(150, 39)
        Me.btnLimpiar.TabIndex = 54
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLimpiar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnLimpiar.TextMarginLeft = 0
        Me.btnLimpiar.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnLimpiar.UseDefaultRadiusAndThickness = True
        '
        'txtPrecioMin
        '
        Me.txtPrecioMin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPrecioMin.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrecioMin.Location = New System.Drawing.Point(675, 159)
        Me.txtPrecioMin.Name = "txtPrecioMin"
        Me.txtPrecioMin.Size = New System.Drawing.Size(197, 33)
        Me.txtPrecioMin.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Filtros"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(70, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Proveedor"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 25)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Tipo de Producto"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(460, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(460, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Precios"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(58, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescripcion.Location = New System.Drawing.Point(217, 220)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(216, 33)
        Me.txtDescripcion.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(562, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 25)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Máximo"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(562, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 25)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Mínimo"
        '
        'txtPrecioMax
        '
        Me.txtPrecioMax.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPrecioMax.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtPrecioMax.Location = New System.Drawing.Point(675, 223)
        Me.txtPrecioMax.Name = "txtPrecioMax"
        Me.txtPrecioMax.Size = New System.Drawing.Size(197, 33)
        Me.txtPrecioMax.TabIndex = 65
        '
        'ProvComparaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1105, 674)
        Me.Controls.Add(Me.txtPrecioMax)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrecioMin)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.cboMarca)
        Me.Controls.Add(Me.ButtonComparar)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProvComparaciones"
        Me.Text = "ProvComparaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents cboProducto As ComboBox
    Friend WithEvents ButtonComparar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents btnLimpiar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents txtPrecioMin As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrecioMax As TextBox
End Class
