Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Adja meg a számot: ")
        Dim n As Integer = Console.ReadLine()
        Dim fakt = 1
        Dim i
        For i = 1 To n
            fakt = fakt * i
        Next
        Console.WriteLine(n & "! = " & fakt)
    End Sub
End Module
