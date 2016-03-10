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
    Private Sub txtEntry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntry.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            txtEntry.SelectAll()
            e.Handled = True
        End If
    End Sub
    Private Sub txtEntry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEntry.TextChanged
        ' Screw default code
        ' Dim J As Integer, last As Integer = txtEntry.TextLength - 1
        ' Dim wordcount As Integer = 0
        ' For J = 0 To last
        '   If txtEntry.Text.Chars(J) = " " Then
        '     WordCount += 1
        '   End If
        ' Next J
        Dim count = Split(Regex.Replace(txtEntry.Text.Trim(), " {2,}", " "), " ").Length ' Count spaces in an array with replaced dual whitespaces of a trimmed input
        If txtEntry.Text.Trim().Length = 0 Then
            lblCount.Text = 0
        Else
            lblCount.Text = count
        End If

    End Sub
End Class
