Option Strict Off
Imports System.Console
Module Program
    Public Class Tester
        Public Shared Sub Main()
            Dim test As New Tester()

            test.Run()
        End Sub

        Public Sub Run()
            Console.WriteLine("Start of Run()")

            ' declare a cat and initialize to 5
            Dim theVariable = New Cat(5)

            Console.WriteLine($"The variable: {theVariable}")

            ' call a method and pass in the variable
            Doubler(theVariable)

            Console.WriteLine("Returned to run()")
            Console.WriteLine($"The variable on return : {theVariable}")
            Console.WriteLine("End of run()")


        End Sub

        Public Sub Doubler(cat As Cat)
            ' display the value that was passed in
            Console.WriteLine($"In Double(). Recieved param:{cat}")

            ' double the value
            cat.Weight *= 2

            ' display the doubled value before returning

            Console.WriteLine($"Before return cat: {cat}")

            Console.WriteLine("End of Doubler")
        End Sub
    End Class
End Module
