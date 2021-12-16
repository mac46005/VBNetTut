Namespace Chp14Arrays
    Public Class Employee
        ' adding predefined values in an array
        Dim myIntArray1() As Integer = {2, 3, 4, 5, 6, 7}
        Dim myIntArray2() As Integer = New Integer(4) {2, 3, 4, 5, 6}



        Private _empId As Integer
        ' constructor
        Public Sub New(empId As Integer)
            _empId = empId
        End Sub

        Public Overrides Function ToString() As String
            Return _empId.ToString()
        End Function
    End Class


    Public Class ArrayExamples
        Public Shared Sub DisplayVals(ByVal ParamArray intVals() As Integer)
            For Each i As Integer In intVals
                Console.WriteLine($"DisplayVals {i}")
            Next
        End Sub ' DisplayVals

    End Class 'ArrayExamples
End Namespace
