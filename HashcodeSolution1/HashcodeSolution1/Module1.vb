Module Module1

    Sub Main()
        'Zaveri In
        'Stark in
        'Rayhaan In



    End Sub
    Sub Brain()
        Dim num1, num2 As Integer
        Dim maxTagsfiles As Integer = 0
        Dim maxScoreGetter As Integer = 1
        Dim maxScoreOptained As Integer
        Dim currentScore As Integer
        Dim counter As Integer = 0
        For i = 0 To NumPhotos - 1
            If ArrayIN(i, 1) > ArrayIN(maxTagsfiles, 1) Then
                maxTagsfiles = i
            End If
        Next

        num1 = maxTagsfiles
        num2 = 0
        Do
            maxScoreOptained = Calc_Score(num1, num2)
            For i = 2 To NumPhotos - 1
                If ArrayIN(i, 1) <> 1 Then
                    num2 = i
                    currentScore = Calc_Score(num1, num2)
                    If currentScore <> 0 Then
                        If currentScore > maxScoreOptained Then
                            maxScoreOptained = currentScore
                            maxScoreGetter = i
                            counter = counter + 1
                        End If
                    End If
                End If
            Next
            num1 = maxScoreGetter
        Loop Until counter = 0
    End Sub
End Module
