Public Class Boggle_about
    Private Sub Boggle_about_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.lblAboutBoggle.Text = My.Application.Info.ProductName + " - " + My.Application.Info.Description ' Dynamically update the application name and description
        Me.LogoPictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone) ' Rotate logo sideways (90° to the left)
    End Sub

    Private Sub OKButton_Click(sender As System.Object, e As System.EventArgs) Handles OKButton.Click
        Me.Close()
        Me.LogoPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone) ' Reset the logo rotation (so the image isn't rotated 540° on the next open)
    End Sub

End Class
