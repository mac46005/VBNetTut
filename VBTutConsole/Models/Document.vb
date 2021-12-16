Public Class Document
    Implements IStorable, ICompressible
    Private _status As Integer
    Public Property Status As Integer Implements IStorable.Status
        Get
            Return _status
        End Get
        Set(value As Integer)
            _status = value
        End Set
    End Property

    ' constructor
    Public Sub New(s As String)
        Console.WriteLine($"Creating document with: {s}")
    End Sub


    Public Sub Read() Implements IStorable.Read
        Console.WriteLine("Document.Reading()")
    End Sub

    Public Sub Write(obj As Object) Implements IStorable.Write
        Console.WriteLine("Document.Reading()")
    End Sub

    Public Sub Compress() Implements ICompressible.Compress
        Console.WriteLine("Document.Compress()")
    End Sub

    Public Sub Decompress() Implements ICompressible.Decompress\
        Console.WriteLine("Document.Decompress()")
    End Sub
End Class
