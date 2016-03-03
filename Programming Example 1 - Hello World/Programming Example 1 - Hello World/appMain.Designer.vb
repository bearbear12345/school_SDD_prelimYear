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
        Me.TextDisplay = New System.Windows.Forms.TextBox()
        Me.btnHelloWorld = New System.Windows.Forms.RadioButton()
        Me.btnClearText = New System.Windows.Forms.RadioButton()
        Me.appTick = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'queryQuit
        '
        Me.queryQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.queryQuit.AutoSize = True
        Me.queryQuit.Location = New System.Drawing.Point(221, 59)
        Me.queryQuit.Name = "queryQuit"
        Me.queryQuit.Size = New System.Drawing.Size(51, 17)
        Me.queryQuit.TabIndex = 0
        Me.queryQuit.Text = "Quit?"
        Me.queryQuit.UseVisualStyleBackColor = True
        '
        'TextDisplay
        '
        Me.TextDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextDisplay.Location = New System.Drawing.Point(8, 8)
        Me.TextDisplay.Name = "TextDisplay"
        Me.TextDisplay.ReadOnly = True
        Me.TextDisplay.Size = New System.Drawing.Size(251, 20)
        Me.TextDisplay.TabIndex = 1
        '
        'btnHelloWorld
        '
        Me.btnHelloWorld.AutoSize = True
        Me.btnHelloWorld.Location = New System.Drawing.Point(8, 32)
        Me.btnHelloWorld.Name = "btnHelloWorld"
        Me.btnHelloWorld.Size = New System.Drawing.Size(80, 17)
        Me.btnHelloWorld.TabIndex = 2
        Me.btnHelloWorld.TabStop = True
        Me.btnHelloWorld.Text = "Hello World"
        Me.btnHelloWorld.UseVisualStyleBackColor = True
        '
        'btnClearText
        '
        Me.btnClearText.AutoSize = True
        Me.btnClearText.Location = New System.Drawing.Point(8, 56)
        Me.btnClearText.Name = "btnClearText"
        Me.btnClearText.Size = New System.Drawing.Size(59, 17)
        Me.btnClearText.TabIndex = 3
        Me.btnClearText.TabStop = True
        Me.btnClearText.Text = "No text"
        Me.btnClearText.UseVisualStyleBackColor = True
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
        Me.ClientSize = New System.Drawing.Size(271, 81)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClearText)
        Me.Controls.Add(Me.btnHelloWorld)
        Me.Controls.Add(Me.TextDisplay)
        Me.Controls.Add(Me.queryQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "appMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents queryQuit As System.Windows.Forms.CheckBox
    Friend WithEvents TextDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnHelloWorld As System.Windows.Forms.RadioButton
    Friend WithEvents btnClearText As System.Windows.Forms.RadioButton
    Friend WithEvents appTick As System.Windows.Forms.Timer

End Class
