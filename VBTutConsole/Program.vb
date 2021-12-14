Option Strict Off
Imports System.Console
Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim currentTime As System.DateTime = System.DateTime.Now
            Dim time1 As New Time(currentTime)
            time1.DisplayCurrentTime()
            Dim time2 As New Time(2021, 12, 19, 3, 45, 9)
            time2.DisplayCurrentTime()
        End Sub
    End Class

End Module
