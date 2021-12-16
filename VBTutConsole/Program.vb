Option Strict Off
Imports System.Console
Imports VBTutConsole.OverridingInterfaces

Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim myIntArrayImplicit(7) As Integer ' implicit contrsuctor, 7 members
            Dim myIntArrayExplicit As Integer() = New Integer(7) {} ' I think the author made a mistake
            ' Dim myIntArray as Integer = New Integer(7){} <= this is what he got. I keep getting an error though....


            ' Resizing an array
            Dim myArrayString As String() = New String(4) {}

            myArrayString(0) = "valueone"
            myArrayString(1) = "valuetwo"
            myArrayString(2) = "valuethree"
            myArrayString(3) = "valuefour"

            ' You can resize an array from its current size using ReDim
            ReDim myArrayString(50)

            ' You can make the same change to array, but preserve the existing data in the array by writing:
            ReDim Preserve myArrayString(50)
        End Sub
    End Class
End Module
