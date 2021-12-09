Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim counterVariable As Integer = 100

        Do
            WriteLine("counterVariable: {0}", counterVariable)
            counterVariable += 1
        Loop While counterVariable < 10
    End Sub
End Module
