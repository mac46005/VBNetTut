Namespace Chp14Arrays
    Public Class Employee
        Private _empId As Integer
        ' constructor
        Public Sub New(empId As Integer)
            _empId = empId
        End Sub

        Public Overrides Function ToString() As String
            Return _empId.ToString()
        End Function
    End Class
End Namespace
