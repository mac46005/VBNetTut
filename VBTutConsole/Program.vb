Option Strict Off
Imports System.Console
Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim myIntegerVariable As Integer = 123
            ' Boxing
            Dim myObjectVariable As Object = myIntegerVariable
            Console.WriteLine($"myObjectVariable: {myObjectVariable.ToString()}")

            ' unboxing (must be explicit)
            Dim anotherIntegerVariable As Integer = DirectCast(myObjectVariable, Integer)

            Console.WriteLine($"anotherIntegerVariable: {anotherIntegerVariable}")


        End Sub
    End Class
End Module
