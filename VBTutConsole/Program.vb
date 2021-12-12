Option Strict Off
Module Program
    Sub Main(args As String())
        Dim x As Integer = 5
        Dim y As Integer = 7

        Dim andValue As Boolean
        Dim orValue As Boolean
        Dim xorValue As Boolean
        Dim notValue As Boolean

        andValue = x = 3 And y = 7
        orValue = x = 3 Or y = 7
        xorValue = x = 3 Xor y = 7
        notValue = Not x = 3

        WriteLine($"x = 3 And y = 7. {andValue}")
        WriteLine($"x = 3 Or y = 7. {orValue}")
        WriteLine($"x = 3 xor y = 7. {xorValue}")
        WriteLine($"x = 3 Not y = 7. {notValue}")
    End Sub
End Module
