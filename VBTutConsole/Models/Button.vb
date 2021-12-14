Public Class Button
    Inherits Window

    Public Sub New(top As Integer, left As Integer)
        MyBase.New(top, left)
    End Sub

    ' an ovverridden version (note keyword) because in the
    ' derived method we change the behavior
    Public Overrides Sub DrawingWindow()
        Console.WriteLine($"Drawing a button at ({_left},{_top})      {ControlChars.Lf}")
    End Sub
End Class
