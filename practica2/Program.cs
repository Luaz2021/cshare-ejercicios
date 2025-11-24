using System;

class Program
{
  
    static void Main(string[] args)
    {
        Console.WriteLine("Porfavor ingrese su edad:");
        string Entrada = Console.ReadLine();
        int edad = int.Parse(Entrada);
       Console.WriteLine("Usted tiene " + edad + " años.");
    }
}
