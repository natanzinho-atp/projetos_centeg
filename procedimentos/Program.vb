Imports System

Module Program
    

    Function Somar(a As Integer, b As Integer) As Integer
        Return a+b
    End Function

    Sub Main(args As String())
        Dim n1,n2, resultado As Integer

        Console.WriteLine("Digite um número")
        n1 = Console.ReadLine()

        Console.WriteLine("Digite outro Número")
        n2 = Console.ReadLine()

        resultado = Somar(n1, n2)
        Console.WriteLine(resultado)
        

        Console.WriteLine(resultado)     
    End Sub
End Module
