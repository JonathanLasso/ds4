internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(suma(1, 2));
        Console.WriteLine(suma(1.0, 2.2));
        Console.WriteLine(suma(11111111111111, 2222222222222));

    }

    static int suma(int x, int y)
    {
        return x + y;
    }

    static double suma(double x, double y)
    {
        return x + y;
    }

    static long suma(long x, long y)
    {
        return x + y;
    }
}