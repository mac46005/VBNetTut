Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim valueOne As Integer = 10
        Dim valueTwo As Integer = 20
        Dim valueThree As Integer = 30

        WriteLine("Testing valueOne against valueTwo...")
        If valueOne > valueTwo Then
            WriteLine($"{NameOf(valueOne)}: {valueOne} larger than {NameOf(valueTwo)}:{valueTwo}")
        End If

        WriteLine("Testing valueThree against valueTwo...")
        If valueThree > valueTwo Then
            WriteLine($"{NameOf(valueThree)}: {valueThree} larger than {NameOf(valueTwo)}: {valueTwo}")
        End If

        WriteLine("Testing is valueTwo > 15 on one line")
        If valueTwo > 15 Then WriteLine("Yes it is")

    End Sub
End Module
