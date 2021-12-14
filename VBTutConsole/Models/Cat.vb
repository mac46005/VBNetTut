Public Class Cat
    Private _weight As Integer

    Public Sub New(ByVal weight As Integer)
        _weight = weight
    End Sub

    Public Property Weight() As Integer
        Get
            Return _weight
        End Get
        Set(value As Integer)
            _weight = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return _weight.ToString()
    End Function
End Class
