using System;

namespace Edad_de_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese su Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("No aparentas " + edad  +  "años");
            Console.ReadKey();
            
            
        }
    }
}
