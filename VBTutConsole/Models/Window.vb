Public Class Window
    ' these members are protected and thus visible
    ' to derived class methods.
    Protected _top As Integer
    Protected _left As Integer

    'constructor
    Public Sub New(top As Integer, left As Integer)
        _top = top
        _left = left
    End Sub

    ' simulates drawing the window
    Public Overridable Sub DrawingWindow()
        Console.WriteLine($"Window: drawing window at ({_left},{_top})")
    End Sub
End Class
