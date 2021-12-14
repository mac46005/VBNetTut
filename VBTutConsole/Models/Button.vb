Public Class Button
    Inherits WindowBase

    ' constructor
    Public Sub New(top As Integer, left As Integer)
        MyBase.New(top, left)
    End Sub
    Public Overrides Sub DrawWindow()
        Console.WriteLine($"Drawing a button at ({_left},{_top})")
    End Sub
End Class
