Public Class Dog
    Private _weight As Integer
    ' constructor
    Public Sub New(weight As Integer)
        _weight = weight
    End Sub

    ' override object.tostring
    Public Overrides Function ToString() As String
        Return _weight.ToString()
    End Function
End Class
