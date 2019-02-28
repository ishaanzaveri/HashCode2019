Module Module1

    Dim photo_num As Integer
    Dim tag_number As Integer
    Dim column As Integer
    Dim pic_info As String
    Dim slength As Integer
    Dim ArrayIN(7999, 99) As String

    Sub Main()

        FileReading()
        Console.ReadLine()

    End Sub

    Sub FileReading()

        Dim FileLine As String = ""
        Dim fileReader As IO.StreamReader
        Dim LastSpace As Integer = 2
        Dim StringTaken As String = ""
        Dim Counterj As Integer = 0
        Dim SpaceCounter As Integer = 2
        Dim PhotoNumber As Integer = 0
        Dim CurrentSpace As Integer = 0
        Dim counter As Integer = 0
        Dim column As Integer = 2
        Dim WritetoArray As String = ""
        Dim SpacePositions(500) As Integer

        fileReader = New IO.StreamReader("b_lovely_landscapes.txt")
        fileReader.ReadLine()

        'Do While fileReader.EndOfStream = False

        'FileLine = fileReader.ReadLine()
        '
        'LastSpace = 0
        'SpaceCounter = 0

        'For i = 1 To Len(FileLine)
        'If Mid(FileLine, i, 1) = " " Then

        '   SpaceCounter = SpaceCounter + 1
        '  SpacePositions(SpaceCounter) = i

        'ed If

        'Next

        For PhotoNumber = 0 To 7999
            ArrayIN(PhotoNumber, 0) = 0
        Next

        For PhotoNumber = 0 To 7999
            FileLine = fileReader.ReadLine()
            ArrayIN(PhotoNumber, 1) = Left(FileLine, 1)
            LastSpace = 2
            For counter = 3 To Len(FileLine)
                If Mid(FileLine, counter, 1) = " " Then
                    column = column + 1
                    CurrentSpace = counter
                    WritetoArray = Mid(FileLine, counter, (CurrentSpace - 1) - (LastSpace + 1))
                    ArrayIN(PhotoNumber, column) = WritetoArray
                    WritetoArray = ""
                End If
            Next
            column = 2
        Next

        'Loop

        fileReader.Close()
        ' Console.ReadLine()

    End Sub

End Module
