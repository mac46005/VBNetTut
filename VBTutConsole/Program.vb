Option Strict Off
Imports System.Console
Module Program

    Public Class Bitch
        Public Weight As Integer
    End Class
    Public Class Tester
        Public Shared Sub Main()
            Dim testobject As New Tester()
            testobject.Run()

        End Sub
        Public Sub Run()
            'created an integer
            Dim firstInt As Integer = 5

            ' create a second integer
            Dim secondInt As Integer = firstInt

            ' display the two integers
            Console.WriteLine($"firstInt: {firstInt}, secondInt: {secondInt}")

            ' modify the second integer 
            secondInt = 7

            ' display the two integers
            Console.WriteLine($"firstInt: {firstInt}, secondInt: {secondInt}")

            ' create dog
            Dim bitch As New Bitch()

            ' assign a value to weight
            bitch.Weight = 3

            ' create a second reerence to the bitch
            Dim bitchTwo As Bitch = bitch

            ' display thier values
            Console.WriteLine($"bitch: {bitch.Weight}, bitchTwo: {bitchTwo.Weight}")
            bitchTwo.Weight = 7

            ' display the two values
            Console.WriteLine($"bitch: {bitch.Weight}, bitchTwo: {bitchTwo.Weight}")


        End Sub
    End Class
End Module
