Public Class MainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TeacherMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StudentMenu.Show()
        StudentMenu.ReloadForm()
        Me.Hide()
    End Sub
End Class
