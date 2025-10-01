Public Class Perro

    Public nombre As String
    Public raza As String
    Public altura As String

    Public Function comer(carne As String) As String
        Return nombre + " mide " + altura + " y comerá " + carne
    End Function

    Public Sub dormir()

    End Sub

    Public Sub ladrar()

    End Sub

    Public Function calcularCosto(Costo As Double, impuesto As Double) As Double
        Dim precioTotal As Double
        precioTotal = Costo + (Costo * impuesto)
        Return precioTotal
    End Function

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub
End Class
