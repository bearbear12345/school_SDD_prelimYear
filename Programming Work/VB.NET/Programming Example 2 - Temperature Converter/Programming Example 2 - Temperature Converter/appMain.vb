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

    Private Sub changedValue(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valCelsius.ValueChanged, valFarenheit.ValueChanged, valKelvin.ValueChanged

        If sender.Name = "valCelsius" Then
            valFarenheit.Value = valCelsius.Value * 9 / 5 + 32
            valKelvin.Value = valCelsius.Value + 273.15
        ElseIf sender.Name = "valFarenheit" Then
            valCelsius.Value = (valFarenheit.Value - 32) * 5 / 9
            valKelvin.Value = valCelsius.Value + 273.15
        ElseIf sender.Name = "valKelvin" Then
            valCelsius.Value = valKelvin.Value - 273.15
            valFarenheit.Value = valCelsius.Value * 9 / 5 + 32
        End If
        ' TaskbarManager.Instance.SetProgressValue(valCelsius.Value, valCelsius.Maximum)
    End Sub

    Private Sub appMain_Load() Handles MyBase.Load
        valCelsius.Minimum = -500
        valCelsius.Maximum = 1000
        valFarenheit.Minimum = valCelsius.Minimum * 9 / 5 + 32
        valFarenheit.Maximum = valCelsius.Maximum * 9 / 5 + 32
        valKelvin.Minimum = valCelsius.Minimum + 273.15
        valKelvin.Maximum = valCelsius.Maximum + 273.15
    End Sub

End Class
