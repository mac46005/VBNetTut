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
            ' trying it in an if statement
            If TypeOf (myObjectVariable) Is Integer Then
                Dim anotherIntegerVariable As Integer =
                    DirectCast(myObjectVariable, Integer)
                Console.WriteLine($"anotherIntegerVariable: {anotherIntegerVariable}")
            End If

            ' unboxing in a try catch for most saftey
            ' unboxing must be explicit
            Try
                Dim anotherIntegerVariable As Integer =
                    DirectCast(myObjectVariable, Integer)
                Console.WriteLine($"From try catch{ControlChars.Lf}anotherIntegerVarible: {anotherIntegerVariable}")
            Catch ex As InvalidCastException
                ' should not hit this but for demo purposes
                Console.WriteLine(ex.Message)
            End Try
        End Sub
    End Class
End Module
