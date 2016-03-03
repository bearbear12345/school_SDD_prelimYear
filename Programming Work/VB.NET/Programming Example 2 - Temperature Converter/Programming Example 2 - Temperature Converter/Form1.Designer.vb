<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(appMain))
        Me.valCelsius = New System.Windows.Forms.NumericUpDown()
        Me.valFarenheit = New System.Windows.Forms.NumericUpDown()
        Me.queryQuit = New System.Windows.Forms.CheckBox()
        Me.valKelvin = New System.Windows.Forms.NumericUpDown()
        Me.textFarenheit = New System.Windows.Forms.Label()
        Me.textKelvin = New System.Windows.Forms.Label()
        Me.textCelsius = New System.Windows.Forms.Label()
        Me.appTick = New System.Windows.Forms.Timer(Me.components)
        CType(Me.valCelsius, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valFarenheit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valKelvin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'valCelsius
        '
        Me.valCelsius.DecimalPlaces = 2
        Me.valCelsius.Location = New System.Drawing.Point(12, 12)
        Me.valCelsius.Name = "valCelsius"
        Me.valCelsius.Size = New System.Drawing.Size(68, 20)
        Me.valCelsius.TabIndex = 0
        '
        'valFarenheit
        '
        Me.valFarenheit.DecimalPlaces = 2
        Me.valFarenheit.Location = New System.Drawing.Point(163, 12)
        Me.valFarenheit.Name = "valFarenheit"
        Me.valFarenheit.Size = New System.Drawing.Size(68, 20)
        Me.valFarenheit.TabIndex = 2
        '
        'queryQuit
        '
        Me.queryQuit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.queryQuit.AutoSize = True
        Me.queryQuit.Location = New System.Drawing.Point(185, 71)
        Me.queryQuit.Name = "queryQuit"
        Me.queryQuit.Size = New System.Drawing.Size(51, 17)
        Me.queryQuit.TabIndex = 99
        Me.queryQuit.Text = "Quit?"
        Me.queryQuit.UseVisualStyleBackColor = True
        '
        'valKelvin
        '
        Me.valKelvin.DecimalPlaces = 2
        Me.valKelvin.Location = New System.Drawing.Point(89, 12)
        Me.valKelvin.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.valKelvin.Name = "valKelvin"
        Me.valKelvin.Size = New System.Drawing.Size(68, 20)
        Me.valKelvin.TabIndex = 1
        '
        'textFarenheit
        '
        Me.textFarenheit.AutoSize = True
        Me.textFarenheit.Location = New System.Drawing.Point(160, 39)
        Me.textFarenheit.Name = "textFarenheit"
        Me.textFarenheit.Size = New System.Drawing.Size(70, 13)
        Me.textFarenheit.TabIndex = 4
        Me.textFarenheit.Text = "Farenheit (°F)"
        '
        'textKelvin
        '
        Me.textKelvin.AutoSize = True
        Me.textKelvin.Location = New System.Drawing.Point(86, 38)
        Me.textKelvin.Name = "textKelvin"
        Me.textKelvin.Size = New System.Drawing.Size(52, 13)
        Me.textKelvin.TabIndex = 5
        Me.textKelvin.Text = "Kelvin (K)"
        '
        'textCelsius
        '
        Me.textCelsius.AutoSize = True
        Me.textCelsius.Location = New System.Drawing.Point(13, 39)
        Me.textCelsius.Name = "textCelsius"
        Me.textCelsius.Size = New System.Drawing.Size(60, 13)
        Me.textCelsius.TabIndex = 6
        Me.textCelsius.Text = "Celsius (°C)"
        '
        'appTick
        '
        Me.appTick.Enabled = True
        Me.appTick.Interval = 50
        '
        'appMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 95)
        Me.ControlBox = False
        Me.Controls.Add(Me.textCelsius)
        Me.Controls.Add(Me.textKelvin)
        Me.Controls.Add(Me.textFarenheit)
        Me.Controls.Add(Me.valKelvin)
        Me.Controls.Add(Me.queryQuit)
        Me.Controls.Add(Me.valFarenheit)
        Me.Controls.Add(Me.valCelsius)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "appMain"
        Me.Opacity = 0.95R
        Me.Text = "Temp Convert"
        Me.TopMost = True
        CType(Me.valCelsius, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valFarenheit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valKelvin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents valCelsius As System.Windows.Forms.NumericUpDown
    Friend WithEvents valFarenheit As System.Windows.Forms.NumericUpDown
    Friend WithEvents queryQuit As System.Windows.Forms.CheckBox
    Friend WithEvents valKelvin As System.Windows.Forms.NumericUpDown
    Friend WithEvents textFarenheit As System.Windows.Forms.Label
    Friend WithEvents textKelvin As System.Windows.Forms.Label
    Friend WithEvents textCelsius As System.Windows.Forms.Label
    Friend WithEvents appTick As System.Windows.Forms.Timer

End Class
