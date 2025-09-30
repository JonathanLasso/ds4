namespace Laboratorio_8_5
{
    internal partial class Coordenadas
    {
        private int x;
        private int y;

        public Coordenadas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    internal partial class Coordenadas
    {
        public void verCoordenadas()
        {
            Console.WriteLine("Coordenadas: {0},{1}", x, y);
        }
    }
}
