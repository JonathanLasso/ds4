internal class Program
{
    public static void Main(string[] args)
    {
        int resultado;

        CalcularPerimetro c = new CalcularPerimetro();

        Console.WriteLine("Introduzca el largo del rectangulo: ");
        c.largo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca el ancho del rectangulo: ");
        c.ancho = Convert.ToInt32(Console.ReadLine());

        resultado = c.CalcularPerimetroRectangulo(c.ancho, c.largo);

        Console.WriteLine("El perimetro del rectangulo es: {0}", resultado);
    }

    public class CalcularPerimetro
    {
        public int ancho
        {
            get; set;
        }
        public int largo
        {
            get; set;
        }

        public int CalcularPerimetroRectangulo(int ancho, int largo)
        {
            return 2 * (largo + ancho);
        }
    }
}
