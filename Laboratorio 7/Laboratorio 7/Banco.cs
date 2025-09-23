using System.Timers;

namespace Laboratorio_7
{
    internal class Banco
    {

        private Cliente cliente1, cliente2, cliente3;

        public Banco()
        {
            cliente1 = new Cliente("Yhonas");
            cliente2 = new Cliente("Ana");
            cliente3 = new Cliente("Pedro");
        }

        public void operar()
        {
            cliente1.depositar(100);
            cliente2.depositar(150);
            cliente3.depositar(200);
            cliente3.extraer(150);
        }

        public void depositosTotales()
        {
            int total = cliente1.retornarMonto() +
                        cliente2.retornarMonto() + 
                        cliente3.retornarMonto();
            Console.WriteLine("El total de dinero en el banco es: " + total);
            cliente1.imprimir();
            cliente2.imprimir();
            cliente3.imprimir();
        }

    }
}
