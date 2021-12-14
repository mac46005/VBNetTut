Public MustInherit Class WindowBase
    ' constructor takes two integers to
    ' fix location on the console
    Public Sub New(top As Integer, left As Integer)
        _top = top
        _left = left


    End Sub
    ' notice: no implementation
    Public MustOverride Sub DrawWindow()

    Protected _top As Integer
    Protected _left As Integer
End Class
