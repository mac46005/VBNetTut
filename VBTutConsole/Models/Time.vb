Public Class Time
    ' private member variables
    Private Year As Integer
    Private Month As Integer
    Private Day As Integer
    Private Hour As Integer
    Private Minute As Integer
    Private Second As Integer

    ' public accessors methods
    Public Sub DisplayCurrentTime()
        Console.WriteLine($"{Month}/{Day}/{Year}  {Hour}:{Minute}:{Second}")
    End Sub

    ' constructors 
    Public Sub New(ByVal dt As System.DateTime)
        Year = dt.Year
        Month = dt.Month
        Day = dt.Day
        Hour = dt.Hour
        Minute = dt.Minute
        Second = dt.Second
    End Sub

    Public Sub New(year As Integer, month As Integer, day As Integer, hour As Integer, minute As Integer, second As Integer)
        Me.Year = year
        Me.Month = month
        Me.Day = day
        Me.Hour = hour
        Me.Minute = minute
        Me.Second = second
    End Sub




End Class
