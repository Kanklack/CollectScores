Module Module1

    Sub Main()

        Dim scores(7) As Integer

        'Dim game As Integer 

        Console.WriteLine("Please enter 8 scores")

        For i As Integer = 0 To 7

            Console.WriteLine("Please enter score: ")

            scores(i) = Convert.ToUInt16(Console.ReadLine())

        Next

        Console.WriteLine("All the scores you had entered were: ")

        Console.Write("[")

        For i As Integer = 0 To 7

            Console.Write(scores(i) & ",")

        Next

        Console.Write("]")

        Console.Read()

    End Sub

End Module
