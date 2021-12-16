Option Strict Off
Imports System.Console
Imports VBTutConsole.OverridingInterfaces

Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim myIntArrayImplicit(7) As Integer ' implicit contrsuctor, 7 members
            Dim myIntArrayExplicit As Integer() = New Integer(7) {} ' I think the author made a mistake
            ' Dim myIntArray as Integer = New Integer(7){} <= this is what he got. I keep getting an error though....

        End Sub
    End Class
End Module
