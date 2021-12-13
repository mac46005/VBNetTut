Option Strict Off
Imports System.Console
Module Program

    Public Class Bitch
        Public Weight As Integer
    End Class
    Public Class Tester
        Public Shared Sub Main()
            Dim secondParam As Integer = 222
            Dim timeObjest As New Time()
            timeObjest.DisplayCurrentTime("firstParam", secondParam)
        End Sub
    End Class
    Public Class Time
        ' Private variables
        Private Year As Integer
        Private Month As Integer
        Private Day As Integer
        Private Hour As Integer
        Private Minute As Integer
        Private Second As Integer

        ' public methods
        Public Sub DisplayCurrentTime(firstParam As String, secondParam As Integer)
            WriteLine("stub for DisplayCurrentTime")
        End Sub

    End Class
End Module
