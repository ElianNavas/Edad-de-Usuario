using System;

namespace Edad_de_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Ingrese su Edad: ");
            //byte edad = byte.Parse(Console.ReadLine());
            //Console.WriteLine("No aparentas " + edad + "años");
            //Console.ReadKey();

            //byte n1, n2;
            //ushort result;
            //Console.WriteLine("Ingrese Primer Número: ");
            //n1 = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese Segundo Número: ");
            //n2 = byte.Parse(Console.ReadLine());

            //result = Convert.ToUInt16(n1 * n2);

            //Console.WriteLine("El resultado es: "+ result);

            long n1, n2, sum, res, pro;
            Console.WriteLine("Ingrese Primer Número: ");
            n1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segundo Número: ");
            n2 = long.Parse(Console.ReadLine());
            sum = n1 + n2;
            res = n1 - n2;
            pro = n1 * n2;

            Console.WriteLine("El resultado de la suma es: " + sum);
            Console.WriteLine("El resultado de la resta es: " + res);
            Console.WriteLine("El resultado del producto es: " + pro);






        }
    }
}
