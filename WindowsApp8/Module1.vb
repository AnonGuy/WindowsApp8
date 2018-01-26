Module Module1
    Public words As New Dictionary(Of String, String) From {
        {"hectare", "A unit of area."}, {"active", "Being busy."},
        {"amaze", "To surprise."}, {"bound", "To leap and jump."},
        {"cavern", "A large cave."}, {"difficult", "Hard to do."},
        {"frozen", "Turned to ice."}, {"garage", "Building housing a car."},
        {"jaguar", "A large cat."}, {"lemonade", "A fizzy drink."}}
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
        ElseIf diff < 0 Then
            Return input.Substring(0, length - 1)
        End If
        Return input
    End Function
    Sub AddWord()
        Dim word = InputBox("What is your word?")
        Dim definition = InputBox("What is the definition?")
        words.Add(word, definition)
        MsgBox("Word Added.")
    End Sub
End Module
