Public Class StudentMenu
    Dim word As KeyValuePair(Of String, String)
    Dim currentScore As Integer = 0
    Dim maxScore As Integer = 0
    Sub ReloadWords()
        WordList.Items.Clear()
        For Each cword In words
            WordList.Items.Add(cword.Key)
        Next
        word = words.ElementAt(0)
    End Sub
    Private Sub StudentMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.LoadWords()
        ReloadWords()
        WordList.SelectedIndex = 0
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
        Label1.Text = CStr(word.Value.Length) + " letter word:"
        Label2.Text = WordList.SelectedItem
        TextBox1.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        currentScore += Module1.GetScore(TextBox1.Text, word.Value)
        ProgressBar1.Value = (currentScore / maxScore) * 100
        words.Remove(word.Key)
        ReloadWords()
    End Sub
End Class