Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Show()
        Form1.PictureBox10.BackgroundImage = PictureBox1.Image
        Form1.PictureBox10.Image = My.Resources.Pamantul
        Form1.PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form3.Show()
        Form3.PictureBox10.BackgroundImage = PictureBox2.Image
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Form4.Show()
        Form4.PictureBox10.BackgroundImage = PictureBox3.Image
    End Sub

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Form5.Show()
        Form5.PictureBox10.BackgroundImage = PictureBox4.Image
    End Sub
End Class