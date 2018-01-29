Module Module1
    Public words As New Dictionary(Of String, String)
    Public scores As New Dictionary(Of String, List(Of Integer))
    Dim ToFile As String
    Dim content As String()
    Sub LoadWords()
        words.Clear()
        content = My.Computer.FileSystem.ReadAllText("words.csv").Split(vbNewLine)
        For Each line In content
            Dim current As String() = line.Split(",")
            words.Add(current(0), current(1))
        Next
    End Sub
    Sub SaveWords()
        ToFile = ""
        For Each word In words
            ToFile += word.Key + "," + word.Value + vbNewLine
        Next
        ToFile = ToFile.Substring(0, Len(ToFile) - 1)
        My.Computer.FileSystem.WriteAllText("words.csv", ToFile, False)
    End Sub
    Sub LoadScores()
        scores.Clear()
        content = My.Computer.FileSystem.ReadAllText("scores.csv").Split(vbNewLine)
        For Each line In content
            line = RemoveRedundant(line)
            If line <> Nothing Then
                Dim current As String() = line.Split(",")
                If Not scores.ContainsKey(current(0)) Then
                    scores.Add(current(0), New List(Of Integer) From {CInt(current(1))})
                Else
                    scores(current(0)).Add(CInt(current(1)))
                End If
            End If
        Next
    End Sub
    Function RemoveRedundant(input)
        Dim output As String = ""
        For Each character In input
            If character <> "
" Then
                output += character
            End If
        Next
        Return output
    End Function
    Sub SaveScores()
        ToFile = ""
        For Each scorePair In scores
            For Each score In scorePair.Value
                ToFile += scorePair.Key + "," + CStr(score) + vbNewLine
            Next
        Next
        ToFile = ToFile.Substring(0, Len(ToFile) - 1)
        My.Computer.FileSystem.WriteAllText("scores.csv", ToFile, False)
    End Sub
    Function GetScore(input As String, target As String)
        input = input.ToLower()
        target = target.ToLower()
        Dim score = Len(target)
        input = ResizeString(input, Len(target))
        For i As Integer = 0 To target.Length - 1
            If target(i) <> input(i) Then score -= 1
        Next
        Dim bounds As New Dictionary(Of Integer, Integer) From {{0, 2}, {1, 1}, {2, 0}}
        For Each pair In bounds
            If score = Len(target) - pair.Key Then Return pair.Value
        Next
        Return 0
    End Function
    Function ResizeString(input As String, length As Integer)
        Dim diff = length - Len(input)
        If diff > 0 Then
            Return input + StrDup(diff, " ")
        ElseIf diff <0 Then
            Return input.Substring(0, length - 1)
        End If
        Return input
    End Function
    Sub AddWord()
        Dim word = InputBox("What is your word?")
        Dim definition = InputBox("What is the definition?")
        words.Add(definition, word)
        MsgBox("Word Added.")
    End Sub
End Module
