<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Estadisticas = New System.Windows.Forms.Label()
        Me.lbl_Compras = New System.Windows.Forms.Label()
        Me.lbl_Productos = New System.Windows.Forms.Label()
        Me.lbl_Tire_Task = New System.Windows.Forms.Label()
        Me.lbl_Proveedores = New System.Windows.Forms.Label()
        Me.lbl_Documentos = New System.Windows.Forms.Label()
        Me.lbl_Ventas = New System.Windows.Forms.Label()
        Me.lbl_Clientes = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pb_Documentos = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pb_Productos = New System.Windows.Forms.PictureBox()
        Me.pb_Estadisticas = New System.Windows.Forms.PictureBox()
        Me.pb_Compras = New System.Windows.Forms.PictureBox()
        Me.pb_Clientes = New System.Windows.Forms.PictureBox()
        Me.pb_Ventas = New System.Windows.Forms.PictureBox()
        Me.pb_Proveedores = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Estadisticas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnMinimizar)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Controls.Add(Me.btnMaximizar)
        Me.Panel3.Controls.Add(Me.btnRestaurar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1300, 38)
        Me.Panel3.TabIndex = 93
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.PanelLateral.Controls.Add(Me.pb_Documentos)
        Me.PanelLateral.Controls.Add(Me.lbl_Estadisticas)
        Me.PanelLateral.Controls.Add(Me.lbl_Compras)
        Me.PanelLateral.Controls.Add(Me.lbl_Productos)
        Me.PanelLateral.Controls.Add(Me.PictureBox2)
        Me.PanelLateral.Controls.Add(Me.pb_Productos)
        Me.PanelLateral.Controls.Add(Me.pb_Estadisticas)
        Me.PanelLateral.Controls.Add(Me.pb_Compras)
        Me.PanelLateral.Controls.Add(Me.lbl_Tire_Task)
        Me.PanelLateral.Controls.Add(Me.lbl_Proveedores)
        Me.PanelLateral.Controls.Add(Me.pb_Clientes)
        Me.PanelLateral.Controls.Add(Me.lbl_Documentos)
        Me.PanelLateral.Controls.Add(Me.lbl_Ventas)
        Me.PanelLateral.Controls.Add(Me.pb_Ventas)
        Me.PanelLateral.Controls.Add(Me.pb_Proveedores)
        Me.PanelLateral.Controls.Add(Me.lbl_Clientes)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 38)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(397, 750)
        Me.PanelLateral.TabIndex = 94
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(397, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 750)
        Me.Panel1.TabIndex = 95
        '
        'lbl_Estadisticas
        '
        Me.lbl_Estadisticas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Estadisticas.AutoSize = True
        Me.lbl_Estadisticas.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbl_Estadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Estadisticas.ForeColor = System.Drawing.Color.White
        Me.lbl_Estadisticas.Location = New System.Drawing.Point(146, 686)
        Me.lbl_Estadisticas.Name = "lbl_Estadisticas"
        Me.lbl_Estadisticas.Size = New System.Drawing.Size(200, 37)
        Me.lbl_Estadisticas.TabIndex = 139
        Me.lbl_Estadisticas.Text = "Estadisticas"
        '
        'lbl_Compras
        '
        Me.lbl_Compras.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Compras.AutoSize = True
        Me.lbl_Compras.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbl_Compras.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Compras.ForeColor = System.Drawing.Color.White
        Me.lbl_Compras.Location = New System.Drawing.Point(148, 534)
        Me.lbl_Compras.Name = "lbl_Compras"
        Me.lbl_Compras.Size = New System.Drawing.Size(155, 37)
        Me.lbl_Compras.TabIndex = 135
        Me.lbl_Compras.Text = "Compras"
        '
        'lbl_Productos
        '
        Me.lbl_Productos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Productos.AutoSize = True
        Me.lbl_Productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbl_Productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Productos.ForeColor = System.Drawing.Color.White
        Me.lbl_Productos.Location = New System.Drawing.Point(146, 311)
        Me.lbl_Productos.Name = "lbl_Productos"
        Me.lbl_Productos.Size = New System.Drawing.Size(171, 37)
        Me.lbl_Productos.TabIndex = 129
        Me.lbl_Productos.Text = "Productos"
        '
        'lbl_Tire_Task
        '
        Me.lbl_Tire_Task.AutoSize = True
        Me.lbl_Tire_Task.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbl_Tire_Task.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tire_Task.ForeColor = System.Drawing.Color.White
        Me.lbl_Tire_Task.Location = New System.Drawing.Point(176, 90)
        Me.lbl_Tire_Task.Name = "lbl_Tire_Task"
        Me.lbl_Tire_Task.Size = New System.Drawing.Size(203, 39)
        Me.lbl_Tire_Task.TabIndex = 125
        Me.lbl_Tire_Task.Text = "TIRE TASK"
        '
        'lbl_Proveedores
        '
        Me.lbl_Proveedores.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Proveedores.AutoSize = True
        Me.lbl_Proveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbl_Proveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Proveedores.ForeColor = System.Drawing.Color.White
        Me.lbl_Proveedores.Location = New System.Drawing.Point(146, 389)
        Me.lbl_Proveedores.Name = "lbl_Proveedores"
        Me.lbl_Proveedores.Size = New System.Drawing.Size(207, 37)
        Me.lbl_Proveedores.TabIndex = 133
        Me.lbl_Proveedores.Text = "Proveedores"
        '
        'lbl_Documentos
        '
        Me.lbl_Documentos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Documentos.AutoSize = True
        Me.lbl_Documentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbl_Documentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Documentos.ForeColor = System.Drawing.Color.White
        Me.lbl_Documentos.Location = New System.Drawing.Point(146, 607)
        Me.lbl_Documentos.Name = "lbl_Documentos"
        Me.lbl_Documentos.Size = New System.Drawing.Size(207, 37)
        Me.lbl_Documentos.TabIndex = 137
        Me.lbl_Documentos.Text = "Documentos"
        '
        'lbl_Ventas
        '
        Me.lbl_Ventas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Ventas.AutoSize = True
        Me.lbl_Ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbl_Ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ventas.ForeColor = System.Drawing.Color.White
        Me.lbl_Ventas.Location = New System.Drawing.Point(146, 463)
        Me.lbl_Ventas.Name = "lbl_Ventas"
        Me.lbl_Ventas.Size = New System.Drawing.Size(123, 37)
        Me.lbl_Ventas.TabIndex = 131
        Me.lbl_Ventas.Text = "Ventas"
        '
        'lbl_Clientes
        '
        Me.lbl_Clientes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Clientes.AutoSize = True
        Me.lbl_Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lbl_Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Clientes.ForeColor = System.Drawing.Color.White
        Me.lbl_Clientes.Location = New System.Drawing.Point(146, 236)
        Me.lbl_Clientes.Name = "lbl_Clientes"
        Me.lbl_Clientes.Size = New System.Drawing.Size(139, 37)
        Me.lbl_Clientes.TabIndex = 127
        Me.lbl_Clientes.Text = "Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(903, 750)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 109
        Me.PictureBox1.TabStop = False
        '
        'pb_Documentos
        '
        Me.pb_Documentos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pb_Documentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pb_Documentos.Image = CType(resources.GetObject("pb_Documentos.Image"), System.Drawing.Image)
        Me.pb_Documentos.Location = New System.Drawing.Point(12, 587)
        Me.pb_Documentos.Name = "pb_Documentos"
        Me.pb_Documentos.Size = New System.Drawing.Size(130, 69)
        Me.pb_Documentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Documentos.TabIndex = 136
        Me.pb_Documentos.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 175)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 124
        Me.PictureBox2.TabStop = False
        '
        'pb_Productos
        '
        Me.pb_Productos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pb_Productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pb_Productos.Image = CType(resources.GetObject("pb_Productos.Image"), System.Drawing.Image)
        Me.pb_Productos.Location = New System.Drawing.Point(12, 292)
        Me.pb_Productos.Name = "pb_Productos"
        Me.pb_Productos.Size = New System.Drawing.Size(130, 69)
        Me.pb_Productos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Productos.TabIndex = 128
        Me.pb_Productos.TabStop = False
        '
        'pb_Estadisticas
        '
        Me.pb_Estadisticas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pb_Estadisticas.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pb_Estadisticas.Image = CType(resources.GetObject("pb_Estadisticas.Image"), System.Drawing.Image)
        Me.pb_Estadisticas.Location = New System.Drawing.Point(12, 670)
        Me.pb_Estadisticas.Name = "pb_Estadisticas"
        Me.pb_Estadisticas.Size = New System.Drawing.Size(130, 69)
        Me.pb_Estadisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Estadisticas.TabIndex = 138
        Me.pb_Estadisticas.TabStop = False
        '
        'pb_Compras
        '
        Me.pb_Compras.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pb_Compras.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pb_Compras.Image = CType(resources.GetObject("pb_Compras.Image"), System.Drawing.Image)
        Me.pb_Compras.Location = New System.Drawing.Point(12, 514)
        Me.pb_Compras.Name = "pb_Compras"
        Me.pb_Compras.Size = New System.Drawing.Size(130, 69)
        Me.pb_Compras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Compras.TabIndex = 134
        Me.pb_Compras.TabStop = False
        '
        'pb_Clientes
        '
        Me.pb_Clientes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pb_Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pb_Clientes.Image = CType(resources.GetObject("pb_Clientes.Image"), System.Drawing.Image)
        Me.pb_Clientes.Location = New System.Drawing.Point(12, 217)
        Me.pb_Clientes.Name = "pb_Clientes"
        Me.pb_Clientes.Size = New System.Drawing.Size(130, 69)
        Me.pb_Clientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Clientes.TabIndex = 126
        Me.pb_Clientes.TabStop = False
        '
        'pb_Ventas
        '
        Me.pb_Ventas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pb_Ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pb_Ventas.Image = CType(resources.GetObject("pb_Ventas.Image"), System.Drawing.Image)
        Me.pb_Ventas.Location = New System.Drawing.Point(12, 442)
        Me.pb_Ventas.Name = "pb_Ventas"
        Me.pb_Ventas.Size = New System.Drawing.Size(130, 69)
        Me.pb_Ventas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Ventas.TabIndex = 130
        Me.pb_Ventas.TabStop = False
        '
        'pb_Proveedores
        '
        Me.pb_Proveedores.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pb_Proveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pb_Proveedores.Image = CType(resources.GetObject("pb_Proveedores.Image"), System.Drawing.Image)
        Me.pb_Proveedores.Location = New System.Drawing.Point(12, 367)
        Me.pb_Proveedores.Name = "pb_Proveedores"
        Me.pb_Proveedores.Size = New System.Drawing.Size(130, 69)
        Me.pb_Proveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_Proveedores.TabIndex = 132
        Me.pb_Proveedores.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.MAQUETA_BOX.My.Resources.Resources.icons8_minimizar_16
        Me.btnMinimizar.Location = New System.Drawing.Point(1177, 6)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(33, 28)
        Me.btnMinimizar.TabIndex = 94
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.MAQUETA_BOX.My.Resources.Resources.cruz_white_16x16
        Me.btnCerrar.Location = New System.Drawing.Point(1255, 6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(33, 28)
        Me.btnCerrar.TabIndex = 92
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.MAQUETA_BOX.My.Resources.Resources.maximizar_16x16
        Me.btnMaximizar.Location = New System.Drawing.Point(1216, 7)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(33, 28)
        Me.btnMaximizar.TabIndex = 95
        Me.btnMaximizar.UseVisualStyleBackColor = False
        Me.btnMaximizar.Visible = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.MAQUETA_BOX.My.Resources.Resources.icons8_restore_down_20x20
        Me.btnRestaurar.Location = New System.Drawing.Point(1216, 6)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(33, 28)
        Me.btnRestaurar.TabIndex = 93
        Me.btnRestaurar.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incio"
        Me.Panel3.ResumeLayout(False)
        Me.PanelLateral.ResumeLayout(False)
        Me.PanelLateral.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Documentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Estadisticas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents pb_Documentos As PictureBox
    Friend WithEvents lbl_Estadisticas As Label
    Friend WithEvents lbl_Compras As Label
    Friend WithEvents lbl_Productos As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pb_Productos As PictureBox
    Friend WithEvents pb_Estadisticas As PictureBox
    Friend WithEvents pb_Compras As PictureBox
    Friend WithEvents lbl_Tire_Task As Label
    Friend WithEvents lbl_Proveedores As Label
    Friend WithEvents pb_Clientes As PictureBox
    Friend WithEvents lbl_Documentos As Label
    Friend WithEvents lbl_Ventas As Label
    Friend WithEvents pb_Ventas As PictureBox
    Friend WithEvents pb_Proveedores As PictureBox
    Friend WithEvents lbl_Clientes As Label
End Class
