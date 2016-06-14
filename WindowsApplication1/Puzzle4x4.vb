Public Class Puzzle4x4
    Private Sub ExitAplicatieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitAplicatieToolStripMenuItem.Click
        Dim raspuns As Integer
        raspuns = MessageBox.Show("Sigur doriti sa parasiti aplicatia?", "Exit", MessageBoxButtons.YesNo)
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
        PictureBox1.Image = ImageList5.Images(9)
        PictureBox2.Image = ImageList5.Images(1)
        PictureBox3.Image = ImageList5.Images(15)
        PictureBox4.Image = ImageList5.Images(2)
        PictureBox5.Image = ImageList5.Images(14)
        PictureBox6.Image = ImageList5.Images(3)
        PictureBox7.Image = ImageList5.Images(13)
        PictureBox8.Image = ImageList5.Images(5)
        PictureBox9.Image = ImageList5.Images(12)
        PictureBox10.Image = ImageList5.Images(6)
        PictureBox11.Image = ImageList5.Images(11)
        PictureBox12.Image = ImageList5.Images(7)
        PictureBox13.Image = ImageList5.Images(13)
        PictureBox14.Image = ImageList5.Images(8)
        PictureBox15.Image = ImageList5.Images(10)
        PictureBox16.Image = ImageList5.Images(16)


        PictureBox1.BackColor = Color.Gray
        PictureBox2.BackColor = Color.Gray
        PictureBox3.BackColor = Color.Gray
        PictureBox4.BackColor = Color.Gray
        PictureBox5.BackColor = Color.Gray
        PictureBox6.BackColor = Color.Gray
        PictureBox7.BackColor = Color.Gray
        PictureBox8.BackColor = Color.Gray
        PictureBox9.BackColor = Color.Gray
        PictureBox10.BackColor = Color.Gray
        PictureBox11.BackColor = Color.Gray
        PictureBox12.BackColor = Color.Gray
        PictureBox13.BackColor = Color.Gray
        PictureBox14.BackColor = Color.Gray
        PictureBox15.BackColor = Color.Gray
        PictureBox16.BackColor = Color.White
        Timer1.Start()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox1.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox1.Image = ImageList5.Images(16)
            PictureBox1.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox1.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox1.Image = ImageList5.Images(16)
            PictureBox1.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If PictureBox1.BackColor = Color.White Then
            PictureBox1.Image = PictureBox2.Image
            PictureBox1.BackColor = Color.Gray
            PictureBox2.Image = ImageList5.Images(16)
            PictureBox2.BackColor = Color.White
        End If
        If PictureBox3.BackColor = Color.White Then
            PictureBox3.Image = PictureBox2.Image
            PictureBox3.BackColor = Color.Gray
            PictureBox2.Image = ImageList5.Images(16)
            PictureBox2.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox2.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox2.Image = ImageList5.Images(16)
            PictureBox2.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox3.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox3.Image = ImageList5.Images(16)
            PictureBox3.BackColor = Color.White
        End If
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox3.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox3.Image = ImageList5.Images(16)
            PictureBox3.BackColor = Color.White
        End If
        If PictureBox7.BackColor = Color.White Then
            PictureBox7.Image = PictureBox3.Image
            PictureBox7.BackColor = Color.Gray
            PictureBox3.Image = ImageList5.Images(16)
            PictureBox3.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If PictureBox3.BackColor = Color.White Then
            PictureBox3.Image = PictureBox4.Image
            PictureBox3.BackColor = Color.Gray
            PictureBox4.Image = ImageList5.Images(16)
            PictureBox4.BackColor = Color.White
        End If
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox4.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox4.Image = ImageList5.Images(16)
            PictureBox4.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If PictureBox1.BackColor = Color.White Then
            PictureBox1.Image = PictureBox5.Image
            PictureBox1.BackColor = Color.Gray
            PictureBox5.Image = ImageList5.Images(16)
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox5.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox5.Image = ImageList5.Images(16)
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox9.BackColor = Color.White Then
            PictureBox9.Image = PictureBox5.Image
            PictureBox9.BackColor = Color.Gray
            PictureBox5.Image = ImageList5.Images(16)
            PictureBox5.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox6.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox6.Image = ImageList5.Images(16)
            PictureBox6.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox6.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox6.Image = ImageList5.Images(16)
            PictureBox6.BackColor = Color.White
        End If
        If PictureBox7.BackColor = Color.White Then
            PictureBox7.Image = PictureBox6.Image
            PictureBox7.BackColor = Color.Gray
            PictureBox6.Image = ImageList5.Images(16)
            PictureBox6.BackColor = Color.White
        End If
        If PictureBox10.BackColor = Color.White Then
            PictureBox10.Image = PictureBox6.Image
            PictureBox10.BackColor = Color.Gray
            PictureBox6.Image = ImageList5.Images(16)
            PictureBox6.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If PictureBox3.BackColor = Color.White Then
            PictureBox3.Image = PictureBox7.Image
            PictureBox3.BackColor = Color.Gray
            PictureBox7.Image = ImageList5.Images(16)
            PictureBox7.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox7.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox7.Image = ImageList5.Images(16)
            PictureBox7.BackColor = Color.White
        End If
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox7.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox7.Image = ImageList5.Images(16)
            PictureBox7.BackColor = Color.White
        End If
        If PictureBox11.BackColor = Color.White Then
            PictureBox11.Image = PictureBox7.Image
            PictureBox11.BackColor = Color.Gray
            PictureBox7.Image = ImageList5.Images(16)
            PictureBox7.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox8.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox8.Image = ImageList5.Images(16)
            PictureBox8.BackColor = Color.White
        End If
        If PictureBox7.BackColor = Color.White Then
            PictureBox7.Image = PictureBox8.Image
            PictureBox7.BackColor = Color.Gray
            PictureBox8.Image = ImageList5.Images(16)
            PictureBox8.BackColor = Color.White
        End If
        If PictureBox12.BackColor = Color.White Then
            PictureBox12.Image = PictureBox8.Image
            PictureBox12.BackColor = Color.Gray
            PictureBox8.Image = ImageList5.Images(16)
            PictureBox8.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox9.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox9.Image = ImageList5.Images(16)
            PictureBox9.BackColor = Color.White
        End If
        If PictureBox10.BackColor = Color.White Then
            PictureBox10.Image = PictureBox9.Image
            PictureBox10.BackColor = Color.Gray
            PictureBox9.Image = ImageList5.Images(16)
            PictureBox9.BackColor = Color.White
        End If
        If PictureBox13.BackColor = Color.White Then
            PictureBox13.Image = PictureBox9.Image
            PictureBox13.BackColor = Color.Gray
            PictureBox9.Image = ImageList5.Images(16)
            PictureBox9.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox10.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox10.Image = ImageList5.Images(16)
            PictureBox10.BackColor = Color.White
        End If
        If PictureBox11.BackColor = Color.White Then
            PictureBox11.Image = PictureBox10.Image
            PictureBox11.BackColor = Color.Gray
            PictureBox10.Image = ImageList5.Images(16)
            PictureBox10.BackColor = Color.White
        End If
        If PictureBox9.BackColor = Color.White Then
            PictureBox9.Image = PictureBox10.Image
            PictureBox9.BackColor = Color.Gray
            PictureBox10.Image = ImageList5.Images(16)
            PictureBox10.BackColor = Color.White
        End If
        If PictureBox14.BackColor = Color.White Then
            PictureBox14.Image = PictureBox10.Image
            PictureBox14.BackColor = Color.Gray
            PictureBox10.Image = ImageList5.Images(16)
            PictureBox10.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        If PictureBox7.BackColor = Color.White Then
            PictureBox7.Image = PictureBox11.Image
            PictureBox7.BackColor = Color.Gray
            PictureBox11.Image = ImageList5.Images(16)
            PictureBox11.BackColor = Color.White
        End If
        If PictureBox10.BackColor = Color.White Then
            PictureBox10.Image = PictureBox11.Image
            PictureBox10.BackColor = Color.Gray
            PictureBox11.Image = ImageList5.Images(16)
            PictureBox11.BackColor = Color.White
        End If
        If PictureBox12.BackColor = Color.White Then
            PictureBox12.Image = PictureBox11.Image
            PictureBox12.BackColor = Color.Gray
            PictureBox11.Image = ImageList5.Images(16)
            PictureBox11.BackColor = Color.White
        End If
        If PictureBox15.BackColor = Color.White Then
            PictureBox15.Image = PictureBox11.Image
            PictureBox15.BackColor = Color.Gray
            PictureBox11.Image = ImageList5.Images(16)
            PictureBox11.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox12.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox12.Image = ImageList5.Images(16)
            PictureBox12.BackColor = Color.White
        End If
        If PictureBox11.BackColor = Color.White Then
            PictureBox11.Image = PictureBox12.Image
            PictureBox11.BackColor = Color.Gray
            PictureBox12.Image = ImageList5.Images(16)
            PictureBox12.BackColor = Color.White
        End If
        If PictureBox16.BackColor = Color.White Then
            PictureBox16.Image = PictureBox12.Image
            PictureBox16.BackColor = Color.Gray
            PictureBox12.Image = ImageList5.Images(16)
            PictureBox12.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        If PictureBox9.BackColor = Color.White Then
            PictureBox9.Image = PictureBox13.Image
            PictureBox9.BackColor = Color.Gray
            PictureBox13.Image = ImageList5.Images(16)
            PictureBox13.BackColor = Color.White
        End If
        If PictureBox14.BackColor = Color.White Then
            PictureBox14.Image = PictureBox13.Image
            PictureBox14.BackColor = Color.Gray
            PictureBox13.Image = ImageList5.Images(16)
            PictureBox13.BackColor = Color.White
        End If

    End Sub
    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        If PictureBox13.BackColor = Color.White Then
            PictureBox13.Image = PictureBox14.Image
            PictureBox13.BackColor = Color.Gray
            PictureBox14.Image = ImageList5.Images(16)
            PictureBox14.BackColor = Color.White
        End If
        If PictureBox15.BackColor = Color.White Then
            PictureBox15.Image = PictureBox14.Image
            PictureBox15.BackColor = Color.Gray
            PictureBox14.Image = ImageList5.Images(16)
            PictureBox14.BackColor = Color.White
        End If
        If PictureBox10.BackColor = Color.White Then
            PictureBox10.Image = PictureBox14.Image
            PictureBox10.BackColor = Color.Gray
            PictureBox14.Image = ImageList5.Images(16)
            PictureBox14.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        If PictureBox11.BackColor = Color.White Then
            PictureBox11.Image = PictureBox15.Image
            PictureBox11.BackColor = Color.Gray
            PictureBox15.Image = ImageList5.Images(16)
            PictureBox15.BackColor = Color.White
        End If
        If PictureBox14.BackColor = Color.White Then
            PictureBox14.Image = PictureBox15.Image
            PictureBox14.BackColor = Color.Gray
            PictureBox15.Image = ImageList5.Images(16)
            PictureBox15.BackColor = Color.White
        End If
        If PictureBox16.BackColor = Color.White Then
            PictureBox16.Image = PictureBox15.Image
            PictureBox16.BackColor = Color.Gray
            PictureBox15.Image = ImageList5.Images(16)
            PictureBox15.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        If PictureBox12.BackColor = Color.White Then
            PictureBox12.Image = PictureBox16.Image
            PictureBox12.BackColor = Color.Gray
            PictureBox16.Image = ImageList5.Images(16)
            PictureBox16.BackColor = Color.White
        End If
        If PictureBox15.BackColor = Color.White Then
            PictureBox15.Image = PictureBox16.Image
            PictureBox15.BackColor = Color.Gray
            PictureBox16.Image = ImageList5.Images(16)
            PictureBox16.BackColor = Color.White
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox1.Text = TextBox1.Text + 1
    End Sub

    Private Sub StartShuffleGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartShuffleGameToolStripMenuItem.Click
        PictureBox17.Visible = False

        PictureBox1.Image = ImageList5.Images(1)
        PictureBox2.Image = ImageList5.Images(2)
        PictureBox3.Image = ImageList5.Images(3)
        PictureBox4.Image = ImageList5.Images(4)
        PictureBox5.Image = ImageList5.Images(5)
        PictureBox6.Image = ImageList5.Images(6)
        PictureBox7.Image = ImageList5.Images(7)
        PictureBox8.Image = ImageList5.Images(8)
        PictureBox9.Image = ImageList5.Images(9)
        PictureBox10.Image = ImageList5.Images(10)
        PictureBox11.Image = ImageList5.Images(11)
        PictureBox12.Image = ImageList5.Images(12)
        PictureBox13.Image = ImageList5.Images(13)
        PictureBox14.Image = ImageList5.Images(14)
        PictureBox15.Image = ImageList5.Images(15)
        PictureBox16.Image = ImageList5.Images(16)


        PictureBox1.BackColor = Color.Gray
        PictureBox2.BackColor = Color.Gray
        PictureBox3.BackColor = Color.Gray
        PictureBox4.BackColor = Color.Gray
        PictureBox5.BackColor = Color.Gray
        PictureBox6.BackColor = Color.Gray
        PictureBox7.BackColor = Color.Gray
        PictureBox8.BackColor = Color.Gray
        PictureBox9.BackColor = Color.Gray
        PictureBox10.BackColor = Color.Gray
        PictureBox11.BackColor = Color.Gray
        PictureBox12.BackColor = Color.Gray
        PictureBox13.BackColor = Color.Gray
        PictureBox14.BackColor = Color.Gray
        PictureBox15.BackColor = Color.Gray
        PictureBox16.BackColor = Color.White
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox17.Show()
    End Sub

    Private Sub X3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X3ToolStripMenuItem.Click
        Dim raspuns As Integer
        raspuns = MessageBox.Show("Sigur doriti sa schimbati dificultatea jocului?", "Schimba", MessageBoxButtons.YesNo)
        If raspuns = vbYes Then
            Me.Close()
        End If
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PictureBox17.Hide()
    End Sub

End Class