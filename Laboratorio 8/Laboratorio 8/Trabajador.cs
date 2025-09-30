namespace Laboratorio_8
{
    internal class Trabajador : Persona
    {
        //Campo de cada objeto Trabajador que almacena cuánto gana
        public int sueldo;

        public Trabajador(string nombre, int edad, string nif, int sueldo)
            : base(nombre, edad, nif)
        {   //Inicializamos cada trabajador en base al constructor de Persona
            this.sueldo = sueldo;
        }
    }
}
