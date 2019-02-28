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


        Dim FileReader1 As IO.StreamReader
        Dim Space_counter As Integer
        Dim space_positions(500) As Integer
        Dim s As Integer

        FileReader1 = New IO.StreamReader("b_lovely_landscapes.txt")
        photo_num = FileReader1.ReadLine()
        Console.WriteLine("There are " & photo_num & " Pictures:")

        column = 0
        Space_counter = 0


        For x = 0 To (photo_num - 1)

            pic_info = FileReader1.ReadLine()
            Console.WriteLine(pic_info)
            slength = Len(pic_info)


            For s = 1 To Len(pic_info)
                If Mid(pic_info, s, 1) = " " Then
                    space_positions(Space_counter) = s
                    Space_counter = Space_counter + 1
                End If
            Next

            For s = 0 To Space_counter
                Console.Write(space_positions(Space_counter) & " ")
            Next

            Console.WriteLine()

        Next

        FileReader1.Close()

        Console.ReadLine()

    End Sub

End Module
