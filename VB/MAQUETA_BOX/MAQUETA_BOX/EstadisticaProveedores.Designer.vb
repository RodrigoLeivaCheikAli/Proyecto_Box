<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticaProveedores
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chartProveedores = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartRentabilidadCosto = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chartProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartRentabilidadCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartProveedores
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartProveedores.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartProveedores.Legends.Add(Legend1)
        Me.chartProveedores.Location = New System.Drawing.Point(12, 217)
        Me.chartProveedores.Name = "chartProveedores"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartProveedores.Series.Add(Series1)
        Me.chartProveedores.Size = New System.Drawing.Size(1066, 447)
        Me.chartProveedores.TabIndex = 0
        Me.chartProveedores.Text = "Chart1"
        '
        'chartRentabilidadCosto
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartRentabilidadCosto.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartRentabilidadCosto.Legends.Add(Legend2)
        Me.chartRentabilidadCosto.Location = New System.Drawing.Point(668, 12)
        Me.chartRentabilidadCosto.Name = "chartRentabilidadCosto"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartRentabilidadCosto.Series.Add(Series2)
        Me.chartRentabilidadCosto.Size = New System.Drawing.Size(436, 222)
        Me.chartRentabilidadCosto.TabIndex = 1
        Me.chartRentabilidadCosto.Text = "Chart1"
        '
        'EstadisticaProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1141, 676)
        Me.Controls.Add(Me.chartRentabilidadCosto)
        Me.Controls.Add(Me.chartProveedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EstadisticaProveedores"
        Me.Text = "EstadisticaProveedores"
        CType(Me.chartProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartRentabilidadCosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chartProveedores As DataVisualization.Charting.Chart
    Friend WithEvents chartRentabilidadCosto As DataVisualization.Charting.Chart
End Class
