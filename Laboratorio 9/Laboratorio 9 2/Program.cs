internal class Program
{
    private static void Main(string[] args)
    {
        //Uso un for para recorrer los numeros del 1 al 100.
        for (int i = 1; i <= 100; i++)
        {
            if(i % 2 == 0 || i % 3 == 0) //Valido que los numeros que se impriman se han pares o divisibles entre 3
            {
                Console.WriteLine(i); //Imprimo los numeros.
            }
        }
    }
}