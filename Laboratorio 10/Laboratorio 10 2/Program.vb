Imports System

Module area
    Sub Main(args As String())
        Dim radio As Single
        Dim area As Single
        Dim circunferencia As Single
        Const PI = 3.1415926

        Console.Write("Ingrese el radio: ")
        radio = Console.ReadLine

        area = PI * radio ^ 2

        circunferencia = 2 * PI * radio

        Console.WriteLine("El area es : {0}", area)
        Console.WriteLine("La circunferencia es {0}", circunferencia)

        Console.ReadKey()

    End Sub
End Module
