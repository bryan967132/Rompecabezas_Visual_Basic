Public Class Form1
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox1.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox1.Image = ImageList1.Images(0)
            PictureBox1.BackColor = Color.White
        End If
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox1.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox1.Image = ImageList1.Images(0)
            PictureBox1.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If PictureBox1.BackColor = Color.White Then
            PictureBox1.Image = PictureBox2.Image
            PictureBox1.BackColor = Color.Gray
            PictureBox2.Image = ImageList1.Images(0)
            PictureBox2.BackColor = Color.White
        End If
        If PictureBox3.BackColor = Color.White Then
            PictureBox3.Image = PictureBox2.Image
            PictureBox3.BackColor = Color.Gray
            PictureBox2.Image = ImageList1.Images(0)
            PictureBox2.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox2.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox2.Image = ImageList1.Images(0)
            PictureBox2.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox3.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox3.Image = ImageList1.Images(0)
            PictureBox3.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox3.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox3.Image = ImageList1.Images(0)
            PictureBox3.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If PictureBox1.BackColor = Color.White Then
            PictureBox1.Image = PictureBox4.Image
            PictureBox1.BackColor = Color.Gray
            PictureBox4.Image = ImageList1.Images(0)
            PictureBox4.BackColor = Color.White
        End If
        If PictureBox7.BackColor = Color.White Then
            PictureBox7.Image = PictureBox4.Image
            PictureBox7.BackColor = Color.Gray
            PictureBox4.Image = ImageList1.Images(0)
            PictureBox4.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox4.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox4.Image = ImageList1.Images(0)
            PictureBox4.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox5.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox5.Image = ImageList1.Images(0)
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox5.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox5.Image = ImageList1.Images(0)
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox5.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox5.Image = ImageList1.Images(0)
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox5.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox5.Image = ImageList1.Images(0)
            PictureBox5.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox6.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox6.Image = ImageList1.Images(0)
            PictureBox6.BackColor = Color.White
        End If
        If PictureBox3.BackColor = Color.White Then
            PictureBox3.Image = PictureBox6.Image
            PictureBox3.BackColor = Color.Gray
            PictureBox6.Image = ImageList1.Images(0)
            PictureBox6.BackColor = Color.White
        End If
        If PictureBox9.BackColor = Color.White Then
            PictureBox9.Image = PictureBox6.Image
            PictureBox9.BackColor = Color.Gray
            PictureBox6.Image = ImageList1.Images(0)
            PictureBox6.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox7.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox7.Image = ImageList1.Images(0)
            PictureBox7.BackColor = Color.White
        End If
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox7.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox7.Image = ImageList1.Images(0)
            PictureBox7.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If PictureBox7.BackColor = Color.White Then
            PictureBox7.Image = PictureBox8.Image
            PictureBox7.BackColor = Color.Gray
            PictureBox8.Image = ImageList1.Images(0)
            PictureBox8.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox8.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox8.Image = ImageList1.Images(0)
            PictureBox8.BackColor = Color.White
        End If
        If PictureBox9.BackColor = Color.White Then
            PictureBox9.Image = PictureBox8.Image
            PictureBox9.BackColor = Color.Gray
            PictureBox8.Image = ImageList1.Images(0)
            PictureBox8.BackColor = Color.White
        End If
    End Sub
    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox9.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox9.Image = ImageList1.Images(0)
            PictureBox9.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox9.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox9.Image = ImageList1.Images(0)
            PictureBox9.BackColor = Color.White
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = ImageList1.Images(7)
        PictureBox2.Image = ImageList1.Images(5)
        PictureBox3.Image = ImageList1.Images(1)
        PictureBox4.Image = ImageList1.Images(8)
        PictureBox5.Image = ImageList1.Images(6)
        PictureBox6.Image = ImageList1.Images(2)
        PictureBox7.Image = ImageList1.Images(3)
        PictureBox8.Image = ImageList1.Images(4)
        PictureBox9.Image = ImageList1.Images(0)
        PictureBox10.Image = ImageList2.Images(0)

        PictureBox1.BackColor = Color.Gray
        PictureBox2.BackColor = Color.Gray
        PictureBox3.BackColor = Color.Gray
        PictureBox4.BackColor = Color.Gray
        PictureBox5.BackColor = Color.Gray
        PictureBox6.BackColor = Color.Gray
        PictureBox7.BackColor = Color.Gray
        PictureBox8.BackColor = Color.Gray
        PictureBox9.BackColor = Color.White
    End Sub
End Class
