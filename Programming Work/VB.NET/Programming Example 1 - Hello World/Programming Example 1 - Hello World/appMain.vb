Imports Microsoft.WindowsAPICodePack.Taskbar
Public Class appMain

    Dim taskbarArr As Integer() = {2, 4, 8}
    Private Sub applicationTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appTick.Tick
        TaskbarManager.Instance.SetProgressState(taskbarArr(New Random().Next(3)))
        TaskbarManager.Instance.SetProgressValue(Int(Rnd() * 100), 100)
    End Sub

    Private Sub queryQuit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles queryQuit.CheckedChanged
        If queryQuit.Checked Then
            Close()
        End If
    End Sub

    Private Sub btnHelloWorld_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelloWorld.CheckedChanged
        If btnHelloWorld.Checked Then
            TextDisplay.Text = "Hello World!"
        End If
    End Sub

    Private Sub btnClearText_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearText.CheckedChanged
        If btnClearText.Checked Then
            TextDisplay.Text = ""
        End If
    End Sub
End Class
