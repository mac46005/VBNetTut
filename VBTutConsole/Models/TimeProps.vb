Public Class TimeProps
    Private _year As Integer
    Public Property Year() As Integer
        Get
            Return _year
        End Get
        Set(ByVal value As Integer)
            _year = value
        End Set
    End Property

    Private _month As Integer
    Public Property Month() As Integer
        Get
            Return _month
        End Get
        Set(ByVal value As Integer)
            _month = value
        End Set
    End Property

    Private _day As Integer
    Public Property Day() As Integer
        Get
            Return _day
        End Get
        Set(ByVal value As Integer)
            _day = value
        End Set
    End Property

    Private _hour As Integer
    Public Property Hour() As Integer
        Get
            Return _hour
        End Get
        Set(ByVal value As Integer)
            _hour = value
        End Set
    End Property

    Private _minute As Integer
    Public Property Minute() As Integer
        Get
            Return _minute
        End Get
        Set(ByVal value As Integer)
            _minute = value
        End Set
    End Property

    Private _second As Integer
    Public Property Second() As Integer
        Get
            Return _second
        End Get
        Set(ByVal value As Integer)
            _second = value
        End Set
    End Property


    ' public accessor methods
    Public Sub DisplayCurrentTime()
        Console.WriteLine($"{Month}/{Day}/{Year}/        {Hour}:{Minute}:{Second}")
    End Sub


    ' constructors
    Public Sub New(timeObject As System.DateTime)
        Year = timeObject.Year
        Month = timeObject.Month
        Day = timeObject.Day
        Hour = timeObject.Hour
        Minute = timeObject.Minute
        Second = timeObject.Second

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
