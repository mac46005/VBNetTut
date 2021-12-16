
Namespace OverridingInterfaces
    Interface IStorable
        Sub Read()
        Sub Write()
    End Interface
    ' Simplify Document to implement only IStorable
    Public Class Document : Implements IStorable
        ' constructor
        Public Sub New(s As String)
            Console.WriteLine($"Creating document with: {s}")
        End Sub

        ' Make read virtual
        Public Overridable Sub Read() Implements IStorable.Read
            Console.WriteLine($"Document Virtual Read Method For IStorable")
        End Sub

        Public Sub Write() Implements IStorable.Write
            Console.WriteLine($"Document write method for IStorable")
        End Sub
    End Class

    Public Class Note : Inherits Document
        ' constructor that builds the document and note 
        Public Sub New(s As String)
            MyBase.New(s)
            Console.WriteLine($"Creating note with: {s}")
        End Sub

        ' override the read method
        Public Overrides Sub Read()
            Console.WriteLine("Overriding the Read Method for NOTE!!")
        End Sub

        ' implement my own write method
        Public Shadows Sub Write()
            Console.WriteLine("Implementing the Write method for Note!")
        End Sub
    End Class



End Namespace