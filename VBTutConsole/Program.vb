Option Strict Off
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim minDrinkingCoffee As Integer = 5
        Dim minReadingNewspaper As Integer = 10
        Dim minArguing As Integer = 15
        Dim minDawdling As Integer = 20

        Dim numAdults As Integer = 2
        Dim numChildren As Integer = 2

        Dim wastebByEachAdult As Integer
        Dim wastedByAllAdults As Integer
        Dim wastedByEachKid As Integer
        Dim wastedByAllKids As Integer
        Dim wastedByFamily As Integer
        Dim totalSeconds As Integer

        wastebByEachAdult = minDrinkingCoffee + minReadingNewspaper
        wastedByAllAdults = wastebByEachAdult * numAdults
        wastedByEachKid = wastedByEachKid * numChildren
        wastedByFamily = wastedByAllAdults + wastedByAllKids
        totalSeconds = wastedByFamily * 60

        WriteLine($"Each adult wastes {wastebByEachAdult} minutes")
        WriteLine($"Each child wasted by entire family: {wastedByAllKids}")
        WriteLine($"Total wasted seconds: {totalSeconds}")


    End Sub
End Module
