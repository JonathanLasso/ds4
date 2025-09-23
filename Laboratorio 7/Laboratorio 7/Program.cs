using Laboratorio_7;

internal class Program
{
    static void Main(string[] args)
    {
        Banco banco = new Banco();
        banco.operar();
        banco.depositosTotales();
        Console.ReadKey();
    }
}