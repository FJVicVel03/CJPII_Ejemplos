using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0304_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            float suma, resta, mult, div, mod;
            Console.WriteLine("Escriba el primer valor: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo valor: ");
            n2 = float.Parse(Console.ReadLine());

            suma = n1 + n2;
            resta = n1 - n2;
            mult = n1 * n2;
            div = n1 / n2;
            mod = n1 % n2;

            Console.WriteLine("La suma es: "+suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La multiplicación es: " + mult);
            Console.WriteLine("La división es: " + div);
            Console.WriteLine("El módulo es: " + mod);
            Console.ReadKey();


        }
    }
}
