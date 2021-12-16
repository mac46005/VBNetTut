Public Class Document
    Implements IStorable

    Public Property Status As Integer Implements IStorable.Status
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub Read() Implements IStorable.Read
        Throw New NotImplementedException()
    End Sub

    Public Sub Write() Implements IStorable.Write
        Throw New NotImplementedException()
    End Sub
End Class
