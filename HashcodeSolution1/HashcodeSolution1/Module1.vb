Module Module1

    Dim photo_num As Integer
    Dim tag_number As Integer
    Dim column As Integer
    Dim pic_info As String
    Dim slength As Integer
    Dim ArrayIN(7999, 99) As String


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

End Module
