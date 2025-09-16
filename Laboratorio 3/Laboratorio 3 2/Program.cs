internal class Program
{
    public static void Main(string[] args)
    {
        CalculosMatematicos c = new CalculosMatematicos();

        double resultado;

        Console.WriteLine("Introduzca el valor de la radio del circulo:  ");
        c.numero1 = Convert.ToDouble(Console.ReadLine());

        resultado = c.CalculoArea(c.numero1);

        Console.WriteLine("El area del circulo del valor de la radio {0} es de {1}", c.numero1, resultado);
    }

    public class CalculosMatematicos
    {
        public double numero1
        {
            get; set;
        }
        public double numero2
        {
            set; get;
        }

        public double Calcular(double numero1, double numero2)
        {
            return (numero1 + numero2) * (numero1 - numero2);
        }

        public double CalculoArea (double numero1)
        {
            return Math.PI * numero1 * numero1;
        }  
    }
}
