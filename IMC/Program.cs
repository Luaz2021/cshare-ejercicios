using System;
namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {

            double peso = LeerNumero("Ingrese su peso en KG");
            double altura = LeerNumero("Ingrese su altura en metros");

            double IMC  =  calcularIMC(peso, altura);
            Console.WriteLine($"Tu IMC es: {IMC:F2}");
            Console.WriteLine(condicion(IMC));


        }
        static double LeerNumero(string mensaje)
        {
            double numero;
            while (true)
            {
                Console.WriteLine(mensaje);
                if (double.TryParse(Console.ReadLine(), out numero) && numero > 0)
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Dato no valido intente de nuevo");
                }
            }
        }

        static double calcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }
    
        static string condicion(double IMC)
        {
            if (IMC < 18.5)
            {
                return "Condición: Peso bajo";
            } else if (IMC >= 18.5 && IMC <= 24.9)
            {
                return "Condición: Peso normal";
            } else
            {
                return "Condición: Sobrepeso";
            }
        }

    }
}
