Option Strict Off
Imports System.Console
Imports VBTutConsole.OverridingInterfaces

Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim myIntArrayImplicit() As Integer ' implicit constructor
            Dim myIntArrayExplicit As Integer = New Integer() 'explicit constructor
        End Sub
    End Class
End Module
