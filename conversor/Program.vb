Imports System

Module Program
    Sub Main(args As String())

        Dim ConversorValores As Double

        Dim resultado As Double

        Console.WriteLine("digite um valor")

        ConversorValores = Console.ReadLine() 

        resultado = ConversorValores / 1024

        Console.WriteLine("O resultado é" & resultado)

    End Sub
End Module
