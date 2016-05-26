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
        Me.queryQuit = New System.Windows.Forms.CheckBox()
        Me.appTick = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDice = New System.Windows.Forms.Timer(Me.components)
        Me.imgDice = New System.Windows.Forms.PictureBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        CType(Me.imgDice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'queryQuit
        '
        Me.queryQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.queryQuit.AutoSize = True
        Me.queryQuit.Location = New System.Drawing.Point(52, 135)
        Me.queryQuit.Name = "queryQuit"
        Me.queryQuit.Size = New System.Drawing.Size(51, 17)
        Me.queryQuit.TabIndex = 0
        Me.queryQuit.Text = "Quit?"
        Me.queryQuit.UseVisualStyleBackColor = True
        '
        'appTick
        '
        Me.appTick.Enabled = True
        Me.appTick.Interval = 50
        '
        'tmrDice
        '
        Me.tmrDice.Interval = 80
        '
        'imgDice
        '
        Me.imgDice.BackColor = System.Drawing.Color.White
        Me.imgDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgDice.Location = New System.Drawing.Point(12, 12)
        Me.imgDice.Name = "imgDice"
        Me.imgDice.Size = New System.Drawing.Size(82, 82)
        Me.imgDice.TabIndex = 1
        Me.imgDice.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(12, 100)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(82, 23)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "Roll Dice"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'appMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(105, 154)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.imgDice)
        Me.Controls.Add(Me.queryQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "appMain"
        Me.Opacity = 0.95R
        Me.Text = "Rolling Dice"
        CType(Me.imgDice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents queryQuit As System.Windows.Forms.CheckBox
    Friend WithEvents appTick As System.Windows.Forms.Timer
    Friend WithEvents tmrDice As System.Windows.Forms.Timer
    Friend WithEvents imgDice As System.Windows.Forms.PictureBox
    Friend WithEvents btnRoll As System.Windows.Forms.Button

End Class
