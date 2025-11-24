﻿using System;

namespace numeroMayor
{
    class Program
    {

        //Validamos que los numeros sean enteros,mayores a cero y que no sean caracteres

        static int ValidarNumero(string mensaje)
        {
            int numero;
            bool esValido = false;

            do
            {
                Console.WriteLine(mensaje);
                string? entrada = Console.ReadLine();

                // Intentamos convertir la entrada. Si es un entero y es positivo, es válido.
                if (int.TryParse(entrada, out numero) && numero > 0)
                {
                    esValido = true;
                }
                else
                {
                    // Si falla la conversión o el número no es positivo, mostramos un error.
                    Console.WriteLine("Error: Debe ingresar un número entero positivo.");
                }

            } while (!esValido);

            return numero;
        }

        static void Main(string[] args)
        {
            int num1 = ValidarNumero("Ingrese el primer número:");
            int num2 = ValidarNumero("Ingrese el segundo número:");

            if (num1 != num2)
            {
                // Usamos Math.Max para encontrar el mayor de los dos números.
                int mayor = Math.Max(num1, num2);
                Console.WriteLine($"El número mayor es: {mayor}");
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }
        }
    }
}
