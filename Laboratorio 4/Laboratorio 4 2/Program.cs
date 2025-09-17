internal class Program
{
    static void Main (string[] args)
    {
        int fact = 1, n;
        string linea;

        Console.Write("Ingrese un numero entero: ");
        linea = Console.ReadLine();
        n = int.Parse(linea);
        for(int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        Console.Write("La factorial es: " + fact);
        Console.ReadKey();
    }
}
