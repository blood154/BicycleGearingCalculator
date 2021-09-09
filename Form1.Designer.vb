<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.NumericUpDown_FrontRing = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown_RearRing = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_Gearing_Ratio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Speed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown_Cadence = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown_RearWheelSize = New System.Windows.Forms.NumericUpDown()
        Me.Button_Calculate = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.Front_chainring = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rear_chainring = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gear_Ratio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wheel_diameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cadence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Speed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Export = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_FileName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown_FrontRing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_RearRing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_Cadence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_RearWheelSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown_FrontRing
        '
        Me.NumericUpDown_FrontRing.Location = New System.Drawing.Point(23, 62)
        Me.NumericUpDown_FrontRing.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FrontRing.Name = "NumericUpDown_FrontRing"
        Me.NumericUpDown_FrontRing.Size = New System.Drawing.Size(62, 20)
        Me.NumericUpDown_FrontRing.TabIndex = 0
        Me.NumericUpDown_FrontRing.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Front chainring"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rear chainring"
        '
        'NumericUpDown_RearRing
        '
        Me.NumericUpDown_RearRing.Location = New System.Drawing.Point(23, 103)
        Me.NumericUpDown_RearRing.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_RearRing.Name = "NumericUpDown_RearRing"
        Me.NumericUpDown_RearRing.Size = New System.Drawing.Size(62, 20)
        Me.NumericUpDown_RearRing.TabIndex = 2
        Me.NumericUpDown_RearRing.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'TextBox_Gearing_Ratio
        '
        Me.TextBox_Gearing_Ratio.Enabled = False
        Me.TextBox_Gearing_Ratio.Location = New System.Drawing.Point(19, 230)
        Me.TextBox_Gearing_Ratio.Name = "TextBox_Gearing_Ratio"
        Me.TextBox_Gearing_Ratio.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Gearing_Ratio.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Gearing ratio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Speed in kph (mph)"
        '
        'TextBox_Speed
        '
        Me.TextBox_Speed.Enabled = False
        Me.TextBox_Speed.Location = New System.Drawing.Point(20, 271)
        Me.TextBox_Speed.Name = "TextBox_Speed"
        Me.TextBox_Speed.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Speed.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cadence (1/min)"
        '
        'NumericUpDown_Cadence
        '
        Me.NumericUpDown_Cadence.Location = New System.Drawing.Point(23, 142)
        Me.NumericUpDown_Cadence.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_Cadence.Name = "NumericUpDown_Cadence"
        Me.NumericUpDown_Cadence.Size = New System.Drawing.Size(62, 20)
        Me.NumericUpDown_Cadence.TabIndex = 8
        Me.NumericUpDown_Cadence.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Wheel diameter (in millimeters)"
        '
        'NumericUpDown_RearWheelSize
        '
        Me.NumericUpDown_RearWheelSize.Location = New System.Drawing.Point(23, 181)
        Me.NumericUpDown_RearWheelSize.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.NumericUpDown_RearWheelSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_RearWheelSize.Name = "NumericUpDown_RearWheelSize"
        Me.NumericUpDown_RearWheelSize.Size = New System.Drawing.Size(62, 20)
        Me.NumericUpDown_RearWheelSize.TabIndex = 10
        Me.NumericUpDown_RearWheelSize.Value = New Decimal(New Integer() {700, 0, 0, 0})
        '
        'Button_Calculate
        '
        Me.Button_Calculate.Location = New System.Drawing.Point(19, 12)
        Me.Button_Calculate.Name = "Button_Calculate"
        Me.Button_Calculate.Size = New System.Drawing.Size(75, 23)
        Me.Button_Calculate.TabIndex = 12
        Me.Button_Calculate.Text = "Calculate"
        Me.Button_Calculate.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Front_chainring, Me.Rear_chainring, Me.Gear_Ratio, Me.Wheel_diameter, Me.Cadence, Me.Speed})
        Me.Grid.Location = New System.Drawing.Point(208, 12)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(602, 279)
        Me.Grid.TabIndex = 15
        '
        'Front_chainring
        '
        Me.Front_chainring.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Front_chainring.HeaderText = "Front chainring"
        Me.Front_chainring.Name = "Front_chainring"
        Me.Front_chainring.Width = 102
        '
        'Rear_chainring
        '
        Me.Rear_chainring.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rear_chainring.HeaderText = "Rear chainring"
        Me.Rear_chainring.Name = "Rear_chainring"
        Me.Rear_chainring.Width = 101
        '
        'Gear_Ratio
        '
        Me.Gear_Ratio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Gear_Ratio.HeaderText = "Gear ratio"
        Me.Gear_Ratio.Name = "Gear_Ratio"
        Me.Gear_Ratio.Width = 78
        '
        'Wheel_diameter
        '
        Me.Wheel_diameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Wheel_diameter.HeaderText = "Wheel diameter in mm"
        Me.Wheel_diameter.Name = "Wheel_diameter"
        Me.Wheel_diameter.Width = 110
        '
        'Cadence
        '
        Me.Cadence.HeaderText = "Cadence"
        Me.Cadence.Name = "Cadence"
        '
        'Speed
        '
        Me.Speed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Speed.HeaderText = "Speed in kph (mph)"
        Me.Speed.Name = "Speed"
        Me.Speed.Width = 90
        '
        'Button_Export
        '
        Me.Button_Export.Location = New System.Drawing.Point(208, 311)
        Me.Button_Export.Name = "Button_Export"
        Me.Button_Export.Size = New System.Drawing.Size(75, 23)
        Me.Button_Export.TabIndex = 16
        Me.Button_Export.Text = "Export table"
        Me.Button_Export.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(205, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "FileName"
        '
        'TextBox_FileName
        '
        Me.TextBox_FileName.Location = New System.Drawing.Point(205, 353)
        Me.TextBox_FileName.Name = "TextBox_FileName"
        Me.TextBox_FileName.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_FileName.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(311, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = ".txt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 386)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_FileName)
        Me.Controls.Add(Me.Button_Export)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Button_Calculate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown_RearWheelSize)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown_Cadence)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Speed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_Gearing_Ratio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown_RearRing)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown_FrontRing)
        Me.Name = "Form1"
        Me.Text = "BicycleGearingCalculator"
        CType(Me.NumericUpDown_FrontRing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_RearRing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_Cadence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_RearWheelSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericUpDown_FrontRing As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown_RearRing As NumericUpDown
    Friend WithEvents TextBox_Gearing_Ratio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Speed As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown_Cadence As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown_RearWheelSize As NumericUpDown
    Friend WithEvents Button_Calculate As Button
    Friend WithEvents Grid As DataGridView
    Friend WithEvents Front_chainring As DataGridViewTextBoxColumn
    Friend WithEvents Rear_chainring As DataGridViewTextBoxColumn
    Friend WithEvents Gear_Ratio As DataGridViewTextBoxColumn
    Friend WithEvents Wheel_diameter As DataGridViewTextBoxColumn
    Friend WithEvents Cadence As DataGridViewTextBoxColumn
    Friend WithEvents Speed As DataGridViewTextBoxColumn
    Friend WithEvents Button_Export As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_FileName As TextBox
    Friend WithEvents Label8 As Label
End Class
