Option Strict Off

Imports System.Console
Module Program
    Sub Main(args As String())
        Dim valueOne As Integer = 4
        Dim valueTwo As Integer = 5
        WriteLine($"{valueOne} = {valueTwo} => {valueOne = valueTwo}")
        ' NOT EQUAL
        WriteLine($"{valueOne} <> {valueTwo} => {valueOne <> valueTwo}")
        WriteLine($"{valueOne} > {valueTwo} => {valueOne = valueTwo}")
        WriteLine($"{valueOne} => {valueTwo} => {valueOne >= valueTwo}")
        WriteLine($"{valueOne} >= {valueTwo} => {valueOne >= valueTwo}")
        WriteLine($"{valueOne} =< {valueTwo} => {valueOne <= valueTwo}")
        ReadLine()
    End Sub
End Module
