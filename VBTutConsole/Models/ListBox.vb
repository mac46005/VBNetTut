Public Class ListBox : Inherits WindowBase
    ' constructor adds a parameter
    Public Sub New(top As Integer, left As Integer, content As String)
        MyBase.New(top, left)
        _listBoxContents = content
    End Sub

    ' an overridden version implementing the 
    ' abstract method
    Public Overrides Sub DrawWindow()
        Console.WriteLine($"Writing string to the listbox: {_listBoxContents}")
    End Sub

    Private _listBoxContents As String
End Class
