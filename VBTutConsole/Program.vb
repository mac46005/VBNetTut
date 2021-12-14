Option Strict Off
Imports System.Console
Module Program

    Public Class Bitch
        Public Weight As Integer
    End Class
    Public Class Tester
        Public Shared Sub Main()
            Cat.HowManyCats()
            Dim frisky As New Cat("Firsky", 5)
            frisky.GetWeight()
            Cat.HowManyCats()
            Dim whiskers As New Cat("Whiskers", 7)
            whiskers.GetWeight()
            whiskers.HowManyCats()
            Cat.HowManyCats()
        End Sub
    End Class
    Public Class Time
        ' Private variables
        Private Year As Integer
        Private Month As Integer
        Private Day As Integer
        Private Hour As Integer
        Private Minute As Integer
        Private Second As Integer

        ' public methods
        Public Sub DisplayCurrentTime()
            WriteLine($"{Month}/{Day}/{Year}    {Hour}:{Minute}:{Second}")
        End Sub
        ' Constructor
        Public Sub New(ByVal theYear As Integer, ByVal theMonth As Integer, ByVal theDay As Integer, ByVal theHour As Integer, ByVal theMinute As Integer, ByVal theSecond As Integer)
            Year = theYear
            Month = theMonth
            Day = theDay
            Hour = theHour
            Minute = theMinute
            Second = theSecond
        End Sub

        ' Must provide own way of copying data to own objects
        Public Sub New(ByVal existingObject As Time)
            Year = existingObject.Year
            Month = existingObject.Month
            Day = existingObject.Day
            Hour = existingObject.Hour
            Minute = existingObject.Minute
            Second = existingObject.Second
        End Sub

        Public Sub TakeDate(ByVal Hour As Integer)
            Me.Hour = Hour
        End Sub
    End Class
    Public Class TestClass
        Sub SomeMethod(ByVal firstParam As Integer, ByVal secondParam As Single)
            WriteLine($"Here are the parameters recieved: {firstParam},{secondParam}")

        End Sub
    End Class
End Module
