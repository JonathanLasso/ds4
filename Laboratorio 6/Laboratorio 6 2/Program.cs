internal class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el numero deseado");

        try
        {
            num = Int16.Parse(Console.ReadLine());
        }catch (FormatException e)
        {
            Console.WriteLine("No se ha introducido un digito valido");
            num = -1;
        }catch (OverflowException a)
        {
            Console.WriteLine("El numero introducido es muy grande");
            num = -1;
        }

        Console.WriteLine(num);
    }
}