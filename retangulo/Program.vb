Imports System

Module Program
    Sub Main(args As String())
        dim base As Double 
        dim altura As Double
        dim area As Double
        
        console.writeline ("digite o número da base:")
        base = console.readline( )

        console.writeline("digite a altura:")
        altura = console.readline( )

        area = base*altura
        console.writeline(" área do triângulo é:" & area)
        
    End Sub
End Module

