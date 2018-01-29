Public Class StudentMenu
    Dim word As KeyValuePair(Of String, String)
    Dim currentScore As Integer = 0
    Dim maxScore As Integer = 0
    Sub ReloadWordList()
        If words.Count = 0 Then
            MsgBox("Your score is: " + CStr(currentScore))
            Dim username As String = InputBox("What is your name?", "Upload Score", "Guest")
            If scores.ContainsKey(username) Then
                scores(username).Add(currentScore)
            Else
                scores.Add(username, New List(Of Integer) From {currentScore})
            End If
            SaveScores()
            MsgBox("Score saved.")
            Me.Hide()
            MainMenu.Show()
        Else
            WordList.Items.Clear()
            For Each cword In words
                WordList.Items.Add(cword.Key)
            Next
            word = words.ElementAt(0)
        End If
    End Sub
    Sub ReloadForm()
        ProgressBar1.Value = 0
        LoadWords()
        ReloadWordList()
        WordList.SelectedIndex = 0
        maxScore = words.Count * 2
        LoadScores()
    End Sub
    Private Sub StudentMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadForm()
    End Sub
    Private Sub StudentMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainMenu.Show()
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
        Dim startIndex As Integer = 1
        Dim ascLetter As Integer = Asc(WordList.SelectedItem(0))
        If ascLetter < 123 And ascLetter > 64 Then startIndex = 0
        Label2.Text = WordList.SelectedItem.Substring(startIndex)
        TextBox1.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        currentScore += GetScore(TextBox1.Text, word.Value)
        ProgressBar1.Value = (currentScore / maxScore) * 100
        words.Remove(word.Key)
        ReloadWordList()
        WordList.SelectedIndex = 0
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class