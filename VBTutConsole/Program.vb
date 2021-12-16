Option Strict Off
Imports System.Console
Imports VBTutConsole.OverridingInterfaces
Imports VBTutConsole.Chp14Arrays
Module Program
    Public Class Tester
        Public Shared Sub Main()
            ' This is an example of the ParamsArray keyword in use
            ' public Sub DisplayVals(ByVal ParamArray intVals() as Integer)
            Chp14Arrays.ArrayExamples.DisplayVals(3, 4, 5, 3, 5, 6)


            ' In this example I explicitly created an array of numbers and
            ' dumped in the DisplayVals parameters
            Dim explicitArray() As Integer = {3, 4, 5, 6, 7, 8}
            Chp14Arrays.ArrayExamples.DisplayVals(explicitArray)


        End Sub
    End Class
End Module
