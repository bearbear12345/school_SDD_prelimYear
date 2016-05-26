Imports Microsoft.WindowsAPICodePack.Taskbar
Public Class appMain

    Private Sub applicationTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appTick.Tick
        TaskbarManager.Instance.SetProgressState({2, 4, 8}(New Random().Next(3)))
        TaskbarManager.Instance.SetProgressValue(Int(Rnd() * 100), 100)
    End Sub

    Private Sub appLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        trbSpeed_Scroll()
    End Sub

    Private Sub queryQuit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles queryQuit.CheckedChanged
        If queryQuit.Checked Then
            Close()
        End If
    End Sub

    Private Sub tmrRun_Tick(sender As Object, e As EventArgs) Handles tmrRun.Tick
        Static WhichPos As Integer = 0
        WhichPos += 1
        WhichPos = WhichPos Mod 8
        picWolf.Image = imlWolves.Images.Item(WhichPos)
        picWolf.Left += 10
        If picWolf.Left >= Me.Width Then
            picWolf.Left = -picWolf.Width
        End If
    End Sub

    Private Sub trbSpeed_Scroll() Handles trbSpeed.Scroll
        tmrRun.Interval = 210 - 10 * trbSpeed.Value
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        tmrRun.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrRun.Stop()
    End Sub

End Class
