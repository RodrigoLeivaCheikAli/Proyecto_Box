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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuPanel1 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuDatePicker1 = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeight = 27
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView2.Location = New System.Drawing.Point(112, 145)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(893, 292)
        Me.DataGridView2.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nº"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
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
        'Column5
        '
        Me.Column5.HeaderText = "Precio"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "Cantidad"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total"
        Me.Column7.Name = "Column7"
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(88, 35)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(49, 20)
        Me.BunifuLabel2.TabIndex = 11
        Me.BunifuLabel2.Text = "Cliente"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.Location = New System.Drawing.Point(342, 35)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(45, 20)
        Me.BunifuLabel5.TabIndex = 12
        Me.BunifuLabel5.Text = "Fecha"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AllowParentOverrides = False
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.CursorType = Nothing
        Me.BunifuLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel6.Location = New System.Drawing.Point(697, 35)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(106, 20)
        Me.BunifuLabel6.TabIndex = 13
        Me.BunifuLabel6.Text = "Medio de Pago"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuPanel1
        '
        Me.BunifuPanel1.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.BunifuPanel1.BackgroundImage = CType(resources.GetObject("BunifuPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel1.BorderRadius = 3
        Me.BunifuPanel1.BorderThickness = 1
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel4)
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel3)
        Me.BunifuPanel1.Controls.Add(Me.BunifuLabel1)
        Me.BunifuPanel1.Location = New System.Drawing.Point(763, 443)
        Me.BunifuPanel1.Name = "BunifuPanel1"
        Me.BunifuPanel1.ShowBorders = True
        Me.BunifuPanel1.Size = New System.Drawing.Size(242, 123)
        Me.BunifuPanel1.TabIndex = 10
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnACEPTAR_BLUE
        Me.PictureBox1.Location = New System.Drawing.Point(306, 534)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MAQUETA_BOX.My.Resources.Resources.btnCANCELAR_1
        Me.PictureBox2.Location = New System.Drawing.Point(493, 534)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(181, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
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
        Me.BunifuDatePicker1.Location = New System.Drawing.Point(393, 35)
        Me.BunifuDatePicker1.MinimumSize = New System.Drawing.Size(4, 32)
        Me.BunifuDatePicker1.Name = "BunifuDatePicker1"
        Me.BunifuDatePicker1.Size = New System.Drawing.Size(220, 32)
        Me.BunifuDatePicker1.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 20)
        Me.TextBox1.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(809, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'Presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1123, 635)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BunifuDatePicker1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BunifuLabel6)
        Me.Controls.Add(Me.BunifuLabel5)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuPanel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Presupuesto"
        Me.Text = "Presupuesto"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuPanel1.ResumeLayout(False)
        Me.BunifuPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPanel1 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuDatePicker1 As Bunifu.UI.WinForms.BunifuDatePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
