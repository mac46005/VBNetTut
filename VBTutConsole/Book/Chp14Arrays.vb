﻿Namespace Chp14Arrays
    Public Class Employee
        ' adding predefined values in an array
        Dim myIntArray1() As Integer = {2, 3, 4, 5, 6, 7}
        Dim myIntArray2() As Integer = New Integer(4) {2, 3, 4, 5, 6}



        Private _empId As Integer
        ' constructor
        Public Sub New(empId As Integer)
            _empId = empId
        End Sub

        Public Overrides Function ToString() As String
            Return _empId.ToString()
        End Function
    End Class


    Public Class ArrayExamples
        Public Shared Sub DisplayVals(ByVal ParamArray intVals() As Integer)
            For Each i As Integer In intVals
                Console.WriteLine($"DisplayVals {i}")
            Next
        End Sub ' DisplayVals

        Public Shared Sub Example14_5()
            Dim a As Integer = 5
            Dim b As Integer = 6
            Dim c As Integer = 7
            Console.WriteLine("Calling with three integers")
            DisplayVals(a, b, c)

            Console.WriteLine("Calling with four integers")
            DisplayVals(3, 4, 5, 6)

            Console.WriteLine("Calling with an array of four integers")
            Dim explicitArray() As Integer = {33, 4, 5, 6}
            DisplayVals(explicitArray)
        End Sub
        Public Shared Sub TwoDimensionalArray()
            Const rowsUB As Integer = 4
            Const columnUB As Integer = 3

            ' declare a 4x3 Integer array
            Dim rectangularArray(rowsUB, columnUB)


            ' populate the array
            Dim i As Integer
            For i = 0 To rowsUB - 1
                Dim j As Integer
                For j = 0 To columnUB - 1
                    rectangularArray(i, j) = i + j
                Next
            Next



            ' repost the contents of the array
            For i = 0 To rowsUB - 1
                Dim j As Integer
                For j = 0 To columnUB - 1
                    Console.WriteLine($"rectangularArray[{i},{j}] = {rectangularArray(i, j)}")
                Next
            Next


            ' a two dimensional array being initialized immediately
            Dim anotherRectangularArray(,) As Integer = {{2, 3}, {3, 4}, {4, 5}}

        End Sub


        Public Shared Sub JaggedArrayExample()
            Const rowsUB As Integer = 3 ' upper bounds
            Const rowZero As Integer = 5
            Const rowOne As Integer = 2
            Const rowTwo As Integer = 3
            Const rowThree As Integer = 5

            Dim i As Integer
            ' declare the jagged array as 4 rows high
            Dim jaggedArray(rowsUB)() As Integer

            ' declare the rows of various lengths
            ReDim jaggedArray(0)(rowZero)
            ReDim jaggedArray(1)(rowOne)
            ReDim jaggedArray(2)(rowTwo)
            ReDim jaggedArray(3)(rowThree)



            ' Fill some (but not all) elements of the rows
            jaggedArray(0)(3) = 15
            jaggedArray(1)(1) = 12
            jaggedArray(2)(1) = 9
            jaggedArray(2)(2) = 99
            jaggedArray(3)(0) = 10
            jaggedArray(3)(1) = 11
            jaggedArray(3)(2) = 12
            jaggedArray(3)(3) = 13
            jaggedArray(3)(4) = 14




            For i = 0 To rowZero
                Console.WriteLine($"jaggedArray(0)({i}) = {jaggedArray(0)(i)}")
            Next

            For i = 0 To rowOne
                Console.WriteLine($"jaggedArray(1)({i}) = {jaggedArray(1)(i)}")
            Next

            For i = 0 To rowTwo
                Console.WriteLine($"jaggedArray(2)({i}) = {jaggedArray(2)(i)}")
            Next

            For i = 1 To rowThree
                Console.WriteLine($"jaggedArray(3)({i}) = {jaggedArray(3)(i)}")
            Next
        End Sub
    End Class 'ArrayExamples
End Namespace


Namespace ReverserAndSort
    Class SortReverseDemo
        Public Shared Sub DisplayArray(ByVal theArray() As Object)
            Dim obj As Object
            For Each obj In theArray
                Console.WriteLine($"Value: {obj}")
            Next
            Console.WriteLine(ControlChars.Lf)
        End Sub

        Public Sub Run()
            Dim myArray As String() = {"who", "is", "John", "Galt"}

            Console.WriteLine("Display myArray")
            DisplayArray(myArray)

            Console.WriteLine("Reverse and display myArray")
            Array.Reverse(myArray)
            DisplayArray(myArray)


            Dim myOtherArray As String() = {"We", "Hold", "These", "Truths", "To", "Be", "Self", "Evident"}

            Console.WriteLine("Display myOtherArray...")
            Array.Sort(myOtherArray)
            DisplayArray(myOtherArray)
        End Sub
    End Class
End Namespace
