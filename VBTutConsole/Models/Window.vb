Public Class Window
    Inherits WindowBase
    'constructor
    Public Sub New(top As Integer, left As Integer)
        MyBase.New(top, left)
    End Sub

    Public Overrides Sub DrawWindow()
        Console.WriteLine("WIndow Drawn")
    End Sub
End Class
