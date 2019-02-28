Module Module1

    Dim photo_num As Integer = 7999
    Dim tag_number As Integer
    Dim column As Integer
    Dim pic_info As String
    Dim slength As Integer
    Dim ArrayIN(7999, 99) As String
    Dim ArrayOUT(8000)


    Sub Main()
        'Zaveri In
        'Stark in



        '  Dim FileReader1 As IO.StreamReader
        '   Dim Space_counter As Integer
        ' Dim space_positions(50) As Integer
        'Dim s As Integer

        'FileReader1 = New IO.StreamReader("b_lovely_landscapes.txt")
        'photo_num = FileReader1.ReadLine()
        'Console.WriteLine("There are " & photo_num & " Pictures:")

        '   column = 0
        '  Space_counter = 0
        ' FileReader1.ReadLine()

        'For x = 0 To (photo_num - 1)

        'pic_info = FileReader1.ReadLine()
        '    Console.WriteLine(pic_info)
        'slength = Len(pic_info)

        'For s = 1 To slength
        'If Mid(pic_info, s, 1) = " " Then
        'space_positions(Space_counter) = s
        'Space_counter = Space_counter + 1
        'End If
        'Next

        'For s = 0 To Space_counter
        'Console.Write(space_positions(Space_counter) & " ")
        'Next

        'Console.WriteLine()

        'Next

        'FileReader1.Close()
        'FileReading()

    End Sub

    Sub FileReading()

        Dim FileLine As String = ""
        Dim fileReader As IO.StreamReader
        Dim LastSpace As Integer = 0
        Dim NumTaken As String = ""
        Dim Counterj As Integer = 0
        Dim SpaceCounter As Integer = 0
        Dim RideNo As Integer = 0
        Dim SpacePositions(50) As Integer

        fileReader = New IO.StreamReader("b_lovely_landscapes.txt")
        fileReader.ReadLine()

        Do While fileReader.EndOfStream = False
            FileLine = fileReader.ReadLine()
            'Console.WriteLine(FileLine)
            LastSpace = 0
            SpaceCounter = 0
            For i = 1 To Len(FileLine)
                If Mid(FileLine, i, 1) = " " Then

                    'NumTaken = Mid(FileLine, LastSpace + 1, i - LastSpace)
                    'LastSpace = i
                    'ArrayIN(Counterj, CounterNums) = NumTaken
                    'CounterNums = CounterNums + 1
                    'End If
                    'If i = Len(FileLine) Then
                    'NumTaken = Right(FileLine, i - LastSpace)
                    'ArrayIN(Counterj, CounterNums) = NumTaken


                End If
            Next
            ArrayIN(Counterj, 6) = Counterj
            Counterj = Counterj + 1
        Loop
        fileReader.Close()

    End Sub
    Sub Brain()
        Dim num1, num2 As Integer
        Dim TotalSlides As Integer = 0
        Dim SlideCounter As Integer = 0
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

        num1 = maxTagsfiles
        num2 = 0
        Do
            ArrayOUT(SlideCounter) = num1
            maxScoreOptained = Calculate_Score(num1, num2)
            For i = 2 To photo_num
                If ArrayIN(i, 0) <> "1" Then
                    num2 = i
                    currentScore = Calculate_Score(num1, num2)
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
        Dim found As Boolean = False
        Do While ArrayIN(PhotoID_1, counter1) <> "" 'counter = m1 vice versa 
            m1 = m1 + 1
            counter1 = counter1 + 1
        Loop
        Do While ArrayIN(PhotoID_2, counter2) <> "" ' counter = m2 vice versa 
            m2 = m2 + 1
            counter2 = counter2 + 1
        Loop
        For i = 1 To m1
            For j = 1 To m2
                If ArrayIN(PhotoID_1, i + 4) = ArrayIN(PhotoID_2, j + 4) Then
                    found = True
                End If
            Next
            If found = True Then
                common_counter = common_counter + 1 ' shouldnt this be inside 
            Else
                f_photo_tags = f_photo_tags + 1
            End If
            found = False
        Next
        If m1 > m2 Then ' equal then m2 ?
            greatest = m1
        Else
            greatest = m2
        End If
        s_photo_tags = greatest - (f_photo_tags + common_counter)
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

    End Sub
End Module
