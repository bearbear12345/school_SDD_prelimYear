<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boggle_options
    Inherits System.Windows.Forms.Form

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ctrlTime = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(179, 60)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(98, 60)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        '
        'ctrlTime
        '
        Me.ctrlTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctrlTime.FormattingEnabled = true
        Me.ctrlTime.Location = New System.Drawing.Point(97, 16)
        Me.ctrlTime.Name = "ctrlTime"
        Me.ctrlTime.Size = New System.Drawing.Size(156, 21)
        Me.ctrlTime.TabIndex = 3
        '
        'lblTime
        '
        Me.lblTime.AutoSize = true
        Me.lblTime.Location = New System.Drawing.Point(13, 19)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(78, 13)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Game Duration"
        '
        'Boggle_options
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(266, 95)
        Me.ControlBox = false
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.ctrlTime)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Boggle_options"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = false
        Me.Text = "Game Options"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ctrlTime As ComboBox
    Friend WithEvents lblTime As Label
End Class
