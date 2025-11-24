using System;

namespace condicionalesC {
    class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            // 3. VALIDACIÓN DE SWITCH (Menú Principal)
            Console.Clear();
            Console.WriteLine("=== PROGRAMA DE VALIDACIONES EN C# ===");
            Console.WriteLine("1. Probar validación de Entero (Sin decimales, ni negativos, ni letras)");
            Console.WriteLine("2. Probar validación de Double (Sin negativos, ni letras)");
            Console.WriteLine("3. Salir");
            Console.WriteLine("======================================");
            Console.Write("Seleccione una opción: ");

            // Reutilizamos el método de validar entero para el menú
            // Esto asegura que el switch solo reciba números limpios
            int opcion = ValidarEntero(); 

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n--- MODO: VALIDAR ENTERO ---");
                    Console.Write("Ingrese un número entero positivo (ej: 5, 100): ");
                    int numeroEntero = ValidarEntero();
                    Console.WriteLine($"¡Éxito! El número entero validado es: {numeroEntero}");
                    break;

                case 2:
                    Console.WriteLine("\n--- MODO: VALIDAR DOUBLE ---");
                    Console.Write("Ingrese un número decimal positivo (ej: 10.5, 2.3): ");
                    double numeroDouble = ValidarDouble();
                    Console.WriteLine($"¡Éxito! El número double validado es: {numeroDouble}");
                    break;

                case 3:
                    Console.WriteLine("\nSaliendo del programa...");
                    continuar = false;
                    break;

                default:
                    // Esta parte del switch maneja si el número es válido (es un int) 
                    // pero no está entre las opciones 1, 2 o 3.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR: La opción debe ser 1, 2 o 3.");
                    Console.ResetColor();
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }

    // ---------------------------------------------------------
    // 1. MÉTODO VALIDACIÓN DE ENTERO
    // Evita: Caracteres (letras), Negativos y Decimales
    // ---------------------------------------------------------
    static int ValidarEntero()
    {
        int resultado;
        bool esValido = false;

        while (!esValido)
        {
            string entrada = Console.ReadLine();

            // int.TryParse hace dos cosas:
            // 1. Intenta convertir el texto a int. Si hay letras o decimales (ej: "4.5"), devuelve FALSE.
            // 2. Si funciona, guarda el número en la variable 'resultado'.
            if (int.TryParse(entrada, out resultado))
            {
                if (resultado >= 0)
                {
                    esValido = true; // Rompe el bucle, el dato es correcto
                    return resultado;
                }
                else
                {
                    MensajeError("El número no puede ser negativo.");
                }
            }
            else
            {
                // Si TryParse falla, es porque metieron letras o un punto decimal
                MensajeError("Entrada inválida. Solo se admiten números enteros (sin decimales ni letras).");
            }
        }
        return 0; // Retorno por defecto (nunca se alcanza por el bucle while)
    }

    // ---------------------------------------------------------
    // 2. MÉTODO VALIDACIÓN DE DOUBLE
    // Evita: Caracteres (letras) y Negativos. Permite Decimales.
    // ---------------------------------------------------------
    static double ValidarDouble()
    {
        double resultado;
        bool esValido = false;

        while (!esValido)
        {
            string entrada = Console.ReadLine();

            // double.TryParse permite enteros y decimales, pero falla con letras.
            // Nota: Dependiendo de tu idioma en Windows, el decimal puede ser coma (,) o punto (.).
            if (double.TryParse(entrada, out resultado))
            {
                if (resultado >= 0)
                {
                    esValido = true;
                    return resultado;
                }
                else
                {
                    MensajeError("El número no puede ser negativo.");
                }
            }
            else
            {
                MensajeError("Entrada inválida. Ingrese un valor numérico correcto.");
            }
        }
        return 0.0;
    }

    // Método auxiliar para mostrar errores en rojo (Estético)
    static void MensajeError(string mensaje)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERROR: {mensaje}");
        Console.ResetColor();
        Console.Write("Inténtelo nuevamente: ");
    }
} 
}