Option Strict Off
Imports System.Console
Imports VBTutConsole.OverridingInterfaces
Imports VBTutConsole.Chp14Arrays
Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim tester As Chapter16.ConcatenateDemo
            tester = New Chapter16.ConcatenateDemo()

            tester.Run()
        End Sub
    End Class
End Module
