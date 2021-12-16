Option Strict Off
Imports System.Console
Imports VBTutConsole.My.Structures

Module Program
    Public Class Tester
        Public Shared Sub Main()
            ' create an instance of the structure
            Dim loc1 As New Location(200, 300)

            ' display the values in the structure
            Console.WriteLine($"Loc1 location:{loc1}")

            ' invoke the default constructor
            Dim loc2 As New Location()
            Console.WriteLine($"Loc2 location: {loc2}")

            ' pass the constructor to a method
            myFunc(loc1)
            Console.WriteLine($"Loc1 location: {loc1}")
        End Sub
        Public Shared Sub myFunc(loc As Location)
            ' modify the values through the properties
            loc.XVal = 49
            loc.YVal = 300
            Console.WriteLine($"{loc} location: {loc}")
        End Sub
    End Class
End Module
