Namespace Chapter17
    Public Class UnHandledExceptionDemo
        Public Sub Run()
            Console.WriteLine($"Enter {NameOf(UnHandledExceptionDemo)}.Run()...")
            Func1()
            Console.WriteLine($"Exit {NameOf(UnHandledExceptionDemo)}.Run()...")
        End Sub

        Public Sub Func1()
            Console.WriteLine($"Enter {NameOf(UnHandledExceptionDemo)}.Func1()....")
            Func2()
            Console.WriteLine($"Exit {NameOf(UnHandledExceptionDemo)}.Fun1()...")
        End Sub
        Public Sub Func2()
            Console.WriteLine($"Enter {NameOf(UnHandledExceptionDemo)}.Func2()...")
            Throw New Exception()
            Console.WriteLine($"Exit {NameOf(UnHandledExceptionDemo)}.Func2()...")
        End Sub
    End Class

    Public Class TryCatchDemo
        Public Sub Run()
            Console.WriteLine("Enter Run...")
            Func1()
            Console.WriteLine("Exit Run...")
        End Sub
        Public Sub Func1()
            Console.WriteLine("Enter Func1...")
            Func2()
            Console.WriteLine("Exit Func1...")
        End Sub
        Public Sub Func2()
            Console.WriteLine("Enter Func2...")
            Try
                Console.WriteLine("Entering Try Block...")
                Throw New Exception()
                Console.WriteLine("Exiting Try Block...")
            Catch ex As Exception
                Console.WriteLine("Exception caught and handled")
            End Try
            Console.WriteLine("Exit Func2...")
        End Sub

    End Class
    Public Class ThreeDedicatedCatchStatementsDemo
        Public Sub Run()
            Try
                Dim a As Double = 5
                Dim b As Double = 0
                Console.WriteLine($"Dividing {a} by {b}...")
                Console.WriteLine($"{a}/{b} = {DoDivide(a, b)}")
            Catch ex As DivideByZeroException
                Console.WriteLine("DivideByZeroException caught!")
            Catch ex As ArithmeticException
                Console.WriteLine("ArithmeticException caught!")
                ' generic exception type last
            Catch
                Console.WriteLine("Unkown Exception Caught!")
            End Try
        End Sub

        ' do the division if legal
        Public Function DoDivide(a As Double, b As Double) As Double
            If b = 0 Then
                Throw New System.DivideByZeroException()
            End If
            If a = 0 Then
                Throw New System.ArithmeticException()
            End If
            Return a / b
        End Function
    End Class
    Public Class FinallyDemo
        Public Sub Run()
            Try
                Console.WriteLine("Open the file here")
                Dim a As Double = 5
                Dim b As Double = 0

                Console.WriteLine($"{a}/{b} = {DoDivide(a, b)}")

                ' most derived exception type first
            Catch ex As DivideByZeroException
                Console.WriteLine("Unknown exception caught!")
            Catch
                Console.WriteLine("Unknown exception caught!")
            Finally
                Console.WriteLine("Close file here.")
            End Try
        End Sub

        ' do the division if legal
        Public Function DoDivide(a As Double, b As Double) As Double
            If b = 0 Then
                Throw New DivideByZeroException()
            End If
            If a = 0 Then
                Throw New ArithmeticException()
            End If
            Return a / b
        End Function

    End Class


    Public Class UsingExceptionDemo
        Public Sub Run()
            Try
                Console.WriteLine("Open file here")
                Dim a As Double = 5
                Dim b As Double = 0
                Console.WriteLine($"{a}/{b} {DoDivide(a, b)}")
            Catch ex As DivideByZeroException
                Console.WriteLine($"DivideByZeroException! msg: {ex.Message}")
                Console.WriteLine(ex.HelpLink)
                Console.WriteLine(ex.StackTrace)
            Catch
                Console.WriteLine("unknown exception caught!")
            End Try

        End Sub
        ' do the division if legal
        Public Function DoDivide(a As Double, b As Double) As Double
            If b = 0 Then
                Dim e As New DivideByZeroException()
                e.HelpLink = "http://www.LibertyAssociates.com"
                Throw e
            End If
            If a = 0 Then
                Throw New ArithmeticException
            End If
            Return a / b
        End Function
    End Class


    Public Class MyCustomException : Inherits ApplicationException
        Public Sub New(message As String)
            ' pass the message up to the base class
            MyBase.New(message)
        End Sub
    End Class
    Public Class TestCustomException
        Public Sub Run()
            Console.WriteLine("Open file here")
            Dim a As Double = 0
            Dim b As Double = 5

            Console.WriteLine($"{a}/{b} = {}")
        End Sub
        ' do the division if legal
        Public Function DoDivide(a As Double, b As Double) As Double
            If b = 0 Then
                Dim e As New DivideByZeroException()
                e.HelpLink = "http://wwwlibertyassociates.com"
                Throw e
            End If
            If a = 0 Then
                ' create a custom exception instance
                Dim e As New MyCustomException("Can't have zero divisor")
                e.HelpLink = "http://www.libertyassociates.com/NoZeroDivisor.htm"
                Throw e
            End If
            Return a / b
        End Function
    End Class
End Namespace
