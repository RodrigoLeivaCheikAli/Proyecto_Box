<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos_Listado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos_Listado))
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.cboServicio = New System.Windows.Forms.ComboBox()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.cboVehiculo = New System.Windows.Forms.ComboBox()
        Me.BunifuDataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.txtBuscarProductos = New System.Windows.Forms.TextBox()
        Me.btnGestion = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnListado = New System.Windows.Forms.PictureBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(116, 168)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 29)
        Me.cboTipo.TabIndex = 33
        Me.cboTipo.Text = "Tipo"
        '
        'cboServicio
        '
        Me.cboServicio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.Location = New System.Drawing.Point(428, 168)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(121, 29)
        Me.cboServicio.TabIndex = 34
        Me.cboServicio.Text = "Servicio"
        '
        'cboProducto
        '
        Me.cboProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(272, 168)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(121, 29)
        Me.cboProducto.TabIndex = 35
        Me.cboProducto.Text = "Producto"
        '
        'cboVehiculo
        '
        Me.cboVehiculo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculo.FormattingEnabled = True
        Me.cboVehiculo.Location = New System.Drawing.Point(579, 168)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(121, 29)
        Me.cboVehiculo.TabIndex = 36
        Me.cboVehiculo.Text = "Vehículo"
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
        Me.BunifuDataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.BunifuDataGridView1.Location = New System.Drawing.Point(116, 222)
        Me.BunifuDataGridView1.Name = "BunifuDataGridView1"
        Me.BunifuDataGridView1.ReadOnly = True
        Me.BunifuDataGridView1.RowHeadersVisible = False
        Me.BunifuDataGridView1.RowTemplate.Height = 40
        Me.BunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView1.Size = New System.Drawing.Size(856, 328)
        Me.BunifuDataGridView1.TabIndex = 39
        Me.BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'txtBuscarProductos
        '
        Me.txtBuscarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarProductos.Location = New System.Drawing.Point(206, 35)
        Me.txtBuscarProductos.Name = "txtBuscarProductos"
        Me.txtBuscarProductos.Size = New System.Drawing.Size(243, 22)
        Me.txtBuscarProductos.TabIndex = 43
        '
        'btnGestion
        '
        Me.btnGestion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGestion.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnPRODUCTOS_BLUE
        Me.btnGestion.Location = New System.Drawing.Point(794, 14)
        Me.btnGestion.Name = "btnGestion"
        Me.btnGestion.Size = New System.Drawing.Size(115, 50)
        Me.btnGestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnGestion.TabIndex = 44
        Me.btnGestion.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(455, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'btnListado
        '
        Me.btnListado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListado.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnLISTADO_PRODUCTOS___WHITE
        Me.btnListado.Location = New System.Drawing.Point(665, 15)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(100, 50)
        Me.btnListado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnListado.TabIndex = 41
        Me.btnListado.TabStop = False
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(111, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 25)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Filtrar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 21)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Servicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(575, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Vehículo"
        '
        'Productos_Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1074, 626)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnGestion)
        Me.Controls.Add(Me.txtBuscarProductos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.BunifuDataGridView1)
        Me.Controls.Add(Me.cboVehiculo)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.cboServicio)
        Me.Controls.Add(Me.cboTipo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Productos_Listado"
        Me.Text = "Productos_Listado"
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents cboServicio As ComboBox
    Friend WithEvents cboProducto As ComboBox
    Friend WithEvents cboVehiculo As ComboBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents BunifuDataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents btnListado As PictureBox
    Friend WithEvents txtBuscarProductos As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnGestion As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
