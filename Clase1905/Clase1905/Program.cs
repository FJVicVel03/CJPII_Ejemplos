using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1905
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            bool t = true;

            do
            {

                if (contador == 100) { t = false; }
                Console.WriteLine("Número: " + contador);
                contador++;
            }while(t);
            Console.ReadKey();
        }
    }
}
