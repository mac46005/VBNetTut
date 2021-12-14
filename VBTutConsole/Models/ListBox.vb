Public Class ListBox : Inherits Window
    ' private members
    Private _listboxContents As String

    ' constructor
    Public Sub New(top As Integer, left As Integer, content As String)
        MyBase.New(top, left)
        _listboxContents = content
    End Sub

    ' an overridden version (not keyword) because in the
    ' derived method we changed the behavior
    Public Overrides Sub DrawingWindow()
        MyBase.DrawingWindow() ' invoke base method
        Console.WriteLine($"Writing string to the listBox: {_listboxContents}")
    End Sub
End Class
