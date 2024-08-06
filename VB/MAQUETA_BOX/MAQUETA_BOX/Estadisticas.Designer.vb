<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadisticas
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estadisticas))
        Me.chartProductoPorCategoria = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartProdPreferidos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.lblPresupuesto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCategorias = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblProveedores = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.chartProductoPorCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartProdPreferidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartProductoPorCategoria
        '
        Me.chartProductoPorCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.chartProductoPorCategoria.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Legend1.Title = "Productos por Categorias"
        Me.chartProductoPorCategoria.Legends.Add(Legend1)
        Me.chartProductoPorCategoria.Location = New System.Drawing.Point(12, 12)
        Me.chartProductoPorCategoria.Name = "chartProductoPorCategoria"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar
        Series1.Color = System.Drawing.Color.DodgerBlue
        Series1.IsValueShownAsLabel = True
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel
        Me.chartProductoPorCategoria.Series.Add(Series1)
        Me.chartProductoPorCategoria.Size = New System.Drawing.Size(531, 300)
        Me.chartProductoPorCategoria.TabIndex = 39
        Me.chartProductoPorCategoria.Text = "Productos por Rubros"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Cantidad de Productos por Categorias"
        Me.chartProductoPorCategoria.Titles.Add(Title1)
        '
        'ChartProdPreferidos
        '
        Me.ChartProdPreferidos.Anchor = System.Windows.Forms.AnchorStyles.None
        ChartArea2.Name = "ChartArea1"
        Me.ChartProdPreferidos.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartProdPreferidos.Legends.Add(Legend2)
        Me.ChartProdPreferidos.Location = New System.Drawing.Point(549, 21)
        Me.ChartProdPreferidos.Name = "ChartProdPreferidos"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.IsValueShownAsLabel = True
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.YValuesPerPoint = 4
        Me.ChartProdPreferidos.Series.Add(Series2)
        Me.ChartProdPreferidos.Size = New System.Drawing.Size(452, 263)
        Me.ChartProdPreferidos.TabIndex = 40
        Me.ChartProdPreferidos.Text = "Chart1"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "Top Productos Mas Vendidos"
        Me.ChartProdPreferidos.Titles.Add(Title2)
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Ventas"
        '
        'lblVentas
        '
        Me.lblVentas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblVentas.AutoSize = True
        Me.lblVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentas.Location = New System.Drawing.Point(170, 420)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(30, 31)
        Me.lblVentas.TabIndex = 44
        Me.lblVentas.Text = "5"
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPresupuesto.AutoSize = True
        Me.lblPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresupuesto.Location = New System.Drawing.Point(170, 546)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(30, 31)
        Me.lblPresupuesto.TabIndex = 48
        Me.lblPresupuesto.Text = "5"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Presupuestos"
        '
        'lblCategorias
        '
        Me.lblCategorias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCategorias.AutoSize = True
        Me.lblCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategorias.Location = New System.Drawing.Point(559, 546)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(30, 31)
        Me.lblCategorias.TabIndex = 56
        Me.lblCategorias.Text = "5"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(528, 526)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Categorias"
        '
        'lblProductos
        '
        Me.lblProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductos.Location = New System.Drawing.Point(559, 420)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(30, 31)
        Me.lblProductos.TabIndex = 52
        Me.lblProductos.Text = "5"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(534, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Productos"
        '
        'lblProveedores
        '
        Me.lblProveedores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProveedores.AutoSize = True
        Me.lblProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedores.Location = New System.Drawing.Point(898, 546)
        Me.lblProveedores.Name = "lblProveedores"
        Me.lblProveedores.Size = New System.Drawing.Size(30, 31)
        Me.lblProveedores.TabIndex = 64
        Me.lblProveedores.Text = "5"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(863, 526)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 20)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Proveedores"
        '
        'lblClientes
        '
        Me.lblClientes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(898, 420)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(30, 31)
        Me.lblClientes.TabIndex = 60
        Me.lblClientes.Text = "5"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(878, 400)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 20)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Clientes"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.MAQUETA_BOX.My.Resources.Resources.presupuesto_de_tareas_de_lista_de_verificacion3
        Me.PictureBox3.Location = New System.Drawing.Point(40, 523)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 71)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 65
        Me.PictureBox3.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox9.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Image = Global.MAQUETA_BOX.My.Resources.Resources.Proveedores
        Me.PictureBox9.Location = New System.Drawing.Point(768, 523)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(74, 71)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 62
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox10.BackColor = System.Drawing.Color.White
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox10.Location = New System.Drawing.Point(768, 523)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(233, 71)
        Me.PictureBox10.TabIndex = 61
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox11.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox11.Image = Global.MAQUETA_BOX.My.Resources.Resources.Clientes
        Me.PictureBox11.Location = New System.Drawing.Point(768, 397)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(74, 71)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 58
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox12.BackColor = System.Drawing.Color.White
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox12.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox12.Location = New System.Drawing.Point(768, 397)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(233, 71)
        Me.PictureBox12.TabIndex = 57
        Me.PictureBox12.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox5.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = Global.MAQUETA_BOX.My.Resources.Resources.categoria
        Me.PictureBox5.Location = New System.Drawing.Point(429, 523)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(74, 71)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 54
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox6.Location = New System.Drawing.Point(429, 523)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(233, 71)
        Me.PictureBox6.TabIndex = 53
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox7.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = Global.MAQUETA_BOX.My.Resources.Resources.Productos
        Me.PictureBox7.Location = New System.Drawing.Point(429, 397)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(74, 71)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 50
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox8.Location = New System.Drawing.Point(429, 397)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(233, 71)
        Me.PictureBox8.TabIndex = 49
        Me.PictureBox8.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox4.Location = New System.Drawing.Point(40, 523)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(233, 71)
        Me.PictureBox4.TabIndex = 45
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.MAQUETA_BOX.My.Resources.Resources.Ventas
        Me.PictureBox2.Location = New System.Drawing.Point(40, 397)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(40, 397)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 71)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.MinimumWidth = 2
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewImageColumn2.Width = 45
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(265, 39)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "ESTADISTICAS"
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1139, 674)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblProveedores)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.lblCategorias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.lblProductos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.lblPresupuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblVentas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ChartProdPreferidos)
        Me.Controls.Add(Me.chartProductoPorCategoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Estadisticas"
        Me.Text = "Estadisticas"
        CType(Me.chartProductoPorCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartProdPreferidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents chartProductoPorCategoria As DataVisualization.Charting.Chart
    Friend WithEvents ChartProdPreferidos As DataVisualization.Charting.Chart
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVentas As Label
    Friend WithEvents lblPresupuesto As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblCategorias As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblProductos As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblProveedores As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents lblClientes As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label16 As Label
End Class
