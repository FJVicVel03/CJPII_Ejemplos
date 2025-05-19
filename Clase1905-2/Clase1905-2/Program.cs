using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1905_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.WriteLine("Ingrese n1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese n2: ");
            n2 = int.Parse(Console.ReadLine());
            resultado = Suma(n1, n2);
            Console.WriteLine(resultado);
            Console.ReadKey();

        }
        public static int Suma(int a, int b)
        {
            int suma = a + b;
            return suma;
        }
    }
}

