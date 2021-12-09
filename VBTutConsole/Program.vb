Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim counterVariable As Integer = 0

        Do
            WriteLine("counterVariable: {0}", counterVariable)

            counterVariable += 1
            If counterVariable > 9 Then
                Exit Do
            End If
        Loop
    End Sub
End Module
