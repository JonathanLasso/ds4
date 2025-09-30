
namespace Laboratorio_8
{
    internal class Persona
    {
        //Campo de cada objeto Persona que almacena su nombre
        public string nombre;
        //Campo de cada objeto Persona que almacena su edad
        public int edad;
        //Campo de cada objeto Persona que almacena su NIF
        public string nif;

        void cumpleaños() //Incrementa en uno de edad del objeto Persona
        {
            edad++;
        }

        //Constructor de Persona
        public Persona(string nombre, int edad, string nif)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nif = nif;
        }

    }
}
