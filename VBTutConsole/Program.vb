Option Strict On
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim castIn As Integer = CInt("5")
        Dim castBool As Boolean = CBool(0)
        Dim castByte As Byte = CByte("255")
        Dim castChar As Char = CChar("The End")
        Dim castDate As Date = CDate("11/12/2021")
        Dim castLong As Long = CLng("5000000000")
        Dim castObj As Object = CObj(Nothing)
        Dim castShort As Short = CShort(0.33)
        Dim castString As String = CStr(True)
        Dim castType As Integer = CType(Tempatures.BoilingPoint, Integer)
    End Sub


End Module
