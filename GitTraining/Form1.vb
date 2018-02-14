Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Button1.Tag
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = Button2.Tag
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = Button3.Tag
    End Sub
End Class
