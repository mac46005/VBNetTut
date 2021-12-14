Public Class Cat
    Private Shared instances As Integer = 0
    Private weight As Integer
    Private name As String

    ' Constructors
    Public Sub New(ByVal name As String, ByVal weight As Integer)
        instances += 1
        Me.name = name
        Me.weight = weight
    End Sub
    ' METHODS
    Public Shared Sub HowManyCats()
        Console.WriteLine($"{instances} cats adopted")
    End Sub
    Public Sub GetWeight()
        Console.WriteLine($"{name} weight: {weight}")
    End Sub
End Class
