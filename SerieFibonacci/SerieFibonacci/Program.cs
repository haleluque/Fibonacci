using System;

namespace SerieFibonacci
{
    internal class Program
    {
        /// <summary>
        /// Método principal
        /// </summary>
        private static void Main()
        {
            //Se inicia el programa
            Console.WriteLine("Bienvenido al programa de generación de la serie de Fibonacci");

            //Se inician variables de manejo de programa
            var pr = new Program();
            var programa = 0;

            while (programa == 0)
            {
                /* Se ingresa el número hasta el cual se va a imprimir la serie de fibonacci */
                Console.WriteLine("Por favor ingrese el número hasta el cual se debe imprimir la serie de Fibonacci");
                var numDigitos = Console.ReadLine();

                try
                {
                    programa = pr.CalcularSerieFibonacci(Convert.ToInt32(numDigitos));
                }
                catch (Exception)
                {
                    Console.WriteLine("El dato ingresado debe ser un número entero");
                    programa = 1;
                }
            }

            Console.WriteLine("El programa ha terminado");
            Console.ReadLine();
        }

        /// <summary>
        /// Calcula la serie de Fibonacci hasta un N-écimo número y lo imprime en consola
        /// </summary>
        /// <returns></returns>
        private int CalcularSerieFibonacci(int numero)
        {
            //Se inicializan las variables
            ulong actual = 1;
            ulong anterior = 0;
            int contador = 1;

            const string coma = ",";
            var resultado = "";

            //Se valida que el número no sea negativo
            if (numero < 0)
            {
                Console.WriteLine("El número ingresado no puede ser negativo");
                return 1;
            }
            //Si el número es cero, se devuelve la serie básica
            if (numero == 0)
            {
                Console.WriteLine($"La serie de fibonacci es la siguiente : {anterior}");
                return 0;
            }
            if (numero <= 0) return 1;
            resultado = resultado + anterior + coma + actual;
            while (contador < numero)
            {
                var suma = actual + anterior;
                resultado += coma + suma;
                anterior = actual;
                actual = suma;
                contador++;
            }

            Console.WriteLine($"La serie de fibonacci es la siguiente: {resultado}");
            return 0;
        }
    }
}
