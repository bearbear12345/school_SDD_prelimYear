<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Boggle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boggle))
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
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.shuffleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.userList = New System.Windows.Forms.ListView()
        Me.listWord = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.animation = New System.Windows.Forms.Timer(Me.components)
        Me.menuStrip = New System.Windows.Forms.ToolStrip()
        Me.menuGame = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuGame_options = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGame_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripButton()
        Me.txtMaxScore = New System.Windows.Forms.ToolStripLabel()
        Me.pnlGameboard.SuspendLayout
        Me.menuStrip.SuspendLayout
        Me.SuspendLayout
        '
        'pnlGameboard
        '
        Me.pnlGameboard.BackColor = System.Drawing.Color.Silver
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
        Me.pnlGameboard.Location = New System.Drawing.Point(12, 28)
        Me.pnlGameboard.Name = "pnlGameboard"
        Me.pnlGameboard.Size = New System.Drawing.Size(200, 200)
        Me.pnlGameboard.TabIndex = 17
        '
        'DieB3
        '
        Me.DieB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieB3.Location = New System.Drawing.Point(50, 100)
        Me.DieB3.Name = "DieB3"
        Me.DieB3.Size = New System.Drawing.Size(50, 50)
        Me.DieB3.TabIndex = 34
        Me.DieB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieB3.UseMnemonic = false
        '
        'DieC3
        '
        Me.DieC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieC3.Location = New System.Drawing.Point(100, 100)
        Me.DieC3.Name = "DieC3"
        Me.DieC3.Size = New System.Drawing.Size(50, 50)
        Me.DieC3.TabIndex = 33
        Me.DieC3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieC3.UseMnemonic = false
        '
        'DieD3
        '
        Me.DieD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieD3.Location = New System.Drawing.Point(150, 100)
        Me.DieD3.Name = "DieD3"
        Me.DieD3.Size = New System.Drawing.Size(50, 50)
        Me.DieD3.TabIndex = 32
        Me.DieD3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieD3.UseMnemonic = false
        '
        'DieA3
        '
        Me.DieA3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieA3.Location = New System.Drawing.Point(0, 100)
        Me.DieA3.Name = "DieA3"
        Me.DieA3.Size = New System.Drawing.Size(50, 50)
        Me.DieA3.TabIndex = 31
        Me.DieA3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieA3.UseMnemonic = false
        '
        'DieB4
        '
        Me.DieB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieB4.Location = New System.Drawing.Point(50, 150)
        Me.DieB4.Name = "DieB4"
        Me.DieB4.Size = New System.Drawing.Size(50, 50)
        Me.DieB4.TabIndex = 30
        Me.DieB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieB4.UseMnemonic = false
        '
        'DieC4
        '
        Me.DieC4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieC4.Location = New System.Drawing.Point(100, 150)
        Me.DieC4.Name = "DieC4"
        Me.DieC4.Size = New System.Drawing.Size(50, 50)
        Me.DieC4.TabIndex = 29
        Me.DieC4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieC4.UseMnemonic = false
        '
        'DieD4
        '
        Me.DieD4.BackColor = System.Drawing.Color.Transparent
        Me.DieD4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieD4.Location = New System.Drawing.Point(150, 150)
        Me.DieD4.Name = "DieD4"
        Me.DieD4.Size = New System.Drawing.Size(50, 50)
        Me.DieD4.TabIndex = 28
        Me.DieD4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieD4.UseMnemonic = false
        '
        'DieA4
        '
        Me.DieA4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieA4.Location = New System.Drawing.Point(0, 150)
        Me.DieA4.Name = "DieA4"
        Me.DieA4.Size = New System.Drawing.Size(50, 50)
        Me.DieA4.TabIndex = 27
        Me.DieA4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieA4.UseMnemonic = false
        '
        'DieD2
        '
        Me.DieD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieD2.Location = New System.Drawing.Point(150, 50)
        Me.DieD2.Name = "DieD2"
        Me.DieD2.Size = New System.Drawing.Size(50, 50)
        Me.DieD2.TabIndex = 26
        Me.DieD2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieD2.UseMnemonic = false
        '
        'DieC2
        '
        Me.DieC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieC2.Location = New System.Drawing.Point(100, 50)
        Me.DieC2.Name = "DieC2"
        Me.DieC2.Size = New System.Drawing.Size(50, 50)
        Me.DieC2.TabIndex = 25
        Me.DieC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieC2.UseMnemonic = false
        '
        'DieB2
        '
        Me.DieB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieB2.Location = New System.Drawing.Point(50, 50)
        Me.DieB2.Name = "DieB2"
        Me.DieB2.Size = New System.Drawing.Size(50, 50)
        Me.DieB2.TabIndex = 24
        Me.DieB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieB2.UseMnemonic = false
        '
        'DieA2
        '
        Me.DieA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieA2.Location = New System.Drawing.Point(0, 50)
        Me.DieA2.Name = "DieA2"
        Me.DieA2.Size = New System.Drawing.Size(50, 50)
        Me.DieA2.TabIndex = 23
        Me.DieA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieA2.UseMnemonic = false
        '
        'DieD1
        '
        Me.DieD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieD1.Location = New System.Drawing.Point(150, 0)
        Me.DieD1.Name = "DieD1"
        Me.DieD1.Size = New System.Drawing.Size(50, 50)
        Me.DieD1.TabIndex = 22
        Me.DieD1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieD1.UseMnemonic = false
        '
        'DieC1
        '
        Me.DieC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieC1.Location = New System.Drawing.Point(100, 0)
        Me.DieC1.Name = "DieC1"
        Me.DieC1.Size = New System.Drawing.Size(50, 50)
        Me.DieC1.TabIndex = 21
        Me.DieC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieC1.UseMnemonic = false
        '
        'DieB1
        '
        Me.DieB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieB1.Location = New System.Drawing.Point(50, 0)
        Me.DieB1.Name = "DieB1"
        Me.DieB1.Size = New System.Drawing.Size(50, 50)
        Me.DieB1.TabIndex = 20
        Me.DieB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieB1.UseMnemonic = false
        '
        'DieA1
        '
        Me.DieA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!)
        Me.DieA1.Location = New System.Drawing.Point(0, 0)
        Me.DieA1.Name = "DieA1"
        Me.DieA1.Size = New System.Drawing.Size(50, 50)
        Me.DieA1.TabIndex = 19
        Me.DieA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DieA1.UseMnemonic = false
        '
        'btnMulti
        '
        Me.btnMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnMulti.Location = New System.Drawing.Point(12, 309)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(200, 51)
        Me.btnMulti.TabIndex = 0
        Me.btnMulti.TabStop = false
        Me.btnMulti.Text = "Play!"
        Me.btnMulti.UseVisualStyleBackColor = true
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
        Me.lblTime.Location = New System.Drawing.Point(9, 230)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(75, 17)
        Me.lblTime.TabIndex = 19
        Me.lblTime.Tag = ""
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.LightGray
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInput.Enabled = false
        Me.txtInput.Font = New System.Drawing.Font("Arial Narrow", 25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtInput.Location = New System.Drawing.Point(12, 249)
        Me.txtInput.MaxLength = 16
        Me.txtInput.Multiline = true
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ShortcutsEnabled = false
        Me.txtInput.Size = New System.Drawing.Size(200, 43)
        Me.txtInput.TabIndex = 1
        '
        'userList
        '
        Me.userList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.listWord})
        Me.userList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.userList.LabelWrap = false
        Me.userList.Location = New System.Drawing.Point(234, 28)
        Me.userList.MultiSelect = false
        Me.userList.Name = "userList"
        Me.userList.ShowGroups = false
        Me.userList.Size = New System.Drawing.Size(110, 332)
        Me.userList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.userList.TabIndex = 21
        Me.userList.TabStop = false
        Me.userList.UseCompatibleStateImageBehavior = false
        Me.userList.View = System.Windows.Forms.View.Details
        '
        'listWord
        '
        Me.listWord.Text = "Entered Words"
        Me.listWord.Width = 105
        '
        'animation
        '
        Me.animation.Interval = 200
        '
        'menuStrip
        '
        Me.menuStrip.CanOverflow = false
        Me.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuGame, Me.menuHelp, Me.txtMaxScore})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(354, 25)
        Me.menuStrip.TabIndex = 22
        '
        'menuGame
        '
        Me.menuGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuGame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuGame_options, Me.menuGame_exit})
        Me.menuGame.Image = CType(resources.GetObject("menuGame.Image"),System.Drawing.Image)
        Me.menuGame.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuGame.Name = "menuGame"
        Me.menuGame.Size = New System.Drawing.Size(51, 22)
        Me.menuGame.Text = "Game"
        '
        'menuGame_options
        '
        Me.menuGame_options.Name = "menuGame_options"
        Me.menuGame_options.Size = New System.Drawing.Size(152, 22)
        Me.menuGame_options.Text = "Options"
        '
        'menuGame_exit
        '
        Me.menuGame_exit.Name = "menuGame_exit"
        Me.menuGame_exit.Size = New System.Drawing.Size(152, 22)
        Me.menuGame_exit.Text = "Exit"
        '
        'menuHelp
        '
        Me.menuHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menuHelp.Image = CType(resources.GetObject("menuHelp.Image"),System.Drawing.Image)
        Me.menuHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(36, 22)
        Me.menuHelp.Text = "Help"
        '
        'txtMaxScore
        '
        Me.txtMaxScore.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtMaxScore.Name = "txtMaxScore"
        Me.txtMaxScore.Size = New System.Drawing.Size(136, 22)
        Me.txtMaxScore.Text = "Max Score: Calculating..."
        Me.txtMaxScore.Visible = false
        '
        'Boggle
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(354, 371)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.userList)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.pnlGameboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Boggle"
        Me.Text = "Boggle"
        Me.pnlGameboard.ResumeLayout(false)
        Me.menuStrip.ResumeLayout(false)
        Me.menuStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents pnlGameboard As Panel
    Friend WithEvents btnMulti As Button
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
    Friend WithEvents userList As ListView
    Friend WithEvents listWord As ColumnHeader
    Friend WithEvents animation As Timer
    Friend WithEvents menuStrip As ToolStrip
    Friend WithEvents menuGame As ToolStripDropDownButton
    Friend WithEvents menuGame_options As ToolStripMenuItem
    Friend WithEvents menuGame_exit As ToolStripMenuItem
    Friend WithEvents menuHelp As ToolStripButton
    Friend WithEvents txtMaxScore As ToolStripLabel
End Class
