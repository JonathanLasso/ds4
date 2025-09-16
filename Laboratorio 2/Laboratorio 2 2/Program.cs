internal class Program
{
    public static void Main(string[] args)
    {
        MyClass.valor = 1;
        Console.WriteLine(MyClass.valor);
    }

    public class MyClass
    {
        public static int valor;
    }
}
