Option Strict Off

Imports System.Console
Module Program
    Sub Main(args As String())
        Dim firstValue As Integer
        Dim secondValue As Integer
        While True
            WriteLine("Enter first value:")
            firstValue = CInt(ReadLine())
            WriteLine("Enter second value:")
            secondValue = CInt(ReadLine())

            WriteLine($"{firstValue} + {secondValue} = {firstValue + secondValue}")
            WriteLine($"{firstValue} - {secondValue} = {firstValue - secondValue}")
            WriteLine($"{firstValue} * {secondValue} = {firstValue * secondValue}")
            Dim asIntResult As Integer = firstValue \ secondValue
            Dim asDoubleResult As Double = firstValue / secondValue



            WriteLine($"{firstValue} \ {secondValue} = [IntegerResult] {asIntResult}")
            WriteLine($"{firstValue} / {secondValue} = [DoubleResult] {asDoubleResult}")



            ReadLine()

        End While
    End Sub
End Module
