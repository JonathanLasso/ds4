namespace Laboratorio_9_4
{
    //Cree una clase llamada Aleatorios. 
    internal class Aleatorios
    {
        //Declare un atributo llamado random de la clase Random.
        public Random random;
        
        public Aleatorios() // Cree el constructor.
        {
            random = new Random(); //Inicialice el atributo random.
        }

        // Cree un metodo que retornar un int para generar un numero aleatorio con dos parametros el minimo y maximo.
        public int generarUnNumero(int minimo, int maximo) 
        {
            int numero; //Declare una variable llamada numero para guardar el numero generado.

            //Aqui uso el atributo que cree con la clase Random use la funcion Next que me genera un numero aleatorio con un rango minimo y maximo.
            numero = random.Next(minimo, maximo + 1); 

            return numero;// Retorno el valor del numero generado.
        }

        //Cree un metodo que retornar una direccion de un arreglo generado por numeros aleatorios.
        //Tiene tres parametros que son la cantidad para el arreglo, el rango minimo y maximo para generar los numeros aleatorios.
        public int[] generarUnArregoNumeros(int cantidad, int minimo, int maximo) 
        {
            //Declaro e inicializo el arreglo llamado numeros. Teniendo el tamaño del arreglo recibida por el parametro de cantidad.
            int[] numeros = new int[cantidad]; 

            for(int i = 0; i < cantidad; i++) //Use el for para generar el arreglo de numeros aleatorios.
            {
                numeros[i] = generarUnNumero(minimo, maximo); //Aqui almaceno los numeros generados aleatoriamentes llamando el metodo generarUnNumero().
            }

            return numeros; //Aqui retorno la referencia del arreglo.

        }
    }
}
