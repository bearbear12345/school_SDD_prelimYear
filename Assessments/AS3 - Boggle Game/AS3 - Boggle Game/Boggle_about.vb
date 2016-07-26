Public Class Boggle_about

    Private Sub Boggle_about_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.lblAboutBoggle.Text = My.Application.Info.ProductName + " - " + My.Application.Info.Description
        Me.LogoPictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
    End Sub

    Private Sub OKButton_Click(sender As System.Object, e As System.EventArgs) Handles OKButton.Click
        Me.Close()
        Me.LogoPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
    End Sub

End Class
