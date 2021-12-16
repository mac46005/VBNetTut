Option Strict Off
Imports System.Console
Imports VBTutConsole.OverridingInterfaces
Imports VBTutConsole.Chp14Arrays
Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim intArray() As Integer
            Dim empArray() As Employee
            intArray = New Integer(5) {}
            empArray = New Employee(3) {}

            ' populate the array
            Dim i As Integer
            For i = 0 To empArray.Length - 1
                empArray(i) = New Employee(i + 5)
            Next i

            Console.WriteLine("The integer array...")
            For Each intValue As Integer In intArray
                Console.WriteLine(intValue.ToString())
            Next

            Console.WriteLine("The employee array...")

            For Each e As Employee In empArray
                Console.WriteLine(e)
            Next

        End Sub
    End Class
End Module
