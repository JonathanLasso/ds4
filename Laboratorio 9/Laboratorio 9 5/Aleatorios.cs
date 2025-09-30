namespace Laboratorio_9_5
{
    //Utilizo la misma clase llamada aleatorios pero con una modificacion que es que no se repitan los numeros.

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

            //Declaro una variable valor que almacena el numero generado aleatoriamente.
            int valor;

            for (int i = 0; i < cantidad; i++) //Use el for para generar el arreglo de numeros aleatorios.
            {
                while (true) //Utilizo el while(true) para no salir hasta que el arreglo no tenga numeros repetidos
                {
                    valor = generarUnNumero(minimo, maximo); // Aqui almaceno el valor del numero generado aleatorio.
                    bool repetido = false; //Declaro una variable llamado repetido de tipo booleano para verificar cuando esta repetido el valor.

                    //Uso el for para recorrer el arreglo y verificar si hay algun valor repetido.
                    for (int j = 0; j < i; j++)
                    {
                        if (numeros[j] == valor) //Verifico si en el arreglo hay un valor repetido.
                        {
                            repetido = true; //si hay un valor repetido pongo el valor de false a true en la variable repetido
                            break; // Uso el break para salir del for
                        }
                    }

                    if (!repetido) //Verifico cuando la variable repetido es false
                    {
                        numeros[i] = valor; //Aqui almaceno el valor no repetido en el arreglo.
                        break; // salgo del while(true) porque ya encontré un número válido
                    }
                }
            }
            return numeros; //Aqui retorno la referencia del arreglo.
        }
    }
}
