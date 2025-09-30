using Laboratorio_8;

internal class Program
{
    public static void Main(string[] args)
    {
        Trabajador p = new Trabajador("Josan", 22, "77588260-z", 100000);
        Console.WriteLine("Nombre="+p.nombre);
        Console.WriteLine("Edad="+p.edad);
        Console.WriteLine("NIF="+p.nif);
        Console.WriteLine("Sueldo="+p.sueldo);
        Console.ReadKey();
    }
}