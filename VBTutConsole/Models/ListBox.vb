Public Class ListBox : Inherits Window
    Private _listboxContents As String
    ' constructor
    Public Sub New(top As Integer, left As Integer, contents As String)
        MyBase.New(top, left)
        _listboxContents = contents
    End Sub

    ' a shadow version (note keyword) in the
    ' derived method we change the behavior
    Public Shadows Sub DrawWindow()
        MyBase.DrawWindow()
        Console.WriteLine($"Writing string to listBox: {_listboxContents}")
    End Sub
End Class
