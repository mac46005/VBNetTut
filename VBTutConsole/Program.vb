Option Strict Off
Imports System.Console
Imports VBTutConsole.My.Structures

Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim doc As New Document("Test Document")
            doc.Read()
            doc.Status = -1
            ' the power of interfaces. Never forget.
            Dim isDoc As IStorable = doc
            isDoc.Status = 0
            isDoc.Read()




        End Sub
    End Class
End Module
