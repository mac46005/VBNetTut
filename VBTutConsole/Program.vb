Option Strict Off

Imports System.Console
Module Program
    Sub Main(args As String())
        Dim counter As Integer

        'count from 1 to 100
        For counter = 1 To 100
            ' display the value
            Write($"{counter} ")

            ' every tenth value, display a tab and the value
            If counter Mod 10 = 0 Then
                WriteLine(vbTab & counter)
            End If
        Next counter
    End Sub
End Module
