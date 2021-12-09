Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim loopCounter As Single

        For loopCounter = 0.5 To 9 Step 0.5
            WriteLine($"{NameOf(loopCounter)} : {loopCounter}")
        Next
    End Sub
End Module
