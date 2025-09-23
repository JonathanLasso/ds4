namespace Laboratorio_7_2
{
    internal class Dado
    {
        private int valor;
        private static Random aleatorio;

        public Dado()
        {
            aleatorio = new Random();
        }

        public void tirar()
        {
            valor = aleatorio.Next(1,7);
        }

        public void imprimir()
        {
            Console.WriteLine("El valor del dado es: " + valor);
        }

        public int retornarValor()
        {
            return valor;
        }
    }
}
