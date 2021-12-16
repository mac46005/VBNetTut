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

        Public Shared Sub Example14_5()
            Dim a As Integer = 5
            Dim b As Integer = 6
            Dim c As Integer = 7
            Console.WriteLine("Calling with three integers")
            DisplayVals(a, b, c)

            Console.WriteLine("Calling with four integers")
            DisplayVals(3, 4, 5, 6)

            Console.WriteLine("Calling with an array of four integers")
            Dim explicitArray() As Integer = {33, 4, 5, 6}
            DisplayVals(explicitArray)
        End Sub
        Public Sub TwoDimensionalArray()
            ' How to call a rectangular array system
            Dim rectangularArray1(,) As Integer
            Dim rectangularArray2 As Integer(,)
        End Sub
    End Class 'ArrayExamples
End Namespace
