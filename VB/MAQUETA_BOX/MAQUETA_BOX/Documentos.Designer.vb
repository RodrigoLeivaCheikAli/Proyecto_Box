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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cboDocumentos = New System.Windows.Forms.ComboBox()
        Me.cboProductos = New System.Windows.Forms.ComboBox()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.PIN_GRUPO11DataSet = New MAQUETA_BOX.PIN_GRUPO11DataSet()
        Me.PINGRUPO11DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultardocumentosOrComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultar_documentos_OrComprasTableAdapter = New MAQUETA_BOX.PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrComprasTableAdapter()
        Me.ConsultardocumentosOrVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultar_documentos_OrVentasTableAdapter = New MAQUETA_BOX.PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrVentasTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIN_GRUPO11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PINGRUPO11DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultardocumentosOrComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultardocumentosOrVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeight = 27
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(213, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(716, 334)
        Me.DataGridView1.TabIndex = 5
        '
        'cboDocumentos
        '
        Me.cboDocumentos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboDocumentos.FormattingEnabled = True
        Me.cboDocumentos.Items.AddRange(New Object() {"Cliente", "Proveedor"})
        Me.cboDocumentos.Location = New System.Drawing.Point(366, 59)
        Me.cboDocumentos.Name = "cboDocumentos"
        Me.cboDocumentos.Size = New System.Drawing.Size(121, 21)
        Me.cboDocumentos.TabIndex = 6
        Me.cboDocumentos.Text = "Documento"
        '
        'cboProductos
        '
        Me.cboProductos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboProductos.FormattingEnabled = True
        Me.cboProductos.Location = New System.Drawing.Point(104, 59)
        Me.cboProductos.Name = "cboProductos"
        Me.cboProductos.Size = New System.Drawing.Size(121, 21)
        Me.cboProductos.TabIndex = 7
        Me.cboProductos.Text = "Producto"
        '
        'cboClientes
        '
        Me.cboClientes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(513, 59)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(121, 21)
        Me.cboClientes.TabIndex = 8
        Me.cboClientes.Text = "Cliente"
        '
        'cboProveedores
        '
        Me.cboProveedores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Location = New System.Drawing.Point(231, 59)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(121, 21)
        Me.cboProveedores.TabIndex = 9
        Me.cboProveedores.Text = "Proveedor"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.Location = New System.Drawing.Point(661, 60)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 11
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
        Me.Panel1.Controls.Add(Me.btnExportar)
        Me.Panel1.Controls.Add(Me.cboDocumentos)
        Me.Panel1.Controls.Add(Me.cboClientes)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.cboProveedores)
        Me.Panel1.Controls.Add(Me.cboProductos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1105, 674)
        Me.Panel1.TabIndex = 13
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIN_GRUPO11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PINGRUPO11DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultardocumentosOrComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultardocumentosOrVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cboDocumentos As System.Windows.Forms.ComboBox
    Friend WithEvents cboProductos As System.Windows.Forms.ComboBox
    Friend WithEvents cboClientes As System.Windows.Forms.ComboBox
    Friend WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExportar As Button
    Friend WithEvents PINGRUPO11DataSetBindingSource As BindingSource
    Friend WithEvents PIN_GRUPO11DataSet As PIN_GRUPO11DataSet
    Friend WithEvents ConsultardocumentosOrComprasBindingSource As BindingSource
    Friend WithEvents Consultar_documentos_OrComprasTableAdapter As PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrComprasTableAdapter
    Friend WithEvents ConsultardocumentosOrVentasBindingSource As BindingSource
    Friend WithEvents Consultar_documentos_OrVentasTableAdapter As PIN_GRUPO11DataSetTableAdapters.consultar_documentos_OrVentasTableAdapter
    Friend WithEvents Panel1 As Panel
End Class
