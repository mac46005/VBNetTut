Namespace Chapter16
    Public Class CompareStringDemo
        Public Sub Run()
            ' create some Strings to work with
            Dim s1 As String = "abcd"
            Dim s2 As String = "ABCD"

            Dim result As Integer ' hold the result of comparisons
            ' compare the two strings, case sensitive
            result = String.Compare(s1, s2) ' result = -1
            Console.WriteLine($"compare s1: {s1}, s2: {s2} => Results: {result}")

            ' overloaded compare, takes boolean "ignore case"
            ' (true = ignore case)
            result = String.Compare(s1, s2, True) ' result = 0
            Console.WriteLine($"Compare insensitive. Result: {result}")



        End Sub
    End Class
End Namespace
