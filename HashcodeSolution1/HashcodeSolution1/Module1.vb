
Module Module1

    Dim photo_num As Integer = 7999
    Dim tag_number As Integer
    Dim column As Integer
    Dim pic_info As String
    Dim slength As Integer
    Dim ArrayIN(7999, 50) As String
    Dim ArrayOUT(8000) As Integer


    Sub Main()
        'Zaveri In
        'Stark in
        FileReading()
        Brain()
        FileOutput()
        Console.WriteLine("Done")
        Console.ReadLine()
    End Sub

    Sub FileReading()

        Dim FileLine As String = ""
        Dim fileReader As IO.StreamReader
        Dim LastSpace As Integer = 0
        Dim writetoarray As String = ""
        Dim Counterj As Integer = 0
        Dim CounterNums As Integer = 0
        Dim RideNo As Integer = 0

        fileReader = New IO.StreamReader("b_lovely_landscapes.txt")
        fileReader.ReadLine()

        For PhotoNumber = 0 To 7999
            ArrayIN(PhotoNumber, 0) = 0
        Next
        For counter = 0 To 7999
            FileLine = fileReader.ReadLine()
            'Console.WriteLine(FileLine)
            LastSpace = 0
            CounterNums = 1
            For i = 1 To Len(FileLine)
                If Mid(FileLine, i, 1) = " " Then
                    writetoarray = Mid(FileLine, LastSpace + 1, i - LastSpace - 1)
                    LastSpace = i
                    ArrayIN(Counterj, CounterNums) = writetoarray
                    CounterNums = CounterNums + 1
                End If
                If i = Len(FileLine) Then
                    writetoarray = Right(FileLine, i - LastSpace)
                    ArrayIN(Counterj, CounterNums) = writetoarray
                End If
            Next
            ArrayIN(Counterj, 6) = Counterj
            Counterj = Counterj + 1
        Next

    End Sub
    Sub Brain()
        Dim num1, num2 As Integer
        Dim TotalSlides As Integer = 0
        Dim SlideCounter As Integer = 1
        Dim maxTagsfiles As Integer = 0
        Dim maxScoreGetter As Integer = 1
        Dim maxScoreOptained As Integer
        Dim currentScore As Integer
        Dim counter As Integer = 0
        For i = 0 To photo_num
            If CInt(ArrayIN(i, 2)) > CInt(ArrayIN(maxTagsfiles, 2)) Then
                maxTagsfiles = i
            End If
        Next
        ArrayIN(maxTagsfiles, 0) = 1
        num1 = maxTagsfiles
        num2 = 0
        Do
            counter = 0
            ArrayOUT(SlideCounter) = num1
            maxScoreOptained = Calculate_Score(num1, num2)
            For i = 2 To photo_num
                If ArrayIN(i, 0) <> "1" Then
                    num2 = i
                    currentScore = Calculate_Score(num1, num2)
                    If currentScore > 0 Then
                        If currentScore > maxScoreOptained Then
                            maxScoreOptained = currentScore
                            maxScoreGetter = i
                            counter = counter + 1
                        End If
                    End If
                End If
            Next
            SlideCounter = SlideCounter + 1
            num1 = maxScoreGetter
            ArrayIN(maxScoreGetter, 0) = 1
            TotalSlides = TotalSlides + 1
        Loop Until counter = 0
        ArrayOUT(0) = TotalSlides
    End Sub

    Function Calculate_Score(ByVal PhotoID_1, ByVal PhotoID_2)
        Dim common_counter As Integer = 0
        Dim f_photo_tags As Integer = 0
        Dim s_photo_tags As Integer = 0
        Dim m1 As Integer = 0
        Dim m2 As Integer = 0
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim counter1 As Integer = 4
        Dim counter2 As Integer = 4
        Dim greatest As Integer = 0
        Dim min As Integer = 0
        Dim found As String
        Do While ArrayIN(PhotoID_1, m1) <> ""
            m1 = m1 + 1
        Loop
        Do While ArrayIN(PhotoID_2, m2) <> ""
            m2 = m2 + 1
        Loop
        For i = 0 To m1 - 1
            For j = 0 To m2 - 1
                If ArrayIN(PhotoID_1, i + 4) = ArrayIN(PhotoID_2, j + 4) And ArrayIN(PhotoID_1, i + 4) <> "" Then
                    common_counter = common_counter + 1
                    found = ArrayIN(PhotoID_1, i + 4)
                End If
            Next
        Next
        f_photo_tags = m1 - common_counter
        s_photo_tags = m2 - common_counter
        If (common_counter < f_photo_tags) And (common_counter < s_photo_tags) Then
            min = common_counter
        ElseIf (f_photo_tags < common_counter) And (f_photo_tags < s_photo_tags) Then
            min = f_photo_tags
        Else
            min = s_photo_tags
        End If
        Calculate_Score = min
    End Function
    Sub FileOutput()
        Dim filewriter As IO.StreamWriter
        filewriter = New IO.StreamWriter("b_lovely_landscapes.out")
        Dim counter As Integer = 0
        filewriter.WriteLine(ArrayOUT(0))
        For i = 1 To ArrayOUT(0)
            filewriter.WriteLine(ArrayOUT(i) - 1)
            ' counter = counter + 1
        Next
        filewriter.Close()
    End Sub
End Module
