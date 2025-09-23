internal class Program
{
    private static void Main(string[] args)
    {
        List<int> calificaciones = new List<int> { 85, 90, 70, 92, 88 };

        int suma = 0;

        foreach( int calicacion in calificaciones)
        {
            suma += calicacion;
        }

        int promedio = suma / calificaciones.Count;

        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}