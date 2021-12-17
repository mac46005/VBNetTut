Namespace Chapter15
    Public Class ListBoxTest : Implements IEnumerable
        Private strings() As String
        Private ctr As Integer = 0

        ' private nested implementation of ListboxEnumerator
        Private Class ListBoxEnumerator : Implements IEnumerator
            ' member fields of the nested ListBoxEnumerator class
            Private currentListBox As ListBoxTest
            Private index As Integer

            ' public within the private implementation
            ' thus, private within ListBoxTest
            Public Sub New(currentListBox As ListBoxTest)
                ' a particular ListBoxTest instance is
                ' passed in, hold a reference to it
                ' in the member variable currentListBox
                Me.currentListBox = currentListBox
            End Sub

            ' Increment the index and make sure the
            ' value is valid
            Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
                index += 1
                If index >= currentListBox.strings.Length Then
                    Return False
                Else
                    Return True
                End If
            End Function

            Public Sub Reset() Implements IEnumerator.Reset
                index = -1
            End Sub


            ' current property defined as the
            ' last string added to the listbox
            Public ReadOnly Property Current() As Object Implements IEnumerator.Current
                Get
                    Return currentListBox(index)
                End Get
            End Property
        End Class ' end nested class

        ' Enumerable classes can return an enumerator
        Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return New ListBoxEnumerator(Me)
        End Function


        ' initialize the list box with strings
        Public Sub New(ParamArray initialStrings() As String)
            ' allocate space for strings
            ReDim strings(7)

            ' copy the strings passed in to the constructor
            For Each s As String In initialStrings
                strings(ctr) = s
                ctr += 1
            Next
        End Sub


        ' allow array-like access
        Default Public Property Item(index As Integer) As String
            Get
                If index < 0 Or index >= strings.Length Then
                    ' handle bad index
                    Exit Property
                End If
                Return strings(index)
            End Get
            Set(value As String)
                strings(index) = value
            End Set
        End Property

        ' publish how many strings you hold
        Public Function GetNumEntries() As Integer
            Return ctr
        End Function
    End Class

    ' a class o hold in the array list
    Public Class Employee
        Private myEmpId As Integer

        Public Sub New(empId As Integer)
            Me.myEmpId = empId
        End Sub ' new 

        Public Overrides Function ToString() As String
            Return myEmpId.ToString()
        End Function

        Public Property EmpId() As Integer
            Get
                Return myEmpId
            End Get
            Set(value As Integer)
                myEmpId = value
            End Set
        End Property
    End Class

    Public Class Tester
        Public Sub Run()
            Dim empArray As New ArrayList()
            Dim intArray As New ArrayList()

            ' populate the arrayLists
            For i = 0 To 4
                empArray.Add(New Employee(i + 100))
                intArray.Add(i * 5)
            Next

            ' print each member of the array
            For Each i In intArray
                Console.WriteLine($"{i}")
            Next

            Console.WriteLine(ControlChars.Lf)


            ' print each employee
            For Each e As Employee In empArray
                Console.WriteLine($"{e.ToString()}")
            Next

            Console.WriteLine(ControlChars.Lf)

            Console.WriteLine($"empArray.Capacity: {empArray.Capacity}")
        End Sub
    End Class
    Public Class CollectionTester
        Public Sub Run()
            Dim intCollection As New Collection()
            Dim empCollection As New Collection()
            Dim empCollection2 As New Collection()

            ' populate the collections
            Dim i As Integer
            For i = 0 To 4
                empCollection.Add(New Employee(i + 100))
                intCollection.Add(i * 500)
            Next

            ' add key/value pairs
            empCollection2.Add(New Employee(1789), "George Washington")
            empCollection2.Add(New Employee(1797), "John Adams")
            empCollection2.Add(New Employee(1801), "Thomas Jefferson")



            ' print each member of the array
            For Each int As Integer In intCollection
                Console.WriteLine(int.ToString())
            Next

            Console.WriteLine()
            Console.WriteLine("Employee collection...")
            For Each e As Employee In empCollection
                Console.WriteLine(e)
            Next

            Console.WriteLine()
            Console.WriteLine("Employee Collection 2...")
            For Each e As Employee In empCollection2
                Console.WriteLine(e)
            Next



            Console.WriteLine()

            ' retrieve an employee by key
            Dim emp As Employee
            emp = empCollection2.Item("John Adams")

            Console.WriteLine("Key John Adas retrieved empId {0}", emp)

            ' note that indexing is 1-based (rather than zero based)
            emp = empCollection2.Item(1)
            Console.WriteLine("Index(1) retreived empId {0}", emp)
        End Sub
    End Class


    Public Class QueueTester
        Public Sub Run()
            Dim intQueue As New Queue()
            ' populate the array
            Dim i As Integer
            For i = 0 To 4
                intQueue.Enqueue(i * 5)
            Next


            ' display the queue
            Console.WriteLine("intQueue values:")
            DisplayValue(intQueue)

            ' remove an element from the queue
            Console.WriteLine($"(Dequeue) {intQueue.Dequeue()}")

            ' display the queue
            Console.WriteLine("intQueue values:")
            DisplayValue(intQueue)


            ' Remove another element from the queue
            Console.WriteLine($"(Dequeue) {intQueue.Dequeue()}")


            ' diplay the queue
            Console.WriteLine($"intQueue values:")
            DisplayValue(intQueue)

            ' View the first element in the
            ' queue but do not remove
            Console.WriteLine($"(peek) {intQueue.Peek()}")

            ' display the queue
            Console.WriteLine("IntQueue value:")
            DisplayValue(intQueue)





        End Sub

        Public Shared Sub DisplayValue(myCollection As IEnumerable)
            Dim myEnumerator As IEnumerator = myCollection.GetEnumerator()

            While myEnumerator.MoveNext()
                Console.WriteLine($"{myEnumerator.Current}")
            End While
            Console.WriteLine()
        End Sub ' DisplayValues


    End Class

End Namespace
