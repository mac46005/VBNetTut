Imports System.Text

Namespace Chapter16
    Public Class CompareStringDemo
        Public Sub Run()
            ' create some Strings to work with
            Dim s1 As String = "abcd"
            Dim s2 As String = "ABCD"

            Dim result As Integer ' hold the result of comparisons
            ' compare the two strings, case sensitive
            result = String.Compare(s1, s2) ' result = -1
            Console.WriteLine($"compare s1: {s1}, s2: {s2} => Results: {result}")

            ' overloaded compare, takes boolean "ignore case"
            ' (true = ignore case)
            result = String.Compare(s1, s2, True) ' result = 0
            Console.WriteLine($"Compare insensitive. Result: {result}")



        End Sub
    End Class

    Public Class ConcatenateDemo
        Public Sub Run()
            Dim s1 As String = "abcd"
            Dim s2 As String = "ABCD"
            ' concatenation method
            Dim s3 As String = String.Concat(s1, s2)
            Console.WriteLine($"s3 concatenated from s1 and s2: {s3}")

            ' use the overloaded operator
            Dim s4 As String = s1 & s2
            Console.WriteLine($"s4 concatenated from s1 & s2: {s4}")
        End Sub
    End Class

    Public Class CopyStringDemo
        Public Sub Run()
            Dim s2 As String = "abcd"
            Dim s3 As String = "ABCD"


            ' the String copy method
            Dim s4 As String = String.Copy(s2)
            Console.WriteLine($"s4 copied from s2: {s4}")


            ' use the overloaded operator
            Dim s5 As String = s4
            Console.WriteLine($"s5 = s4: {s5}")
        End Sub
    End Class

    Public Class StringEqualsDemo
        Public Sub Run()
            Dim s1 As String = "abcd"
            Dim s2 As String = "ABCD"

            ' the string copy method
            Dim s5 As String = String.Copy(s2)
            Console.WriteLine($"s5 copied from s2: {s5}")

            ' copy with the overloaded operator
            Dim s6 As String = s5
            Console.WriteLine($"s6 = s5: {s6}")

            ' member method
            Console.WriteLine($"Does s6.Equals(s5)?: {s6.Equals(s5)}")

            ' shared method
            Console.WriteLine($"Does String.Equals(s5,s6)?: {String.Equals(s5, s6)}")


        End Sub
    End Class

    Public Class OtherMethodsDemo
        Public Sub Run()
            Dim s1 As String = "abcd"
            Dim s2 As String = "ABCD"
            Dim s3 As String = "Liberty Associates, Inc. provides"

            s3 = s3 & "custom .Net development"

            ' the String copy method
            Dim s5 As String = String.Copy(s2)
            Console.WriteLine($"s5 copied from s2: {s5}")

            ' The length
            Console.WriteLine($"String s3 is {s3.Length} characters long")

            Console.WriteLine()
            Console.WriteLine($"s3: {s3}")
            ' test whether a String ends with a set of characters
            Console.WriteLine($"s3 ends with Training?: {s3.EndsWith("Training")}")
            Console.WriteLine($"s2 ends with development?: {s3.EndsWith("development")}")


            Console.WriteLine()
            ' return the index of the string
            Console.WriteLine($"The first occurrence of provides")
            Console.WriteLine($"in s3 is {s3.IndexOf("provides")}")

            ' hold the location of provides as an integer
            Dim location As Integer = s3.IndexOf("provides")

            ' insert the word usually before "provides"
            Dim s10 As String = s3.Insert(location, "usually")
            Console.WriteLine($"s10: {s10}")

            ' you can combine the two as follows:
            Dim s11 As String = s3.Insert(s3.IndexOf("usually") + 1, 9) = "always!"

            Console.WriteLine($"s11 now: {s11}")
        End Sub
    End Class

    Public Class SubStringDemo
        Public Sub run()
            ' create some strings to work with
            Dim s1 As String = "One Two Three Four"

            Dim index As Integer
            ' get the index of the last space

            index = s1.LastIndexOf(" ")
            ' get the last word
            Dim s2 As String = s1.Substring(index + 1)

            ' det s1 to the substring starting at 0
            ' and ending at index (the start of the last word)
            ' thus s1 has One Two Three
            s1 = s1.Substring(0, index)

            ' find the last space in s1 (after "Two")
            index = s1.LastIndexOf(" ")

            ' set s3 to the substring starting at
            ' index, the space after "Two" plus one more
            ' thus s3 = "three"
            Dim s3 As String = s1.Substring(index + 1)

            ' reset s1 to the substring starting at 0
            ' and ending at index, thus the String "One Two"
            s1 = s1.Substring(0, index)

            ' reset index to the space between
            ' "One" and "Two"
            index = s1.LastIndexOf(" ")

            ' set s4 to the substring starting one
            ' space after index, thus the substring "Two"
            Dim s4 As String = s1.Substring(index + 1)

            ' reset s1 to the subtring starting at 0
            ' and ending at index, thus "One"
            s1 = s1.Substring(0, index)

            ' set index to the last space, but there is
            ' none so index now = -1
            index = s1.LastIndexOf(" ")

            ' set s5 to the substring at one past
            ' the last space. There was no last space
            ' so this sets s5 to the substring starting at
            ' zero
            Dim s5 As String = s1.Substring(index + 1)

            Console.WriteLine($"s1: {s1}")
            Console.WriteLine($"s2: {s2}")
            Console.WriteLine($"s3: {s3}")
            Console.WriteLine($"s4: {s4}")
            Console.WriteLine($"s5: {s5}")
        End Sub
    End Class

    Public Class SplitStringDemo
        Public Sub Run()
            ' create some strings to work with
            Dim s1 As String = "One,Two,Three Libery Associates, Inc."

            ' constants for the space and comma characters
            Const Space As Char = " "c ' notice that c or C is used to establish that these characters, are not strings
            Const Comma As Char = ","c

            ' array of delimiters to split the sentence with
            Dim delimiters() As Char = {Space, Comma}

            Dim output As String = ""
            Dim ctr As Integer = 0

            ' split the String then iterate over the
            ' resulting array of strings
            Dim resultArray As String() = s1.Split(delimiters)

            For Each subString As String In resultArray
                ctr = ctr + 1
                output &= ctr.ToString()
                output &= ": "
                output &= subString
                output &= Environment.NewLine
            Next
            Console.WriteLine(output)
        End Sub

    End Class

    Public Class StringBuilderDemo
        Public Sub Run()
            ' create some strings to work with
            Dim s1 As String = "One,Two,Three Liberty Associates, Inc."

            ' constants for the space and comma characters
            Const Space As Char = " "c
            Const Comma As Char = ","c

            ' array of delimiters to split the sentece with
            Dim delimiters() As Char = {Space, Comma}

            Dim output As New StringBuilder()
            Dim ctr As Integer = 0

            ' split the String and then iterate over the 
            ' result array of Strings
            Dim resultArray As String() = s1.Split(delimiters)

            For Each subString As String In resultArray
                ctr = ctr + 1
                output.AppendFormat($"{ctr} : {subString}" + Environment.NewLine)
            Next subString

            Console.WriteLine(output)
        End Sub

    End Class
End Namespace
