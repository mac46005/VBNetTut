Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim counterVariable As Integer = 0

repeat: ' the label
        WriteLine($"Counter variable: {counterVariable}")
        ' Increment the counter
        counterVariable += 1
        If counterVariable < 10 Then
            GoTo repeat ' the dastardly deed
        End If
    End Sub
End Module
