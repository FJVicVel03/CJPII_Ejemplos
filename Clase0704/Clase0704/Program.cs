using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0704
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si Entonces -> IF - ELSE IF - ELSE

            int edad;

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            //Si Entonces
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad.");
            }
            Console.ReadKey();
        }
    }
}
