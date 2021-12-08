Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim temp As Integer = 32

        If temp <= 32 Then
            WriteLine("Warning! Ice on the road!")
            If temp = 32 Then
                WriteLine("Temp exactly freezing, beware of water.")
            End If
        End If
    End Sub
End Module
