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

        End Class
    End Class
End Namespace
