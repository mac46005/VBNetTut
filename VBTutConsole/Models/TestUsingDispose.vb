Public Class TestingDisposing
    Implements IDisposable
    Dim is_disposed As Boolean = False


    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not is_disposed Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
                Console.WriteLine("Not in destructor, OK to reference other objects.")
            End If
            ' perform cleanup for this object
            Console.WriteLine("Disposing...")
            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            is_disposed = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
