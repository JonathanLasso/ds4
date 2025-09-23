internal class Program
{
    private int[] sueldos;
    public void cargar()
        {
          sueldos = new int[6];
          for (int f = 1; f<=5; f++)
            {
              Console.Write("Ingrese sueldo del operario " + f + ": ");
              String linea;
              linea = Console.ReadLine();
              sueldos[f] = int.Parse(linea);
            }
        }

    public void imprimir()
    {
        Console.Write("Los 5 sueldos de los operarios \n");
        for(int f = 1; f<=5;f++)
        {
            Console.Write("["+sueldos[f]+"]");
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Program pv = new Program();
        pv.cargar();
        pv.imprimir();
    }
}
