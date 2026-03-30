Imports System

Module Program
    Sub Main(args As String())
        
        Dim alunos As new list (Of String)
        Dim quantidade As Integer
        Dim nome As String

        Console.WriteLine("Quantos alunos iram ser cadastrados ")
        quantidade = Integer.Parse(Console.ReadLine())

        for i as Integer = 1 to quantidade  
        Console.Write("Digite o nome do aluno:")
        nome = Console.ReadLine()
        alunos.Add(nome)
        next 

        for each aluno In alunos
            Console.WriteLine(alunos)
        next
    End Sub
End Module
