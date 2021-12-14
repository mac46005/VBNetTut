Option Strict Off
Imports System.Console
Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim test As New Tester()
            test.Run()


        End Sub
        Public Sub Run()
            ' declare a variable and initialize to 5
            Dim theVariable As Integer = 5

            ' display its value
            Console.WriteLine($"In Run. theVariable: {theVariable}")
            ' call the method and pass in the variable
            Doubler(theVariable)
            ' return and display the value again
            Console.WriteLine($"Back in run. theVariable: {theVariable}")
            EndOfSubFunc(NameOf(Run))

        End Sub

        Public Sub Doubler(ByRef param As Integer)
            ' display the value that was passed in
            Console.WriteLine($"In Double(). Revecieved param: {param}")

            ' double the value
            param *= 2

            ' Display the doubled value before returning
            Console.WriteLine($"updated param. Return new value: {param}")
            EndOfSubFunc(NameOf(Doubler))
        End Sub
        Public Sub EndOfSubFunc(Inside As String)
            Console.WriteLine($"End of {Inside}")
        End Sub


    End Class

End Module
