Public Class TestUsingDispose
    Implements IDisposable
    Dim is_disposed As Boolean = False
    Protected Sub Dispose(ByVal disposing As Boolean)
        If Not is_disposed Then
            If disposing Then
                Console.WriteLine("Not in destructor, OK to reference other objects")
            End If
            ' perform cleanup for this object
            Console.WriteLine("Disposing...")

        End If
        Me.is_disposed = True
    End Sub


    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        ' tell the GC not to finalize
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
        Console.WriteLine("In destructor")
    End Sub
End Class
