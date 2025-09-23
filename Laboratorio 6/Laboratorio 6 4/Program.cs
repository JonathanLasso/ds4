internal class Program
{
    static void cheackAge (int age)
    {
        if(age < 10)
        {
            throw new ArithmeticException("Acceso negado - No cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("Acceso Consedido");
        }
    }
    static void Main(string[] args)
    {
        cheackAge(15);
        cheackAge(5);
    }
}