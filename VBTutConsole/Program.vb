Option Strict Off

Imports System.Console
Module Program
    Sub Main(args As String())
        Dim value As Integer = 5
        Dim power As Integer = 4

        WriteLine($"{value} to the {power}th power is {value ^ power}")
        ReadLine()
    End Sub
End Module
