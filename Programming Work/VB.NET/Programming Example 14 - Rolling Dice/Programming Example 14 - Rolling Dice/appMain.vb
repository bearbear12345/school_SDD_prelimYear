Imports Microsoft.WindowsAPICodePack.Taskbar
Public Class appMain
    Dim diceInterval = 50
    Dim diceInc = 5
    Dim diceTemp

    Private Sub applicationTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appTick.Tick
        TaskbarManager.Instance.SetProgressState({2, 4, 8}(New Random().Next(3)))
        TaskbarManager.Instance.SetProgressValue(Int(Rnd() * 100), 100)
    End Sub

    Private Sub appLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrDice.Interval = diceInterval
    End Sub

    Private Sub queryQuit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles queryQuit.CheckedChanged
        If queryQuit.Checked Then
            Close()
        End If
    End Sub

    Private Sub dieRoll(sender As Object, e As EventArgs) Handles tmrDice.Tick
        imgDice.Image = My.Resources.ResourceManager.GetObject({"dice_1", "dice_2", "dice_3", "dice_4", "dice_5", "dice_6"}(New Random().Next(6)))
        diceTemp = {0, 5, 5, 10, 10, 20}(New Random().Next(6))
        If diceTemp >= diceInc Then
            diceInc = diceTemp
        End If
        tmrDice.Interval += diceInc
        If tmrDice.Interval > 400 Then
            tmrDice.Stop()
            tmrDice.Interval = diceInterval
            btnRoll.Enabled = True
        End If
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        tmrDice.Start()
        btnRoll.Enabled = False

    End Sub
End Class
