Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim loopCounter As Integer
        For loopCounter = 0 To 10
            WriteLine($"{NameOf(loopCounter)} : {loopCounter}")
        Next
    End Sub
End Module
