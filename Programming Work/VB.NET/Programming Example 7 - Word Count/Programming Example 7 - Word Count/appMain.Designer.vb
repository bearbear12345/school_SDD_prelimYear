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
        Me.lblInfoText = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtEntry = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'queryQuit
        '
        Me.queryQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.queryQuit.AutoSize = True
        Me.queryQuit.Location = New System.Drawing.Point(276, 179)
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
        'lblInfoText
        '
        Me.lblInfoText.AutoSize = True
        Me.lblInfoText.Location = New System.Drawing.Point(12, 9)
        Me.lblInfoText.Name = "lblInfoText"
        Me.lblInfoText.Size = New System.Drawing.Size(169, 13)
        Me.lblInfoText.TabIndex = 1
        Me.lblInfoText.Text = "Enter some text in the box below..."
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCount.Location = New System.Drawing.Point(15, 207)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(99, 17)
        Me.lblCount.TabIndex = 2
        Me.lblCount.Text = "Word Count: 0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(18, 175)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtEntry
        '
        Me.txtEntry.AcceptsTab = True
        Me.txtEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEntry.Location = New System.Drawing.Point(15, 25)
        Me.txtEntry.Multiline = True
        Me.txtEntry.Name = "txtEntry"
        Me.txtEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEntry.Size = New System.Drawing.Size(312, 144)
        Me.txtEntry.TabIndex = 0
        '
        'appMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtEntry)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblInfoText)
        Me.Controls.Add(Me.queryQuit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(358, 279)
        Me.Name = "appMain"
        Me.Opacity = 0.95R
        Me.Text = "Word Count"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents queryQuit As System.Windows.Forms.CheckBox
    Friend WithEvents appTick As System.Windows.Forms.Timer
    Friend WithEvents lblInfoText As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtEntry As System.Windows.Forms.TextBox

End Class
