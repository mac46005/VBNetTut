Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim target As String = "Milo"

        Select Case target
            Case "Fred", "Joe", Is < "Alpha"
                WriteLine("Joe or Fres or < Aardzark")
        End Select
    End Sub
End Module
