Public Class MainMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TeacherMenu.Show()
        Me.Hide()
    End Sub
End Class
