<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppMain))
        Me.lstLetters = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlGameboard = New System.Windows.Forms.Panel()
        Me.DieB3 = New System.Windows.Forms.Label()
        Me.DieC3 = New System.Windows.Forms.Label()
        Me.DieD3 = New System.Windows.Forms.Label()
        Me.DieA3 = New System.Windows.Forms.Label()
        Me.DieB4 = New System.Windows.Forms.Label()
        Me.DieC4 = New System.Windows.Forms.Label()
        Me.DieD4 = New System.Windows.Forms.Label()
        Me.DieA4 = New System.Windows.Forms.Label()
        Me.DieD2 = New System.Windows.Forms.Label()
        Me.DieC2 = New System.Windows.Forms.Label()
        Me.DieB2 = New System.Windows.Forms.Label()
        Me.DieA2 = New System.Windows.Forms.Label()
        Me.DieD1 = New System.Windows.Forms.Label()
        Me.DieC1 = New System.Windows.Forms.Label()
        Me.DieB1 = New System.Windows.Forms.Label()
        Me.DieA1 = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.shuffleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.InfoTip = New System.Windows.Forms.Label()
        Me.pnlGameboard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstLetters
        '
        Me.lstLetters.ImageStream = CType(resources.GetObject("lstLetters.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstLetters.TransparentColor = System.Drawing.Color.Transparent
        Me.lstLetters.Images.SetKeyName(0, "A.jpg")
        Me.lstLetters.Images.SetKeyName(1, "B.jpg")
        Me.lstLetters.Images.SetKeyName(2, "C.jpg")
        Me.lstLetters.Images.SetKeyName(3, "D.jpg")
        Me.lstLetters.Images.SetKeyName(4, "E.jpg")
        Me.lstLetters.Images.SetKeyName(5, "F.jpg")
        Me.lstLetters.Images.SetKeyName(6, "G.jpg")
        Me.lstLetters.Images.SetKeyName(7, "H.jpg")
        Me.lstLetters.Images.SetKeyName(8, "I.jpg")
        Me.lstLetters.Images.SetKeyName(9, "J.jpg")
        Me.lstLetters.Images.SetKeyName(10, "K.jpg")
        Me.lstLetters.Images.SetKeyName(11, "L.jpg")
        Me.lstLetters.Images.SetKeyName(12, "M.jpg")
        Me.lstLetters.Images.SetKeyName(13, "N.jpg")
        Me.lstLetters.Images.SetKeyName(14, "O.jpg")
        Me.lstLetters.Images.SetKeyName(15, "P.jpg")
        Me.lstLetters.Images.SetKeyName(16, "Q.jpg")
        Me.lstLetters.Images.SetKeyName(17, "R.jpg")
        Me.lstLetters.Images.SetKeyName(18, "S.jpg")
        Me.lstLetters.Images.SetKeyName(19, "T.jpg")
        Me.lstLetters.Images.SetKeyName(20, "U.jpg")
        Me.lstLetters.Images.SetKeyName(21, "V.jpg")
        Me.lstLetters.Images.SetKeyName(22, "W.jpg")
        Me.lstLetters.Images.SetKeyName(23, "X.jpg")
        Me.lstLetters.Images.SetKeyName(24, "Y.jpg")
        Me.lstLetters.Images.SetKeyName(25, "Z.jpg")
        Me.lstLetters.Images.SetKeyName(26, "Qu.jpg")
        '
        'pnlGameboard
        '
        Me.pnlGameboard.Controls.Add(Me.DieB3)
        Me.pnlGameboard.Controls.Add(Me.DieC3)
        Me.pnlGameboard.Controls.Add(Me.DieD3)
        Me.pnlGameboard.Controls.Add(Me.DieA3)
        Me.pnlGameboard.Controls.Add(Me.DieB4)
        Me.pnlGameboard.Controls.Add(Me.DieC4)
        Me.pnlGameboard.Controls.Add(Me.DieD4)
        Me.pnlGameboard.Controls.Add(Me.DieA4)
        Me.pnlGameboard.Controls.Add(Me.DieD2)
        Me.pnlGameboard.Controls.Add(Me.DieC2)
        Me.pnlGameboard.Controls.Add(Me.DieB2)
        Me.pnlGameboard.Controls.Add(Me.DieA2)
        Me.pnlGameboard.Controls.Add(Me.DieD1)
        Me.pnlGameboard.Controls.Add(Me.DieC1)
        Me.pnlGameboard.Controls.Add(Me.DieB1)
        Me.pnlGameboard.Controls.Add(Me.DieA1)
        Me.pnlGameboard.Location = New System.Drawing.Point(12, 12)
        Me.pnlGameboard.Name = "pnlGameboard"
        Me.pnlGameboard.Size = New System.Drawing.Size(200, 200)
        Me.pnlGameboard.TabIndex = 17
        '
        'DieB3
        '
        Me.DieB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieB3.Location = New System.Drawing.Point(50, 100)
        Me.DieB3.Name = "DieB3"
        Me.DieB3.Size = New System.Drawing.Size(50, 50)
        Me.DieB3.TabIndex = 34
        Me.DieB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieB3.UseMnemonic = False
        '
        'DieC3
        '
        Me.DieC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieC3.Location = New System.Drawing.Point(100, 100)
        Me.DieC3.Name = "DieC3"
        Me.DieC3.Size = New System.Drawing.Size(50, 50)
        Me.DieC3.TabIndex = 33
        Me.DieC3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieC3.UseMnemonic = False
        '
        'DieD3
        '
        Me.DieD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieD3.Location = New System.Drawing.Point(150, 100)
        Me.DieD3.Name = "DieD3"
        Me.DieD3.Size = New System.Drawing.Size(50, 50)
        Me.DieD3.TabIndex = 32
        Me.DieD3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieD3.UseMnemonic = False
        '
        'DieA3
        '
        Me.DieA3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieA3.Location = New System.Drawing.Point(0, 100)
        Me.DieA3.Name = "DieA3"
        Me.DieA3.Size = New System.Drawing.Size(50, 50)
        Me.DieA3.TabIndex = 31
        Me.DieA3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieA3.UseMnemonic = False
        '
        'DieB4
        '
        Me.DieB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieB4.Location = New System.Drawing.Point(50, 150)
        Me.DieB4.Name = "DieB4"
        Me.DieB4.Size = New System.Drawing.Size(50, 50)
        Me.DieB4.TabIndex = 30
        Me.DieB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieB4.UseMnemonic = False
        '
        'DieC4
        '
        Me.DieC4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieC4.Location = New System.Drawing.Point(100, 150)
        Me.DieC4.Name = "DieC4"
        Me.DieC4.Size = New System.Drawing.Size(50, 50)
        Me.DieC4.TabIndex = 29
        Me.DieC4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieC4.UseMnemonic = False
        '
        'DieD4
        '
        Me.DieD4.BackColor = System.Drawing.Color.Transparent
        Me.DieD4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieD4.Location = New System.Drawing.Point(150, 150)
        Me.DieD4.Name = "DieD4"
        Me.DieD4.Size = New System.Drawing.Size(50, 50)
        Me.DieD4.TabIndex = 28
        Me.DieD4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieD4.UseMnemonic = False
        '
        'DieA4
        '
        Me.DieA4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieA4.Location = New System.Drawing.Point(0, 150)
        Me.DieA4.Name = "DieA4"
        Me.DieA4.Size = New System.Drawing.Size(50, 50)
        Me.DieA4.TabIndex = 27
        Me.DieA4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieA4.UseMnemonic = False
        '
        'DieD2
        '
        Me.DieD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieD2.Location = New System.Drawing.Point(150, 50)
        Me.DieD2.Name = "DieD2"
        Me.DieD2.Size = New System.Drawing.Size(50, 50)
        Me.DieD2.TabIndex = 26
        Me.DieD2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieD2.UseMnemonic = False
        '
        'DieC2
        '
        Me.DieC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieC2.Location = New System.Drawing.Point(100, 50)
        Me.DieC2.Name = "DieC2"
        Me.DieC2.Size = New System.Drawing.Size(50, 50)
        Me.DieC2.TabIndex = 25
        Me.DieC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieC2.UseMnemonic = False
        '
        'DieB2
        '
        Me.DieB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieB2.Location = New System.Drawing.Point(50, 50)
        Me.DieB2.Name = "DieB2"
        Me.DieB2.Size = New System.Drawing.Size(50, 50)
        Me.DieB2.TabIndex = 24
        Me.DieB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieB2.UseMnemonic = False
        '
        'DieA2
        '
        Me.DieA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieA2.Location = New System.Drawing.Point(0, 50)
        Me.DieA2.Name = "DieA2"
        Me.DieA2.Size = New System.Drawing.Size(50, 50)
        Me.DieA2.TabIndex = 23
        Me.DieA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieA2.UseMnemonic = False
        '
        'DieD1
        '
        Me.DieD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieD1.Location = New System.Drawing.Point(150, 0)
        Me.DieD1.Name = "DieD1"
        Me.DieD1.Size = New System.Drawing.Size(50, 50)
        Me.DieD1.TabIndex = 22
        Me.DieD1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieD1.UseMnemonic = False
        '
        'DieC1
        '
        Me.DieC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieC1.Location = New System.Drawing.Point(100, 0)
        Me.DieC1.Name = "DieC1"
        Me.DieC1.Size = New System.Drawing.Size(50, 50)
        Me.DieC1.TabIndex = 21
        Me.DieC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieC1.UseMnemonic = False
        '
        'DieB1
        '
        Me.DieB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieB1.Location = New System.Drawing.Point(50, 0)
        Me.DieB1.Name = "DieB1"
        Me.DieB1.Size = New System.Drawing.Size(50, 50)
        Me.DieB1.TabIndex = 20
        Me.DieB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieB1.UseMnemonic = False
        '
        'DieA1
        '
        Me.DieA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.DieA1.Location = New System.Drawing.Point(0, 0)
        Me.DieA1.Name = "DieA1"
        Me.DieA1.Size = New System.Drawing.Size(50, 50)
        Me.DieA1.TabIndex = 19
        Me.DieA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieA1.UseMnemonic = False
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(271, 247)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.TabStop = False
        Me.btnPlay.Text = "&Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'shuffleTimer
        '
        Me.shuffleTimer.Interval = 25
        Me.shuffleTimer.Tag = ""
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 1000
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(250, 37)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 13)
        Me.lblTime.TabIndex = 19
        Me.lblTime.Tag = ""
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.SystemColors.Control
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInput.Enabled = False
        Me.txtInput.Font = New System.Drawing.Font("Arial Narrow", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(18, 227)
        Me.txtInput.MaxLength = 16
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ShortcutsEnabled = False
        Me.txtInput.Size = New System.Drawing.Size(247, 43)
        Me.txtInput.TabIndex = 1
        '
        'InfoTip
        '
        Me.InfoTip.Location = New System.Drawing.Point(12, 12)
        Me.InfoTip.Name = "InfoTip"
        Me.InfoTip.Size = New System.Drawing.Size(334, 232)
        Me.InfoTip.TabIndex = 20
        Me.InfoTip.Text = resources.GetString("InfoTip.Text")
        Me.InfoTip.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AppMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(358, 282)
        Me.Controls.Add(Me.InfoTip)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.pnlGameboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AppMain"
        Me.Opacity = 0.95R
        Me.Text = "Boggle"
        Me.pnlGameboard.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLetters As System.Windows.Forms.ImageList
    Friend WithEvents pnlGameboard As Panel
    Friend WithEvents btnPlay As Button
    Friend WithEvents DieD1 As System.Windows.Forms.Label
    Friend WithEvents DieC1 As System.Windows.Forms.Label
    Friend WithEvents DieB1 As System.Windows.Forms.Label
    Friend WithEvents DieA1 As System.Windows.Forms.Label
    Friend WithEvents DieB3 As System.Windows.Forms.Label
    Friend WithEvents DieC3 As System.Windows.Forms.Label
    Friend WithEvents DieD3 As System.Windows.Forms.Label
    Friend WithEvents DieA3 As System.Windows.Forms.Label
    Friend WithEvents DieB4 As System.Windows.Forms.Label
    Friend WithEvents DieC4 As System.Windows.Forms.Label
    Friend WithEvents DieD4 As System.Windows.Forms.Label
    Friend WithEvents DieA4 As System.Windows.Forms.Label
    Friend WithEvents DieD2 As System.Windows.Forms.Label
    Friend WithEvents DieC2 As System.Windows.Forms.Label
    Friend WithEvents DieB2 As System.Windows.Forms.Label
    Friend WithEvents DieA2 As System.Windows.Forms.Label
    Friend WithEvents shuffleTimer As System.Windows.Forms.Timer
    Friend WithEvents GameTimer As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents InfoTip As System.Windows.Forms.Label
End Class
