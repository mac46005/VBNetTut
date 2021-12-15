Namespace My.Structures
    Public Structure Location
        Private myXVal As Integer
        Private myYVal As Integer
        ' constructor
        Public Sub New(xCoordinate As Integer, yCoordinate As Integer)
            myXVal = xCoordinate
            myYVal = yCoordinate
        End Sub

        ' property
        Public Property XVal() As Integer
            Get
                Return myXVal
            End Get
            Set(value As Integer)
                myXVal = value
            End Set
        End Property

        Public Property YVal() As Integer
            Get
                Return myYVal
            End Get
            Set(value As Integer)
                myYVal = value
            End Set
        End Property
        ' display the structure as a string
        Public Overrides Function ToString() As String
            Return [String].Format("{0},{1}", XVal, YVal)
        End Function
    End Structure
End Namespace