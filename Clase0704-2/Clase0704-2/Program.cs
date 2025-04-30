using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0704_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cual de dos números es más grande
            int n1, n2;
            Console.WriteLine("Ingrese el primer valor");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            n2 = int.Parse(Console.ReadLine());

            if (n1 >= 0 && n2 >= 0)
            {
                if (n1 > n2)
                {
                    Console.WriteLine("El número " + n1 + " es el mayor.");
                }
                else if (n2 > n1)
                {
                    Console.WriteLine("El número " + n2 + "es el mayor.");
                }
                else if (n1 == n2)
                {
                    Console.WriteLine("Ambos números son iguales.");
                }
            }
            else if (n1 < 0 && n2 < 0)
            {
                Console.WriteLine("Ambos números son negativos.");
            }
            else if (n1 < 0)
            {
                Console.WriteLine("El número: " + n1 + " es el número negativo.");
            }
            else if (n2 < 0)
            {
                Console.WriteLine("El número: "+n2+" es el número negativo.");
            }
            

            
            Console.ReadKey();
        }
    }
}
