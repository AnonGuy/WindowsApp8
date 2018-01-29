Public Class AnalyseStudent
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        TeacherMenu.Show()
    End Sub

    Sub SetChart()
        LoadScores()
        Dim studentName As String = InputBox("What is the name of the student?", "Analyse Student", "Guest")
        If scores.ContainsKey(studentName) Then
            ProgressChart.Series(0).Points.Clear()
            ProgressChart.Titles(0).Text = "Student Progress - " + studentName
            Dim studentScores As List(Of Integer) = scores(studentName)
            For i As Integer = 0 To studentScores.Count - 1
                ProgressChart.Series(0).Points.AddY(studentScores(i))
            Next
        Else
            MsgBox("Student not found.")
            TeacherMenu.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub AnalyseStudent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        TeacherMenu.Show()
    End Sub
End Class