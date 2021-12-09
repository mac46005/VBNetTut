Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim counterVariable As Integer = 0

        Do Until counterVariable = 10
            WriteLine($"{NameOf(counterVariable)}:{counterVariable}")
            counterVariable += 1
        Loop
    End Sub
End Module
