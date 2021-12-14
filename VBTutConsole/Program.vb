Option Strict Off
Imports System.Console
Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim currentTime As System.DateTime = DateTime.Now
            Dim time1 As New TimeProps(currentTime)
            time1.DisplayCurrentTime()

            'extract the hour to a local variable
            Dim theHour As Integer = time1.Hour

            ' display the local variable
            Console.WriteLine($"Retrieved the hour: {theHour}")

            ' add one to the local variable
            theHour += 1

            ' write the time back to the object
            time1.Hour = theHour


            'display the result 
            Console.WriteLine($"Updated the hour: {time1.Hour}")

        End Sub
    End Class

End Module
