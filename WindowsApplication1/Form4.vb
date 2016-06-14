Public Class Form4
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox1.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox1.Image = ImageList3.Images(9)
            PictureBox1.BackColor = Color.White
        End If
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox1.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox1.Image = ImageList3.Images(9)
            PictureBox1.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If PictureBox1.BackColor = Color.White Then
            PictureBox1.Image = PictureBox2.Image
            PictureBox1.BackColor = Color.Gray
            PictureBox2.Image = ImageList3.Images(9)
            PictureBox2.BackColor = Color.White
        End If
        If PictureBox3.BackColor = Color.White Then
            PictureBox3.Image = PictureBox2.Image
            PictureBox3.BackColor = Color.Gray
            PictureBox2.Image = ImageList3.Images(9)
            PictureBox2.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox2.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox2.Image = ImageList3.Images(9)
            PictureBox2.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox3.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox3.Image = ImageList3.Images(9)
            PictureBox3.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox3.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox3.Image = ImageList3.Images(9)
            PictureBox3.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If PictureBox1.BackColor = Color.White Then
            PictureBox1.Image = PictureBox4.Image
            PictureBox1.BackColor = Color.Gray
            PictureBox4.Image = ImageList3.Images(9)
            PictureBox4.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox4.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox4.Image = ImageList3.Images(9)
            PictureBox4.BackColor = Color.White
        End If
        If PictureBox7.BackColor = Color.White Then
            PictureBox7.Image = PictureBox4.Image
            PictureBox7.BackColor = Color.Gray
            PictureBox4.Image = ImageList3.Images(9)
            PictureBox4.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox5.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox5.Image = ImageList3.Images(9)
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox5.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox5.Image = ImageList3.Images(9)
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox5.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox5.Image = ImageList3.Images(9)
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox5.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox5.Image = ImageList3.Images(9)
            PictureBox5.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If PictureBox3.BackColor = Color.White Then
            PictureBox3.Image = PictureBox6.Image
            PictureBox3.BackColor = Color.Gray
            PictureBox6.Image = ImageList3.Images(9)
            PictureBox6.BackColor = Color.White
        End If
        If PictureBox9.BackColor = Color.White Then
            PictureBox9.Image = PictureBox6.Image
            PictureBox9.BackColor = Color.Gray
            PictureBox6.Image = ImageList3.Images(9)
            PictureBox6.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox6.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox6.Image = ImageList3.Images(9)
            PictureBox6.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox7.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox7.Image = ImageList3.Images(9)
            PictureBox7.BackColor = Color.White
        End If
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox7.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox7.Image = ImageList3.Images(9)
            PictureBox7.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox8.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox8.Image = ImageList3.Images(9)
            PictureBox8.BackColor = Color.White
        End If
        If PictureBox7.BackColor = Color.White Then
            PictureBox7.Image = PictureBox8.Image
            PictureBox7.BackColor = Color.Gray
            PictureBox8.Image = ImageList3.Images(9)
            PictureBox8.BackColor = Color.White
        End If
        If PictureBox9.BackColor = Color.White Then
            PictureBox9.Image = PictureBox8.Image
            PictureBox9.BackColor = Color.Gray
            PictureBox8.Image = ImageList3.Images(9)
            PictureBox8.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox9.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox9.Image = ImageList3.Images(9)
            PictureBox9.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox9.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox9.Image = ImageList3.Images(9)
            PictureBox9.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox1.Text = TextBox1.Text + 1
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        MsgBox("Indiciu pentru rezolvare puzzle!!")
    End Sub
    Private Sub ExitAplicatieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitAplicatieToolStripMenuItem.Click
        Dim raspuns As Integer
        raspuns = MessageBox.Show("Sigur doriti sa parasit aplicatia?", "Exit", MessageBoxButtons.YesNo)
        If raspuns = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub AutorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutorToolStripMenuItem.Click
        MsgBox("Aplicatie realizata de:" & vbCrLf & "Ciornei Claudiu Georgel" & vbCrLf & "Grupa 3123-B")
    End Sub

    Private Sub SchimbaImagineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchimbaImagineToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub AmestecaPieseleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmestecaPieseleToolStripMenuItem.Click
        PictureBox1.Image = ImageList3.Images(6)
        PictureBox2.Image = ImageList3.Images(1)
        PictureBox3.Image = ImageList3.Images(5)
        PictureBox4.Image = ImageList3.Images(2)
        PictureBox5.Image = ImageList3.Images(3)
        PictureBox6.Image = ImageList3.Images(4)
        PictureBox7.Image = ImageList3.Images(7)
        PictureBox8.Image = ImageList3.Images(8)
        PictureBox9.Image = ImageList3.Images(9)


        PictureBox1.BackColor = Color.Gray
        PictureBox2.BackColor = Color.Gray
        PictureBox3.BackColor = Color.Gray
        PictureBox4.BackColor = Color.Gray
        PictureBox5.BackColor = Color.Gray
        PictureBox6.BackColor = Color.Gray
        PictureBox7.BackColor = Color.Gray
        PictureBox8.BackColor = Color.Gray
        PictureBox9.BackColor = Color.White
        Timer1.Start()
    End Sub

    Private Sub X4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X4ToolStripMenuItem.Click
        Dim raspuns As Integer
        raspuns = MessageBox.Show("Sigur doriti sa schimbati dificultatea jocului?", "Schimba", MessageBoxButtons.YesNo)
        If raspuns = vbYes Then
            Me.Close()
        End If
        Me.Hide()
        Puzzle4x4.Show()
    End Sub

    Private Sub X3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X3ToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class