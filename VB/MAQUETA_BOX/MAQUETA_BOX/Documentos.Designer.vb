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
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.PIN_GRUPO11DataSet = New MAQUETA_BOX.PIN_GRUPO11DataSet()
        Me.PINGRUPO11DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultardocumentosOrComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultar_documentos_OrComprasTableAdapter = New MAQUETA_BOX.PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrComprasTableAdapter()
        Me.ConsultardocumentosOrVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultar_documentos_OrVentasTableAdapter = New MAQUETA_BOX.PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrVentasTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.btnCargarTodo = New System.Windows.Forms.Button()
        Me.cboDia = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cboAño = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.PIN_GRUPO11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PINGRUPO11DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultardocumentosOrComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultardocumentosOrVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboClientes
        '
        Me.cboClientes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Items.AddRange(New Object() {"Deseleccionado"})
        Me.cboClientes.Location = New System.Drawing.Point(103, 59)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(121, 21)
        Me.cboClientes.TabIndex = 8
        Me.cboClientes.Text = "Cliente"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExportar.Location = New System.Drawing.Point(867, 59)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(147, 23)
        Me.btnExportar.TabIndex = 12
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
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
        Me.Panel1.Controls.Add(Me.cboEstado)
        Me.Panel1.Controls.Add(Me.btnCargarTodo)
        Me.Panel1.Controls.Add(Me.cboDia)
        Me.Panel1.Controls.Add(Me.cboMes)
        Me.Panel1.Controls.Add(Me.cboAño)
        Me.Panel1.Controls.Add(Me.btnExportar)
        Me.Panel1.Controls.Add(Me.cboClientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1105, 674)
        Me.Panel1.TabIndex = 13
        '
        'cboEstado
        '
        Me.cboEstado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(614, 59)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 17
        Me.cboEstado.Text = "Estado"
        '
        'btnCargarTodo
        '
        Me.btnCargarTodo.Location = New System.Drawing.Point(742, 57)
        Me.btnCargarTodo.Name = "btnCargarTodo"
        Me.btnCargarTodo.Size = New System.Drawing.Size(121, 23)
        Me.btnCargarTodo.TabIndex = 16
        Me.btnCargarTodo.Text = "Cargar Todo"
        Me.btnCargarTodo.UseVisualStyleBackColor = True
        '
        'cboDia
        '
        Me.cboDia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboDia.FormattingEnabled = True
        Me.cboDia.Location = New System.Drawing.Point(489, 59)
        Me.cboDia.Name = "cboDia"
        Me.cboDia.Size = New System.Drawing.Size(121, 21)
        Me.cboDia.TabIndex = 15
        Me.cboDia.Text = "Dia"
        '
        'cboMes
        '
        Me.cboMes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(359, 59)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(121, 21)
        Me.cboMes.TabIndex = 14
        Me.cboMes.Text = "Mes"
        '
        'cboAño
        '
        Me.cboAño.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboAño.FormattingEnabled = True
        Me.cboAño.Location = New System.Drawing.Point(230, 59)
        Me.cboAño.Name = "cboAño"
        Me.cboAño.Size = New System.Drawing.Size(121, 21)
        Me.cboAño.TabIndex = 13
        Me.cboAño.Text = "Año"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 27
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImageColumn})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(103, 245)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(951, 295)
        Me.DataGridView1.TabIndex = 18
        '
        'ImageColumn
        '
        Me.ImageColumn.HeaderText = ""
        Me.ImageColumn.Image = CType(resources.GetObject("ImageColumn.Image"), System.Drawing.Image)
        Me.ImageColumn.MinimumWidth = 2
        Me.ImageColumn.Name = "ImageColumn"
        Me.ImageColumn.ReadOnly = True
        Me.ImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ImageColumn.Width = 45
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
    Friend WithEvents cboClientes As System.Windows.Forms.ComboBox
    Friend WithEvents btnExportar As Button
    Friend WithEvents PINGRUPO11DataSetBindingSource As BindingSource
    Friend WithEvents PIN_GRUPO11DataSet As PIN_GRUPO11DataSet
    Friend WithEvents ConsultardocumentosOrComprasBindingSource As BindingSource
    Friend WithEvents Consultar_documentos_OrComprasTableAdapter As PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrComprasTableAdapter
    Friend WithEvents ConsultardocumentosOrVentasBindingSource As BindingSource
    Friend WithEvents Consultar_documentos_OrVentasTableAdapter As PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrVentasTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboDia As ComboBox
    Friend WithEvents cboMes As ComboBox
    Friend WithEvents cboAño As ComboBox
    Friend WithEvents btnCargarTodo As Button
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ImageColumn As DataGridViewImageColumn
End Class
