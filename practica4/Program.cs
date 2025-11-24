using System;
namespace practica4
{
    class Program
    {
        // Reutilizamos la lógica de validación que ya creaste en tus otros programas.
        // Esto previene que el programa se cierre si el usuario ingresa texto.
        static float ValidarNumero(string mensaje)
        {
            float numero;
            bool esValido = false;

            do
            {
                Console.WriteLine(mensaje);
                string? entrada = Console.ReadLine();

                if (float.TryParse(entrada, out numero) && numero > 0)
                {
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un número positivo.");
                }

            } while (!esValido);

            return numero;
        }
        static void Main(string[] args)
        {
            float baseTriangulo = ValidarNumero("Ingrese la base del triangulo:");
            float alturaTriangulo = ValidarNumero("Ingrese la altura del triangulo:");
            float areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine("El área del triángulo es: " + areaTriangulo);
        }
    }
}