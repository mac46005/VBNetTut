Public Interface IStorable
    Sub Read()
    Sub Write(obj As Object)
    Property Status() As Integer
End Interface
