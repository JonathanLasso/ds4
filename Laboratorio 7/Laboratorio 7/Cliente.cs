namespace Laboratorio_7
{
    internal class Cliente
    {
        private string nombre;
        private int monto;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            monto = 0;
        }

        public void depositar(int monto)
        {
            this.monto = this.monto + monto;
        }

        public void extraer (int monto)
        {
            this.monto = this.monto - monto;
        }

        public int retornarMonto()
        {
            return monto;
        }

        public void imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }
}
