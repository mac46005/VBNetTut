Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim valueOne As Integer = 10
        Dim valueTwo As Integer = 20
        Dim valueThree As Integer = 30

        WriteLine("Testing valueOne against valueTwo...")
        If valueOne > valueTwo Then
            WriteLine("value one is larger than value two")
        Else
            WriteLine("nope, value one is not larger than value two.")
        End If
    End Sub
End Module
