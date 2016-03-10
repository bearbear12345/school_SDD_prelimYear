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
        Me.pnlTable = New System.Windows.Forms.Panel()
        Me.picBall = New System.Windows.Forms.PictureBox()
        Me.bntStartPosition = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.tmrMove = New System.Windows.Forms.Timer(Me.components)
        Me.queryPhysics = New System.Windows.Forms.CheckBox()
        Me.pnlTable.SuspendLayout()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'queryQuit
        '
        Me.queryQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.queryQuit.AutoSize = True
        Me.queryQuit.Location = New System.Drawing.Point(263, 210)
        Me.queryQuit.Name = "queryQuit"
        Me.queryQuit.Size = New System.Drawing.Size(51, 17)
        Me.queryQuit.TabIndex = 0
        Me.queryQuit.Text = "Quit?"
        Me.queryQuit.UseVisualStyleBackColor = True
        '
        'pnlTable
        '
        Me.pnlTable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlTable.BackColor = System.Drawing.Color.Green
        Me.pnlTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTable.Controls.Add(Me.picBall)
        Me.pnlTable.Location = New System.Drawing.Point(12, 48)
        Me.pnlTable.Name = "pnlTable"
        Me.pnlTable.Size = New System.Drawing.Size(300, 150)
        Me.pnlTable.TabIndex = 1
        '
        'picBall
        '
        Me.picBall.Image = Global.PoolTable.My.Resources.Resources.redball
        Me.picBall.Location = New System.Drawing.Point(139, 85)
        Me.picBall.Name = "picBall"
        Me.picBall.Size = New System.Drawing.Size(15, 15)
        Me.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBall.TabIndex = 0
        Me.picBall.TabStop = False
        '
        'bntStartPosition
        '
        Me.bntStartPosition.Location = New System.Drawing.Point(12, 12)
        Me.bntStartPosition.Name = "bntStartPosition"
        Me.bntStartPosition.Size = New System.Drawing.Size(75, 23)
        Me.bntStartPosition.TabIndex = 2
        Me.bntStartPosition.Text = "&Start Position"
        Me.bntStartPosition.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(237, 12)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "&Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'tmrMove
        '
        Me.tmrMove.Interval = 3
        '
        'queryPhysics
        '
        Me.queryPhysics.AutoSize = True
        Me.queryPhysics.Checked = True
        Me.queryPhysics.CheckState = System.Windows.Forms.CheckState.Checked
        Me.queryPhysics.Location = New System.Drawing.Point(12, 210)
        Me.queryPhysics.Name = "queryPhysics"
        Me.queryPhysics.Size = New System.Drawing.Size(62, 17)
        Me.queryPhysics.TabIndex = 4
        Me.queryPhysics.Text = "Physics"
        Me.queryPhysics.UseVisualStyleBackColor = True
        '
        'appMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.queryPhysics)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.bntStartPosition)
        Me.Controls.Add(Me.pnlTable)
        Me.Controls.Add(Me.queryQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "appMain"
        Me.Text = "Pool Table"
        Me.pnlTable.ResumeLayout(False)
        Me.pnlTable.PerformLayout()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents queryQuit As System.Windows.Forms.CheckBox
    Friend WithEvents pnlTable As System.Windows.Forms.Panel
    Friend WithEvents picBall As System.Windows.Forms.PictureBox
    Friend WithEvents bntStartPosition As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents tmrMove As System.Windows.Forms.Timer
    Friend WithEvents queryPhysics As System.Windows.Forms.CheckBox

End Class
