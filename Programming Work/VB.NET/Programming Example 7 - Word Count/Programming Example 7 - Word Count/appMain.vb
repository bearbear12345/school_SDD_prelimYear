Imports Microsoft.WindowsAPICodePack.Taskbar
Imports System.Text.RegularExpressions

Public Class appMain

    Private Sub applicationTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appTick.Tick
        TaskbarManager.Instance.SetProgressState({2, 4, 8}(New Random().Next(3)))
        TaskbarManager.Instance.SetProgressValue(Int(Rnd() * 100), 100)
    End Sub

    Private Sub appLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub queryQuit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles queryQuit.CheckedChanged
        If queryQuit.Checked Then
            Close()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtEntry.Clear()
        txtEntry.Focus()
    End Sub

    Private Sub txtEntry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEntry.TextChanged
        ' Dim J As Integer, last As Integer = txtEntry.TextLength - 1
        ' Dim wordcount As Integer = 0
        ' For J = 0 To last
        '   If txtEntry.Text.Chars(J) = " " Then
        '     WordCount += 1
        '   End If
        ' Next J
        Dim count = Split(Regex.Replace(txtEntry.Text, " {2,}", " "), " ").Length
        If txtEntry.TextLength = 0 Then
            lblCount.Text = "Word Count: 0"
        ElseIf (txtEntry.Text.Substring(txtEntry.TextLength - 1)) = " " Then
            lblCount.Text = "Word Count: " + (count - 1).ToString()
        Else
            lblCount.Text = "Word Count: " + count.ToString()
        End If

    End Sub
End Class
