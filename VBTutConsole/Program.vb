Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim targetInteger As Integer = 7

        Select Case targetInteger
            Case Is < 10
                WriteLine("Less than 10")
            Case 10 To 14
                WriteLine("10-14")
            Case 15
                WriteLine("15!")
            Case Else
                WriteLine("Value not found!")
        End Select
    End Sub
End Module
