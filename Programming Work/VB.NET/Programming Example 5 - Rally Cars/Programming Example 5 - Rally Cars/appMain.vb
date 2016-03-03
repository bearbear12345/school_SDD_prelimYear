Imports Microsoft.WindowsAPICodePack.Taskbar
Public Class appMain

    ' START Settings '
    Dim optLaps = 5 ' How many laps do the cars race for (optLaps > 0)
    Dim optPixelMovement = 8 ' How far does the car move at a time (optPixelMovement > 0)
    Dim optGameSpeed = 10 ' How fast does the car move (optGameSpeed > 0)
    ' END Settings '



































    Dim progGreen
    Dim progRed
    Dim origGreen
    Dim origRed

    Private Sub Reset()
        progGreen = 0
        progRed = 0

        lblRedLaps.Text = optLaps
        lblGreenLaps.Text = optLaps ' reset lap count

        picGreenCar.Left = origGreen
        picRedCar.Left = origRed

        btnStart.Enabled = True
        firstState.Start()
    End Sub

    Private Sub tmrRace_Tick(ByVal sender As System.Object, ByVal e As _
System.EventArgs) Handles tmrRace.Tick
        Dim WhichCar As Integer
        Randomize()
        WhichCar = Int(Rnd() * 2) ' 0 or 1
        If WhichCar = 0 Then
            picRedCar.Left -= optPixelMovement
            progRed += optPixelMovement
            If picRedCar.Left <= -picRedCar.Width Then
                picRedCar.Left = Me.Width ' start next lap
                lblRedLaps.Text -= 1 ' reduce lap count
                If lblRedLaps.Text = 0 Then
                    tmrRace.Stop() ' stop race

                    TaskbarManager.Instance.SetProgressState(4)
                    TaskbarManager.Instance.SetProgressValue(1, 1)
                    MessageBox.Show("Red wins!", "Rally cars",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Reset()
                End If
            End If
        Else ' WhichCar = 1
            picGreenCar.Left -= optPixelMovement
            progGreen += optPixelMovement
            If picGreenCar.Left <= -picGreenCar.Width Then
                picGreenCar.Left = Me.Width ' start next lap
                lblGreenLaps.Text -= 1 ' reduce lap count
                If lblGreenLaps.Text = 0 Then
                    tmrRace.Stop() ' stop race

                    TaskbarManager.Instance.SetProgressState(2)
                    TaskbarManager.Instance.SetProgressValue(1, 1)
                    MessageBox.Show("Green wins!", "Rally cars",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Reset()
                End If
            End If
        End If
        If progGreen > progRed Then
            TaskbarManager.Instance.SetProgressState(2)
            TaskbarManager.Instance.SetProgressValue(progGreen, (optLaps - 1) * (Me.Width + picGreenCar.Width) + origGreen)
        Else
            TaskbarManager.Instance.SetProgressState(4)
            TaskbarManager.Instance.SetProgressValue(progRed, (optLaps - 1) * (Me.Width + picRedCar.Width) + origRed)
        End If
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        tmrRace.Start() ' start race

        btnStart.Enabled = False
    End Sub

    Private Sub queryQuit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles queryQuit.CheckedChanged
        If queryQuit.Checked Then
            Close()
        End If
    End Sub

    Private Sub appMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        VgameSpeed.Value = optGameSpeed
        tmrRace.Interval = optGameSpeed
        origGreen = picGreenCar.Left
        origRed = picRedCar.Left
        Reset()
    End Sub

    Private Sub firstState_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles firstState.Tick
        ' Makes progress bar 100% yellow
        TaskbarManager.Instance.SetProgressState(8)
        TaskbarManager.Instance.SetProgressValue(1, 1)
        firstState.Stop()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        tmrRace.Stop()
        Reset()
    End Sub

    Private Sub VgameSpeed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VgameSpeed.Scroll
        tmrRace.Interval = VgameSpeed.Value
    End Sub
End Class
