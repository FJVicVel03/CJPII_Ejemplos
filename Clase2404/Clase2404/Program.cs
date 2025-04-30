using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2404
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese el número: ");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Ingresó el número 1");
                    break;
                case 2:
                    Console.WriteLine("Ingresó el número 2");
                    break;
                default:
                    Console.WriteLine("La opción no es válida");
                    break;
            }
            Console.ReadKey();

        }
    }
}
