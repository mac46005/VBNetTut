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


End Namespace
