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
        Me.tmrRun = New System.Windows.Forms.Timer(Me.components)
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.trbSpeed = New System.Windows.Forms.TrackBar()
        Me.imlWolves = New System.Windows.Forms.ImageList(Me.components)
        Me.imgPlant2 = New System.Windows.Forms.PictureBox()
        Me.imgPlant3 = New System.Windows.Forms.PictureBox()
        Me.picWolf = New System.Windows.Forms.PictureBox()
        Me.imgPlant1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.trbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPlant2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPlant3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWolf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPlant1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'queryQuit
        '
        Me.queryQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.queryQuit.AutoSize = True
        Me.queryQuit.Location = New System.Drawing.Point(644, 252)
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
        'tmrRun
        '
        Me.tmrRun.Interval = 210
        '
        'btnStop
        '
        Me.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnStop.Location = New System.Drawing.Point(22, 204)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "&Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRun.Location = New System.Drawing.Point(22, 176)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 2
        Me.btnRun.Text = "&Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'lblSpeed
        '
        Me.lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(43, 237)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(38, 13)
        Me.lblSpeed.TabIndex = 3
        Me.lblSpeed.Text = "Speed"
        '
        'trbSpeed
        '
        Me.trbSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.trbSpeed.Location = New System.Drawing.Point(9, 253)
        Me.trbSpeed.Maximum = 20
        Me.trbSpeed.Name = "trbSpeed"
        Me.trbSpeed.Size = New System.Drawing.Size(104, 45)
        Me.trbSpeed.TabIndex = 4
        Me.trbSpeed.Value = 15
        '
        'imlWolves
        '
        Me.imlWolves.ImageStream = CType(resources.GetObject("imlWolves.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlWolves.TransparentColor = System.Drawing.Color.Transparent
        Me.imlWolves.Images.SetKeyName(0, "wolf running 0.gif")
        Me.imlWolves.Images.SetKeyName(1, "wolf running 1.gif")
        Me.imlWolves.Images.SetKeyName(2, "wolf running 2.gif")
        Me.imlWolves.Images.SetKeyName(3, "wolf running 3.gif")
        Me.imlWolves.Images.SetKeyName(4, "wolf running 4.gif")
        Me.imlWolves.Images.SetKeyName(5, "wolf running 5.gif")
        Me.imlWolves.Images.SetKeyName(6, "wolf running 6.gif")
        Me.imlWolves.Images.SetKeyName(7, "wolf running 7.gif")
        '
        'imgPlant2
        '
        Me.imgPlant2.BackColor = System.Drawing.Color.Transparent
        Me.imgPlant2.Image = CType(resources.GetObject("imgPlant2.Image"), System.Drawing.Image)
        Me.imgPlant2.Location = New System.Drawing.Point(159, 121)
        Me.imgPlant2.Name = "imgPlant2"
        Me.imgPlant2.Size = New System.Drawing.Size(64, 64)
        Me.imgPlant2.TabIndex = 9
        Me.imgPlant2.TabStop = False
        '
        'imgPlant3
        '
        Me.imgPlant3.BackColor = System.Drawing.Color.Transparent
        Me.imgPlant3.Image = CType(resources.GetObject("imgPlant3.Image"), System.Drawing.Image)
        Me.imgPlant3.Location = New System.Drawing.Point(247, 12)
        Me.imgPlant3.Name = "imgPlant3"
        Me.imgPlant3.Size = New System.Drawing.Size(64, 64)
        Me.imgPlant3.TabIndex = 11
        Me.imgPlant3.TabStop = False
        '
        'picWolf
        '
        Me.picWolf.BackColor = System.Drawing.Color.Transparent
        Me.picWolf.BackgroundImage = CType(resources.GetObject("picWolf.BackgroundImage"), System.Drawing.Image)
        Me.picWolf.Location = New System.Drawing.Point(79, 76)
        Me.picWolf.Name = "picWolf"
        Me.picWolf.Size = New System.Drawing.Size(84, 46)
        Me.picWolf.TabIndex = 12
        Me.picWolf.TabStop = False
        '
        'imgPlant1
        '
        Me.imgPlant1.BackColor = System.Drawing.Color.Transparent
        Me.imgPlant1.Image = CType(resources.GetObject("imgPlant1.Image"), System.Drawing.Image)
        Me.imgPlant1.Location = New System.Drawing.Point(46, 12)
        Me.imgPlant1.Name = "imgPlant1"
        Me.imgPlant1.Size = New System.Drawing.Size(64, 64)
        Me.imgPlant1.TabIndex = 10
        Me.imgPlant1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(327, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(415, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(498, 121)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(593, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'appMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(707, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picWolf)
        Me.Controls.Add(Me.trbSpeed)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.queryQuit)
        Me.Controls.Add(Me.imgPlant1)
        Me.Controls.Add(Me.imgPlant2)
        Me.Controls.Add(Me.imgPlant3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "appMain"
        Me.Opacity = 0.95R
        Me.Text = "Running Wolf"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.trbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPlant2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPlant3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWolf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPlant1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents queryQuit As System.Windows.Forms.CheckBox
    Friend WithEvents appTick As System.Windows.Forms.Timer
    Friend WithEvents tmrRun As System.Windows.Forms.Timer
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents trbSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents imlWolves As System.Windows.Forms.ImageList
    Friend WithEvents imgPlant2 As System.Windows.Forms.PictureBox
    Friend WithEvents picWolf As System.Windows.Forms.PictureBox
    Friend WithEvents imgPlant3 As System.Windows.Forms.PictureBox
    Friend WithEvents imgPlant1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox

End Class
