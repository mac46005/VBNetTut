Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim outer As Integer
        Dim inner As Integer

        For outer = 3 To 6
            For inner = 10 To 12
                WriteLine($"{outer} * {inner} = {outer * inner}")
            Next
        Next
    End Sub
End Module
