using Laboratorio_8_8;

internal class Program
{
    private static void Main(string[] args)
    {
        ClaseConcretal concretal = new ClaseConcretal();
        concretal.printOut();
        Console.WriteLine(concretal.prefixValor("ES_"));

        ClaseConcretal2 concretal2 = new ClaseConcretal2();
        concretal2.printOut();
        Console.WriteLine(concretal2.prefixValor("ES_"));
    }
}