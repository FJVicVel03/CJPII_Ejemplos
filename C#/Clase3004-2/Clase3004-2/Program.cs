using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3004_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            while (numero <= 30) 
            {
                
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Par: " + numero);
                }
                else 
                {
                    Console.WriteLine("Impar: "+numero);
                }
                numero++;
            }
            Console.ReadKey();

        }
    }
}
