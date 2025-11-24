using System;
namespace practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar el primer numero    
            Console.WriteLine("Ingrese el primer numero:");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            //Solicitar el segundo numero
            Console.WriteLine("Ingrese el segundo numero:");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            //Calcular la suma 
            double suma = numero1 + numero2;
            //Mostrar el resultado
            Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es: " + suma);
        }
    }
}