Public Class StudentMenu
    Dim word As KeyValuePair(Of String, String)
    Dim currentScore As Integer = 0
    Dim maxScore As Integer = 0
    Private Sub StudentMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each cword In Module1.words
            WordList.Items.Add(cword.Value)
        Next
        word = words.ElementAt(0)
        maxScore = words.Count * 2
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
    Private Sub WordList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WordList.SelectedIndexChanged
        If WordList.SelectedIndex < 0 Then
            WordList.SelectedIndex = 0
        End If
        word = words.ElementAt(WordList.SelectedIndex)
        Label1.Text = CStr(word.Key.Length) + " letter word:"
        Label2.Text = word.Value
        TextBox1.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        currentScore += Module1.GetScore(TextBox1.Text, word.Key)
        ProgressBar1.Value = (currentScore / maxScore) * 100
        WordList.Items.Remove(word.Value)
        words.Remove(word.Key)
    End Sub
End Class