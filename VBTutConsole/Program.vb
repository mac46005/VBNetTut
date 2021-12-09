Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim target As String = "Milo"

        Select Case target
            Case "Alpha" To "Lambda"
                WriteLine("ALpha to Lambda executed")
            Case "Lamda" To "Zeta"
                WriteLine("Lamda to Zeta executed")
            Case Else
                WriteLine("Else Executed")
        End Select
    End Sub
End Module
