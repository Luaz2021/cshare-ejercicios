using System;

namespace practica1
{
    class Program
    {
        // Método para leer un número entero de la consola de forma segura
        static int LeerNumero(string mensaje)
        {
            int numero;
            bool entradaValida = false;

            do
            {
                Console.WriteLine(mensaje);
                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            } while (!entradaValida);

            return numero;
        }

        static void Main(string[] args)
        {
            //Operadores matemáticos
            int num1 = LeerNumero("Ingrese el primer número:");
            int num2 = LeerNumero("Ingrese el segundo número:");

            //Suma
            int resultado = num1 + num2;
            Console.WriteLine($"La suma es: {resultado}");

            //Resta
            resultado = num1 - num2;
            Console.WriteLine($"La resta es: {resultado}");

            //Multiplicación
            resultado = num1 * num2;
            Console.WriteLine($"La multiplicación es: {resultado}");

            // Comprobar si el segundo número es cero antes de dividir o calcular el módulo
            if (num2 != 0)
            {
                //División entera
                resultado = num1 / num2;
                Console.WriteLine($"La división entera es: {resultado}");
                // Muestra la división con decimales para mayor precisión
                Console.WriteLine($"La división con decimales es: {(double)num1 / num2}");
                //Módulo
                resultado = num1 % num2;
                Console.WriteLine($"El módulo es: {resultado}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
        }
    }
}
