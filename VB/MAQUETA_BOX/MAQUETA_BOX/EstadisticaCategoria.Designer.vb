<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadisticaCategoria
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
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.chartProductoPorCategoria = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chartProductoPorCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.chartProductoPorCategoria.Location = New System.Drawing.Point(39, 12)
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
        Me.chartProductoPorCategoria.Size = New System.Drawing.Size(1061, 618)
        Me.chartProductoPorCategoria.TabIndex = 69
        Me.chartProductoPorCategoria.Text = "Productos por Rubros"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Cantidad de Productos por Categorias"
        Me.chartProductoPorCategoria.Titles.Add(Title1)
        '
        'EstadisticaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1141, 676)
        Me.Controls.Add(Me.chartProductoPorCategoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EstadisticaCategoria"
        Me.Text = "EstadisticaProductos"
        CType(Me.chartProductoPorCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chartProductoPorCategoria As DataVisualization.Charting.Chart
End Class
