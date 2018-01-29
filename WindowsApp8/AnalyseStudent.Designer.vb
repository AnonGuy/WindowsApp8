<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnalyseStudent
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
        Me.ProgressChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ProgressChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.ProgressChart.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.ProgressChart.Legends.Add(Legend1)
        Me.ProgressChart.Location = New System.Drawing.Point(12, 12)
        Me.ProgressChart.Name = "ProgressChart"
        Me.ProgressChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.Name = "Score"
        Me.ProgressChart.Series.Add(Series1)
        Me.ProgressChart.Size = New System.Drawing.Size(407, 274)
        Me.ProgressChart.TabIndex = 0
        Me.ProgressChart.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Corbel", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Student Progress"
        Title1.Text = "Student Progress"
        Me.ProgressChart.Titles.Add(Title1)
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(114, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 39)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AnalyseStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 345)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProgressChart)
        Me.Name = "AnalyseStudent"
        Me.Text = "AnalyseStudent"
        CType(Me.ProgressChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressChart As DataVisualization.Charting.Chart
    Friend WithEvents Button2 As Button
End Class
