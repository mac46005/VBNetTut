Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim targetInteger As Integer = 15

        Select Case targetInteger
            Case 5
                WriteLine("5")
            Case 10
                WriteLine("10")
            Case 15
                WriteLine("15")
            Case Else
                WriteLine("Value not found")
        End Select
    End Sub
End Module
