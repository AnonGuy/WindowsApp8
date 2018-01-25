Public Class TeacherMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.AddWord()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class