Imports System

Module Program
    'criar uma lista
    Sub Main(args As String())
       ' Dim nomes As new List(Of String)
        
        'nomes.Add("Paula")
       ' nomes.Add("Natan")
        'nomes.Add("Erick")

        'percorrer a listae escreva os dados na tela
        'For each dado In nomes
        'console.writeLine(dado)            
        'Next 
        Dim nomes As new List(Of String)
        
        nomes.Add("Matemática")
        nomes.Add("Português")
        nomes.Add("Biologia")

        'percorrer a listae escreva os dados na tela
        For each dado In nomes
        console.writeLine(dado)            
        Next 

    End Sub
End Module
