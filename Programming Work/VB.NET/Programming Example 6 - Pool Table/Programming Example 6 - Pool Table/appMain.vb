Imports Microsoft.WindowsAPICodePack.Taskbar
Public Class appMain
    Dim MaxX As Integer
    Dim MaxY As Integer
    Dim XPos As Integer
    Dim YPos As Integer

    Dim IncX As Integer = 8 ' X increment of ball
    Dim IncY As Integer = 8 ' Y increment of ball

    Private Sub appLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        MaxX = pnlTable.Width - picBall.Width - IncX
        MaxY = pnlTable.Height - picBall.Height - IncY
        XPos = picBall.Left
        YPos = picBall.Top
        TaskbarManager.Instance.SetProgressState(2)
        TaskbarManager.Instance.SetProgressValue(1, 1)
    End Sub

    Private Sub queryQuit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles queryQuit.CheckedChanged
        If queryQuit.Checked Then
            Close()
        End If
    End Sub

    Private Sub bntStartPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntStartPosition.Click
        Randomize()
        ' random starting position
        XPos = Rnd() * MaxX
        YPos = Rnd() * MaxY
        ' move ball to(XPos,YPos)
        picBall.Location = New Point(XPos, YPos)
        btnGo.Enabled = True
        TaskbarManager.Instance.SetProgressState(2)
        TaskbarManager.Instance.SetProgressValue(1, 1)
        tmrMove.Stop()
        tmrMove.Interval = 1
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        tmrMove.Start() ' start moving
        btnGo.Enabled = False
    End Sub

    Private Sub tmrMove_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMove.Tick
        TaskbarManager.Instance.SetProgressState(8)
        ' increase X and Y positions
        XPos += IncX
        YPos += IncY
        ' if XPos is out of bounds then reverse increment
        If XPos <= 0 Or XPos >= MaxX Then
            IncX *= -1
        End If
        ' if YPos is out of bounds then reverse increment
        If YPos <= 0 Or YPos >= MaxY Then
            IncY *= -1
        End If
        ' move ball to (XPos ,YPos)

        picBall.Location = New Point(XPos, YPos)
        If queryPhysics.Checked Then
            tmrMove.Interval += 1 ' slow down timer a little
        End If
        TaskbarManager.Instance.SetProgressValue(120 - tmrMove.Interval, 120)
        If tmrMove.Interval >= 120 Then ' slow enough to stop
            TaskbarManager.Instance.SetProgressState(4)
            tmrMove.Stop()
            tmrMove.Interval = 1
        End If
    End Sub

End Class
