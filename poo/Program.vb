Imports System

Module Program
Public class gato

    Public Cor As String
    Public Raca As String
    Public Nome As String

    Public Sub Miar()
        Console.WriteLine("miau miau")
    End sub  

     Public Sub Ronronar()
        Console.WriteLine("rrruuu rrruuu")
    End sub  

End Class    

    Sub Main(args As String())
       Dim Cat As new gato()

        Cat.Cor = "Amarelo"
        Cat.Raca = "Maine Coon"
        Cat.Nome = "Xenao"
        
        Console.WriteLine(Cat.Cor)
        Console.WriteLine(Cat.Raca)
        Console.WriteLine(Cat.Nome)

        Cat.Miar()
        Cat.Ronronar()

    End Sub
End Module
