Public Class Window
    ' these members are private and thus invisible
    ' to derived class methods;
    Private _top As Integer
    Private _left As Integer

    ' constructor takes two integers
    Public Sub New(top As Integer, bottom As Integer)
        _top = top
        _left = bottom
    End Sub 'new

    ' simulates drawing the window
    Public Sub DrawWindow()
        Console.WriteLine($"Drawing window at top:{_top}    bottom:{_left}")
    End Sub
End Class
