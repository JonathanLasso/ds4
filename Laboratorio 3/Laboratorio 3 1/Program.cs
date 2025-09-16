internal class Program
{
    public static void Main (string[] args)
    {
        int resultado;

        CalculosMatematicos c = new CalculosMatematicos();

        Console.WriteLine("Introduzca el primer numero: ");
        c.numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca el segundo numero: ");
        c.numero2 = Convert.ToInt32(Console.ReadLine());

        resultado = c.Calcular(c.numero1, c.numero2);

        Console.WriteLine("El resultado de {0} y {1} es {2}", c.numero1, c.numero2, resultado) ;
    }

    public class CalculosMatematicos
    {
        public int numero1
        {
            get; set;
        }
        public int numero2
        {
            set; get;
        }

        public int Calcular (int numero1, int numero2)
        {
            return (numero1 + numero2) * (numero1 - numero2);
        }
    }
}
