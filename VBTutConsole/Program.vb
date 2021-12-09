Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim temp As Integer = -32

        If temp > 32 Then
            WriteLine("Safe driving...")
        ElseIf temp = 32 Then
            WriteLine("Warning, 32 degrees, watch for ice and water")
        ElseIf temp > 0 Then
            WriteLine("Watch for ice...")
        ElseIf temp = 0 Then
            WriteLine("Temperature = 0")
        Else
            WriteLine("Temperatures below zero, Wicked Cold!")
        End If
    End Sub
End Module
