Public Class TeacherMenu
    Dim student As KeyValuePair(Of String, List(Of Integer))
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddWord()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
    Private Sub AnalyseButton_Click(sender As Object, e As EventArgs) Handles AnalyseButton.Click
        Me.Hide()
        AnalyseStudent.Show()
        AnalyseStudent.SetChart()
    End Sub

    Private Sub TeacherMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
    End Sub
End Class