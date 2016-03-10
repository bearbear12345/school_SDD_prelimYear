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
        Me.picGreenCar = New System.Windows.Forms.PictureBox()
        Me.picRedCar = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.strLaps = New System.Windows.Forms.Label()
        Me.lblGreenLaps = New System.Windows.Forms.Label()
        Me.tmrRace = New System.Windows.Forms.Timer(Me.components)
        Me.lblRedLaps = New System.Windows.Forms.Label()
        Me.queryQuit = New System.Windows.Forms.CheckBox()
        Me.firstState = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.VgameSpeed = New System.Windows.Forms.TrackBar()
        Me.txtGameSpeed = New System.Windows.Forms.Label()
        CType(Me.picGreenCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRedCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VgameSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGreenCar
        '
        Me.picGreenCar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picGreenCar.BackColor = System.Drawing.Color.Transparent
        Me.picGreenCar.Image = Global.RallyCars.My.Resources.Resources.green_rally_car
        Me.picGreenCar.Location = New System.Drawing.Point(365, 8)
        Me.picGreenCar.Name = "picGreenCar"
        Me.picGreenCar.Size = New System.Drawing.Size(82, 44)
        Me.picGreenCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGreenCar.TabIndex = 0
        Me.picGreenCar.TabStop = False
        '
        'picRedCar
        '
        Me.picRedCar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picRedCar.BackColor = System.Drawing.Color.Transparent
        Me.picRedCar.Image = CType(resources.GetObject("picRedCar.Image"), System.Drawing.Image)
        Me.picRedCar.Location = New System.Drawing.Point(365, 145)
        Me.picRedCar.Name = "picRedCar"
        Me.picRedCar.Size = New System.Drawing.Size(82, 44)
        Me.picRedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRedCar.TabIndex = 1
        Me.picRedCar.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(365, 213)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(52, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'strLaps
        '
        Me.strLaps.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.strLaps.AutoSize = True
        Me.strLaps.Location = New System.Drawing.Point(387, 94)
        Me.strLaps.Name = "strLaps"
        Me.strLaps.Size = New System.Drawing.Size(57, 13)
        Me.strLaps.TabIndex = 4
        Me.strLaps.Text = "Laps to go"
        '
        'lblGreenLaps
        '
        Me.lblGreenLaps.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblGreenLaps.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblGreenLaps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreenLaps.ForeColor = System.Drawing.Color.White
        Me.lblGreenLaps.Location = New System.Drawing.Point(394, 69)
        Me.lblGreenLaps.Name = "lblGreenLaps"
        Me.lblGreenLaps.Size = New System.Drawing.Size(41, 23)
        Me.lblGreenLaps.TabIndex = 5
        Me.lblGreenLaps.Text = "5"
        Me.lblGreenLaps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrRace
        '
        Me.tmrRace.Interval = 1
        '
        'lblRedLaps
        '
        Me.lblRedLaps.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRedLaps.BackColor = System.Drawing.Color.PaleVioletRed
        Me.lblRedLaps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRedLaps.ForeColor = System.Drawing.Color.White
        Me.lblRedLaps.Location = New System.Drawing.Point(394, 110)
        Me.lblRedLaps.Name = "lblRedLaps"
        Me.lblRedLaps.Size = New System.Drawing.Size(41, 23)
        Me.lblRedLaps.TabIndex = 6
        Me.lblRedLaps.Text = "5"
        Me.lblRedLaps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'queryQuit
        '
        Me.queryQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.queryQuit.AutoSize = True
        Me.queryQuit.Location = New System.Drawing.Point(423, 217)
        Me.queryQuit.Name = "queryQuit"
        Me.queryQuit.Size = New System.Drawing.Size(51, 17)
        Me.queryQuit.TabIndex = 7
        Me.queryQuit.Text = "Quit?"
        Me.queryQuit.UseVisualStyleBackColor = True
        '
        'firstState
        '
        Me.firstState.Enabled = True
        Me.firstState.Interval = 1
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(307, 213)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(52, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'VgameSpeed
        '
        Me.VgameSpeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VgameSpeed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VgameSpeed.Location = New System.Drawing.Point(12, 215)
        Me.VgameSpeed.Maximum = 100
        Me.VgameSpeed.Minimum = 1
        Me.VgameSpeed.Name = "VgameSpeed"
        Me.VgameSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.VgameSpeed.Size = New System.Drawing.Size(287, 45)
        Me.VgameSpeed.TabIndex = 9
        Me.VgameSpeed.Value = 1
        '
        'txtGameSpeed
        '
        Me.txtGameSpeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGameSpeed.AutoSize = True
        Me.txtGameSpeed.Location = New System.Drawing.Point(120, 199)
        Me.txtGameSpeed.Name = "txtGameSpeed"
        Me.txtGameSpeed.Size = New System.Drawing.Size(69, 13)
        Me.txtGameSpeed.TabIndex = 10
        Me.txtGameSpeed.Text = "Game Speed"
        '
        'appMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtGameSpeed)
        Me.Controls.Add(Me.VgameSpeed)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.queryQuit)
        Me.Controls.Add(Me.lblRedLaps)
        Me.Controls.Add(Me.lblGreenLaps)
        Me.Controls.Add(Me.strLaps)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picRedCar)
        Me.Controls.Add(Me.picGreenCar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(493, 275)
        Me.Name = "appMain"
        Me.Text = "Rally Cars"
        CType(Me.picGreenCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRedCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VgameSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGreenCar As PictureBox
    Friend WithEvents picRedCar As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents strLaps As Label
    Friend WithEvents lblGreenLaps As Label
    Friend WithEvents tmrRace As Timer
    Friend WithEvents lblRedLaps As Label
    Friend WithEvents queryQuit As CheckBox
    Friend WithEvents firstState As Timer
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents VgameSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents txtGameSpeed As System.Windows.Forms.Label
End Class
