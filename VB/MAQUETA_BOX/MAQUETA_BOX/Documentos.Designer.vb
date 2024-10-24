<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Documentos
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Documentos))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.PIN_GRUPO11DataSet = New MAQUETA_BOX.PIN_GRUPO11DataSet()
        Me.PINGRUPO11DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultardocumentosOrComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultar_documentos_OrComprasTableAdapter = New MAQUETA_BOX.PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrComprasTableAdapter()
        Me.ConsultardocumentosOrVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultar_documentos_OrVentasTableAdapter = New MAQUETA_BOX.PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrVentasTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.btnEliminar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnCargarTodo1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.cboEstado1 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.cboDescripcion1 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.cboDia1 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.cboMes1 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.cboAño1 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.cboClientes1 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.btnExportar1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        CType(Me.PIN_GRUPO11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PINGRUPO11DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultardocumentosOrComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultardocumentosOrVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PIN_GRUPO11DataSet
        '
        Me.PIN_GRUPO11DataSet.DataSetName = "PIN_GRUPO11DataSet"
        Me.PIN_GRUPO11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PINGRUPO11DataSetBindingSource
        '
        Me.PINGRUPO11DataSetBindingSource.DataSource = Me.PIN_GRUPO11DataSet
        Me.PINGRUPO11DataSetBindingSource.Position = 0
        '
        'ConsultardocumentosOrComprasBindingSource
        '
        Me.ConsultardocumentosOrComprasBindingSource.DataMember = "consultar_documentos_OrCompras"
        Me.ConsultardocumentosOrComprasBindingSource.DataSource = Me.PINGRUPO11DataSetBindingSource
        '
        'Consultar_documentos_OrComprasTableAdapter
        '
        Me.Consultar_documentos_OrComprasTableAdapter.ClearBeforeFill = True
        '
        'ConsultardocumentosOrVentasBindingSource
        '
        Me.ConsultardocumentosOrVentasBindingSource.DataMember = "consultar_documentos_OrVentas"
        Me.ConsultardocumentosOrVentasBindingSource.DataSource = Me.PINGRUPO11DataSetBindingSource
        '
        'Consultar_documentos_OrVentasTableAdapter
        '
        Me.Consultar_documentos_OrVentasTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnCargarTodo1)
        Me.Panel1.Controls.Add(Me.cboEstado1)
        Me.Panel1.Controls.Add(Me.cboDescripcion1)
        Me.Panel1.Controls.Add(Me.cboDia1)
        Me.Panel1.Controls.Add(Me.cboMes1)
        Me.Panel1.Controls.Add(Me.cboAño1)
        Me.Panel1.Controls.Add(Me.cboClientes1)
        Me.Panel1.Controls.Add(Me.btnExportar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1105, 674)
        Me.Panel1.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
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
        Me.DataGridView1.Location = New System.Drawing.Point(123, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(807, 532)
        Me.DataGridView1.TabIndex = 30
        Me.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'btnEliminar
        '
        Me.btnEliminar.AllowAnimations = True
        Me.btnEliminar.AllowMouseEffects = True
        Me.btnEliminar.AllowToggling = False
        Me.btnEliminar.AnimationSpeed = 200
        Me.btnEliminar.AutoGenerateColors = False
        Me.btnEliminar.AutoRoundBorders = False
        Me.btnEliminar.AutoSizeLeftIcon = True
        Me.btnEliminar.AutoSizeRightIcon = True
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnEliminar.ButtonText = "Eliminar entrada"
        Me.btnEliminar.ButtonTextMarginLeft = 0
        Me.btnEliminar.ColorContrastOnClick = 45
        Me.btnEliminar.ColorContrastOnHover = 45
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnEliminar.CustomizableEdges = BorderEdges1
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEliminar.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEliminar.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnEliminar.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnEliminar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnEliminar.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnEliminar.IconMarginLeft = 11
        Me.btnEliminar.IconPadding = 10
        Me.btnEliminar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnEliminar.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnEliminar.IconSize = 25
        Me.btnEliminar.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnEliminar.IdleBorderRadius = 1
        Me.btnEliminar.IdleBorderThickness = 1
        Me.btnEliminar.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnEliminar.IdleIconLeftImage = Nothing
        Me.btnEliminar.IdleIconRightImage = Nothing
        Me.btnEliminar.IndicateFocus = False
        Me.btnEliminar.Location = New System.Drawing.Point(729, 67)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEliminar.OnDisabledState.BorderRadius = 1
        Me.btnEliminar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnEliminar.OnDisabledState.BorderThickness = 1
        Me.btnEliminar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnEliminar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnEliminar.OnDisabledState.IconLeftImage = Nothing
        Me.btnEliminar.OnDisabledState.IconRightImage = Nothing
        Me.btnEliminar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminar.onHoverState.BorderRadius = 1
        Me.btnEliminar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnEliminar.onHoverState.BorderThickness = 1
        Me.btnEliminar.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminar.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.onHoverState.IconLeftImage = Nothing
        Me.btnEliminar.onHoverState.IconRightImage = Nothing
        Me.btnEliminar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnEliminar.OnIdleState.BorderRadius = 1
        Me.btnEliminar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnEliminar.OnIdleState.BorderThickness = 1
        Me.btnEliminar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnEliminar.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.OnIdleState.IconLeftImage = Nothing
        Me.btnEliminar.OnIdleState.IconRightImage = Nothing
        Me.btnEliminar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnEliminar.OnPressedState.BorderRadius = 1
        Me.btnEliminar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnEliminar.OnPressedState.BorderThickness = 1
        Me.btnEliminar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnEliminar.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.OnPressedState.IconLeftImage = Nothing
        Me.btnEliminar.OnPressedState.IconRightImage = Nothing
        Me.btnEliminar.Size = New System.Drawing.Size(201, 32)
        Me.btnEliminar.TabIndex = 29
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEliminar.TextMarginLeft = 0
        Me.btnEliminar.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.UseDefaultRadiusAndThickness = True
        '
        'btnCargarTodo1
        '
        Me.btnCargarTodo1.AllowAnimations = True
        Me.btnCargarTodo1.AllowMouseEffects = True
        Me.btnCargarTodo1.AllowToggling = False
        Me.btnCargarTodo1.AnimationSpeed = 200
        Me.btnCargarTodo1.AutoGenerateColors = False
        Me.btnCargarTodo1.AutoRoundBorders = False
        Me.btnCargarTodo1.AutoSizeLeftIcon = True
        Me.btnCargarTodo1.AutoSizeRightIcon = True
        Me.btnCargarTodo1.BackColor = System.Drawing.Color.Transparent
        Me.btnCargarTodo1.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnCargarTodo1.BackgroundImage = CType(resources.GetObject("btnCargarTodo1.BackgroundImage"), System.Drawing.Image)
        Me.btnCargarTodo1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnCargarTodo1.ButtonText = "Cargar todo"
        Me.btnCargarTodo1.ButtonTextMarginLeft = 0
        Me.btnCargarTodo1.ColorContrastOnClick = 45
        Me.btnCargarTodo1.ColorContrastOnHover = 45
        Me.btnCargarTodo1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnCargarTodo1.CustomizableEdges = BorderEdges2
        Me.btnCargarTodo1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCargarTodo1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCargarTodo1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnCargarTodo1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCargarTodo1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnCargarTodo1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCargarTodo1.ForeColor = System.Drawing.Color.White
        Me.btnCargarTodo1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarTodo1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnCargarTodo1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnCargarTodo1.IconMarginLeft = 11
        Me.btnCargarTodo1.IconPadding = 10
        Me.btnCargarTodo1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargarTodo1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnCargarTodo1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnCargarTodo1.IconSize = 25
        Me.btnCargarTodo1.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnCargarTodo1.IdleBorderRadius = 1
        Me.btnCargarTodo1.IdleBorderThickness = 1
        Me.btnCargarTodo1.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnCargarTodo1.IdleIconLeftImage = Nothing
        Me.btnCargarTodo1.IdleIconRightImage = Nothing
        Me.btnCargarTodo1.IndicateFocus = False
        Me.btnCargarTodo1.Location = New System.Drawing.Point(123, 34)
        Me.btnCargarTodo1.Name = "btnCargarTodo1"
        Me.btnCargarTodo1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCargarTodo1.OnDisabledState.BorderRadius = 1
        Me.btnCargarTodo1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnCargarTodo1.OnDisabledState.BorderThickness = 1
        Me.btnCargarTodo1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnCargarTodo1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnCargarTodo1.OnDisabledState.IconLeftImage = Nothing
        Me.btnCargarTodo1.OnDisabledState.IconRightImage = Nothing
        Me.btnCargarTodo1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCargarTodo1.onHoverState.BorderRadius = 1
        Me.btnCargarTodo1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnCargarTodo1.onHoverState.BorderThickness = 1
        Me.btnCargarTodo1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCargarTodo1.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnCargarTodo1.onHoverState.IconLeftImage = Nothing
        Me.btnCargarTodo1.onHoverState.IconRightImage = Nothing
        Me.btnCargarTodo1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnCargarTodo1.OnIdleState.BorderRadius = 1
        Me.btnCargarTodo1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnCargarTodo1.OnIdleState.BorderThickness = 1
        Me.btnCargarTodo1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnCargarTodo1.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnCargarTodo1.OnIdleState.IconLeftImage = Nothing
        Me.btnCargarTodo1.OnIdleState.IconRightImage = Nothing
        Me.btnCargarTodo1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnCargarTodo1.OnPressedState.BorderRadius = 1
        Me.btnCargarTodo1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnCargarTodo1.OnPressedState.BorderThickness = 1
        Me.btnCargarTodo1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnCargarTodo1.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnCargarTodo1.OnPressedState.IconLeftImage = Nothing
        Me.btnCargarTodo1.OnPressedState.IconRightImage = Nothing
        Me.btnCargarTodo1.Size = New System.Drawing.Size(403, 32)
        Me.btnCargarTodo1.TabIndex = 28
        Me.btnCargarTodo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCargarTodo1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnCargarTodo1.TextMarginLeft = 0
        Me.btnCargarTodo1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnCargarTodo1.UseDefaultRadiusAndThickness = True
        '
        'cboEstado1
        '
        Me.cboEstado1.BackColor = System.Drawing.Color.Transparent
        Me.cboEstado1.BackgroundColor = System.Drawing.Color.White
        Me.cboEstado1.BorderColor = System.Drawing.Color.Silver
        Me.cboEstado1.BorderRadius = 1
        Me.cboEstado1.Color = System.Drawing.Color.Silver
        Me.cboEstado1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cboEstado1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboEstado1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cboEstado1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboEstado1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboEstado1.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.cboEstado1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEstado1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.cboEstado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboEstado1.FillDropDown = True
        Me.cboEstado1.FillIndicator = False
        Me.cboEstado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEstado1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboEstado1.ForeColor = System.Drawing.Color.Black
        Me.cboEstado1.FormattingEnabled = True
        Me.cboEstado1.Icon = Nothing
        Me.cboEstado1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboEstado1.IndicatorColor = System.Drawing.Color.Gray
        Me.cboEstado1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboEstado1.ItemBackColor = System.Drawing.Color.White
        Me.cboEstado1.ItemBorderColor = System.Drawing.Color.White
        Me.cboEstado1.ItemForeColor = System.Drawing.Color.Black
        Me.cboEstado1.ItemHeight = 26
        Me.cboEstado1.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.cboEstado1.ItemHighLightForeColor = System.Drawing.Color.White
        Me.cboEstado1.ItemTopMargin = 3
        Me.cboEstado1.Location = New System.Drawing.Point(628, 67)
        Me.cboEstado1.Name = "cboEstado1"
        Me.cboEstado1.Size = New System.Drawing.Size(100, 32)
        Me.cboEstado1.TabIndex = 27
        Me.cboEstado1.Text = "Estado"
        Me.cboEstado1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboEstado1.TextLeftMargin = 5
        '
        'cboDescripcion1
        '
        Me.cboDescripcion1.BackColor = System.Drawing.Color.Transparent
        Me.cboDescripcion1.BackgroundColor = System.Drawing.Color.White
        Me.cboDescripcion1.BorderColor = System.Drawing.Color.Silver
        Me.cboDescripcion1.BorderRadius = 1
        Me.cboDescripcion1.Color = System.Drawing.Color.Silver
        Me.cboDescripcion1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cboDescripcion1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboDescripcion1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cboDescripcion1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboDescripcion1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboDescripcion1.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.cboDescripcion1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDescripcion1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.cboDescripcion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDescripcion1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboDescripcion1.FillDropDown = True
        Me.cboDescripcion1.FillIndicator = False
        Me.cboDescripcion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDescripcion1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboDescripcion1.ForeColor = System.Drawing.Color.Black
        Me.cboDescripcion1.FormattingEnabled = True
        Me.cboDescripcion1.Icon = Nothing
        Me.cboDescripcion1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboDescripcion1.IndicatorColor = System.Drawing.Color.Gray
        Me.cboDescripcion1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboDescripcion1.ItemBackColor = System.Drawing.Color.White
        Me.cboDescripcion1.ItemBorderColor = System.Drawing.Color.White
        Me.cboDescripcion1.ItemForeColor = System.Drawing.Color.Black
        Me.cboDescripcion1.ItemHeight = 26
        Me.cboDescripcion1.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.cboDescripcion1.ItemHighLightForeColor = System.Drawing.Color.White
        Me.cboDescripcion1.ItemTopMargin = 3
        Me.cboDescripcion1.Location = New System.Drawing.Point(527, 67)
        Me.cboDescripcion1.Name = "cboDescripcion1"
        Me.cboDescripcion1.Size = New System.Drawing.Size(100, 32)
        Me.cboDescripcion1.TabIndex = 26
        Me.cboDescripcion1.Text = "Descripcion"
        Me.cboDescripcion1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboDescripcion1.TextLeftMargin = 5
        '
        'cboDia1
        '
        Me.cboDia1.BackColor = System.Drawing.Color.Transparent
        Me.cboDia1.BackgroundColor = System.Drawing.Color.White
        Me.cboDia1.BorderColor = System.Drawing.Color.Silver
        Me.cboDia1.BorderRadius = 1
        Me.cboDia1.Color = System.Drawing.Color.Silver
        Me.cboDia1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cboDia1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboDia1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cboDia1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboDia1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboDia1.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.cboDia1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDia1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.cboDia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDia1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboDia1.FillDropDown = True
        Me.cboDia1.FillIndicator = False
        Me.cboDia1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDia1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboDia1.ForeColor = System.Drawing.Color.Black
        Me.cboDia1.FormattingEnabled = True
        Me.cboDia1.Icon = Nothing
        Me.cboDia1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboDia1.IndicatorColor = System.Drawing.Color.Gray
        Me.cboDia1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboDia1.ItemBackColor = System.Drawing.Color.White
        Me.cboDia1.ItemBorderColor = System.Drawing.Color.White
        Me.cboDia1.ItemForeColor = System.Drawing.Color.Black
        Me.cboDia1.ItemHeight = 26
        Me.cboDia1.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.cboDia1.ItemHighLightForeColor = System.Drawing.Color.White
        Me.cboDia1.ItemTopMargin = 3
        Me.cboDia1.Location = New System.Drawing.Point(426, 67)
        Me.cboDia1.Name = "cboDia1"
        Me.cboDia1.Size = New System.Drawing.Size(100, 32)
        Me.cboDia1.TabIndex = 25
        Me.cboDia1.Text = "Día"
        Me.cboDia1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboDia1.TextLeftMargin = 5
        '
        'cboMes1
        '
        Me.cboMes1.BackColor = System.Drawing.Color.Transparent
        Me.cboMes1.BackgroundColor = System.Drawing.Color.White
        Me.cboMes1.BorderColor = System.Drawing.Color.Silver
        Me.cboMes1.BorderRadius = 1
        Me.cboMes1.Color = System.Drawing.Color.Silver
        Me.cboMes1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cboMes1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboMes1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cboMes1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboMes1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboMes1.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.cboMes1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMes1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.cboMes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboMes1.FillDropDown = True
        Me.cboMes1.FillIndicator = False
        Me.cboMes1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMes1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboMes1.ForeColor = System.Drawing.Color.Black
        Me.cboMes1.FormattingEnabled = True
        Me.cboMes1.Icon = Nothing
        Me.cboMes1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboMes1.IndicatorColor = System.Drawing.Color.Gray
        Me.cboMes1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboMes1.ItemBackColor = System.Drawing.Color.White
        Me.cboMes1.ItemBorderColor = System.Drawing.Color.White
        Me.cboMes1.ItemForeColor = System.Drawing.Color.Black
        Me.cboMes1.ItemHeight = 26
        Me.cboMes1.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.cboMes1.ItemHighLightForeColor = System.Drawing.Color.White
        Me.cboMes1.ItemTopMargin = 3
        Me.cboMes1.Location = New System.Drawing.Point(325, 67)
        Me.cboMes1.Name = "cboMes1"
        Me.cboMes1.Size = New System.Drawing.Size(100, 32)
        Me.cboMes1.TabIndex = 24
        Me.cboMes1.Text = "Mes"
        Me.cboMes1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboMes1.TextLeftMargin = 5
        '
        'cboAño1
        '
        Me.cboAño1.BackColor = System.Drawing.Color.Transparent
        Me.cboAño1.BackgroundColor = System.Drawing.Color.White
        Me.cboAño1.BorderColor = System.Drawing.Color.Silver
        Me.cboAño1.BorderRadius = 1
        Me.cboAño1.Color = System.Drawing.Color.Silver
        Me.cboAño1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cboAño1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboAño1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cboAño1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboAño1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboAño1.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.cboAño1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAño1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.cboAño1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAño1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboAño1.FillDropDown = True
        Me.cboAño1.FillIndicator = False
        Me.cboAño1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAño1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboAño1.ForeColor = System.Drawing.Color.Black
        Me.cboAño1.FormattingEnabled = True
        Me.cboAño1.Icon = Nothing
        Me.cboAño1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboAño1.IndicatorColor = System.Drawing.Color.Gray
        Me.cboAño1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboAño1.ItemBackColor = System.Drawing.Color.White
        Me.cboAño1.ItemBorderColor = System.Drawing.Color.White
        Me.cboAño1.ItemForeColor = System.Drawing.Color.Black
        Me.cboAño1.ItemHeight = 26
        Me.cboAño1.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.cboAño1.ItemHighLightForeColor = System.Drawing.Color.White
        Me.cboAño1.ItemTopMargin = 3
        Me.cboAño1.Location = New System.Drawing.Point(224, 67)
        Me.cboAño1.Name = "cboAño1"
        Me.cboAño1.Size = New System.Drawing.Size(100, 32)
        Me.cboAño1.TabIndex = 23
        Me.cboAño1.Text = "Año"
        Me.cboAño1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboAño1.TextLeftMargin = 5
        '
        'cboClientes1
        '
        Me.cboClientes1.BackColor = System.Drawing.Color.Transparent
        Me.cboClientes1.BackgroundColor = System.Drawing.Color.White
        Me.cboClientes1.BorderColor = System.Drawing.Color.Silver
        Me.cboClientes1.BorderRadius = 1
        Me.cboClientes1.Color = System.Drawing.Color.Silver
        Me.cboClientes1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cboClientes1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboClientes1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cboClientes1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cboClientes1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cboClientes1.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.cboClientes1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboClientes1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.cboClientes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClientes1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboClientes1.FillDropDown = True
        Me.cboClientes1.FillIndicator = False
        Me.cboClientes1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboClientes1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboClientes1.ForeColor = System.Drawing.Color.Black
        Me.cboClientes1.FormattingEnabled = True
        Me.cboClientes1.Icon = Nothing
        Me.cboClientes1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboClientes1.IndicatorColor = System.Drawing.Color.Gray
        Me.cboClientes1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cboClientes1.ItemBackColor = System.Drawing.Color.White
        Me.cboClientes1.ItemBorderColor = System.Drawing.Color.White
        Me.cboClientes1.ItemForeColor = System.Drawing.Color.Black
        Me.cboClientes1.ItemHeight = 26
        Me.cboClientes1.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.cboClientes1.ItemHighLightForeColor = System.Drawing.Color.White
        Me.cboClientes1.ItemTopMargin = 3
        Me.cboClientes1.Location = New System.Drawing.Point(123, 67)
        Me.cboClientes1.Name = "cboClientes1"
        Me.cboClientes1.Size = New System.Drawing.Size(100, 32)
        Me.cboClientes1.TabIndex = 22
        Me.cboClientes1.Text = "Cliente"
        Me.cboClientes1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cboClientes1.TextLeftMargin = 5
        '
        'btnExportar1
        '
        Me.btnExportar1.AllowAnimations = True
        Me.btnExportar1.AllowMouseEffects = True
        Me.btnExportar1.AllowToggling = False
        Me.btnExportar1.AnimationSpeed = 200
        Me.btnExportar1.AutoGenerateColors = False
        Me.btnExportar1.AutoRoundBorders = False
        Me.btnExportar1.AutoSizeLeftIcon = True
        Me.btnExportar1.AutoSizeRightIcon = True
        Me.btnExportar1.BackColor = System.Drawing.Color.Transparent
        Me.btnExportar1.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnExportar1.BackgroundImage = CType(resources.GetObject("btnExportar1.BackgroundImage"), System.Drawing.Image)
        Me.btnExportar1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExportar1.ButtonText = "Exportar"
        Me.btnExportar1.ButtonTextMarginLeft = 0
        Me.btnExportar1.ColorContrastOnClick = 45
        Me.btnExportar1.ColorContrastOnHover = 45
        Me.btnExportar1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.btnExportar1.CustomizableEdges = BorderEdges3
        Me.btnExportar1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExportar1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnExportar1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnExportar1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnExportar1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnExportar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExportar1.ForeColor = System.Drawing.Color.White
        Me.btnExportar1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnExportar1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnExportar1.IconMarginLeft = 11
        Me.btnExportar1.IconPadding = 10
        Me.btnExportar1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnExportar1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnExportar1.IconSize = 25
        Me.btnExportar1.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnExportar1.IdleBorderRadius = 1
        Me.btnExportar1.IdleBorderThickness = 1
        Me.btnExportar1.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnExportar1.IdleIconLeftImage = Nothing
        Me.btnExportar1.IdleIconRightImage = Nothing
        Me.btnExportar1.IndicateFocus = False
        Me.btnExportar1.Location = New System.Drawing.Point(527, 34)
        Me.btnExportar1.Name = "btnExportar1"
        Me.btnExportar1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnExportar1.OnDisabledState.BorderRadius = 1
        Me.btnExportar1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExportar1.OnDisabledState.BorderThickness = 1
        Me.btnExportar1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnExportar1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnExportar1.OnDisabledState.IconLeftImage = Nothing
        Me.btnExportar1.OnDisabledState.IconRightImage = Nothing
        Me.btnExportar1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExportar1.onHoverState.BorderRadius = 1
        Me.btnExportar1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExportar1.onHoverState.BorderThickness = 1
        Me.btnExportar1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExportar1.onHoverState.ForeColor = System.Drawing.Color.White
        Me.btnExportar1.onHoverState.IconLeftImage = Nothing
        Me.btnExportar1.onHoverState.IconRightImage = Nothing
        Me.btnExportar1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnExportar1.OnIdleState.BorderRadius = 1
        Me.btnExportar1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExportar1.OnIdleState.BorderThickness = 1
        Me.btnExportar1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnExportar1.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.btnExportar1.OnIdleState.IconLeftImage = Nothing
        Me.btnExportar1.OnIdleState.IconRightImage = Nothing
        Me.btnExportar1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnExportar1.OnPressedState.BorderRadius = 1
        Me.btnExportar1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExportar1.OnPressedState.BorderThickness = 1
        Me.btnExportar1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnExportar1.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnExportar1.OnPressedState.IconLeftImage = Nothing
        Me.btnExportar1.OnPressedState.IconRightImage = Nothing
        Me.btnExportar1.Size = New System.Drawing.Size(403, 32)
        Me.btnExportar1.TabIndex = 20
        Me.btnExportar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExportar1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExportar1.TextMarginLeft = 0
        Me.btnExportar1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnExportar1.UseDefaultRadiusAndThickness = True
        '
        'Documentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1105, 674)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Documentos"
        Me.Text = "Documentos"
        CType(Me.PIN_GRUPO11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PINGRUPO11DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultardocumentosOrComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultardocumentosOrVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PINGRUPO11DataSetBindingSource As BindingSource
    Friend WithEvents PIN_GRUPO11DataSet As PIN_GRUPO11DataSet
    Friend WithEvents ConsultardocumentosOrComprasBindingSource As BindingSource
    Friend WithEvents Consultar_documentos_OrComprasTableAdapter As PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrComprasTableAdapter
    Friend WithEvents ConsultardocumentosOrVentasBindingSource As BindingSource
    Friend WithEvents Consultar_documentos_OrVentasTableAdapter As PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrVentasTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExportar1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnCargarTodo1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents cboEstado1 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents cboDescripcion1 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents cboDia1 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents cboMes1 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents cboAño1 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents cboClientes1 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents btnEliminar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents DataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
End Class
