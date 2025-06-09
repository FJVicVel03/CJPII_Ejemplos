using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0304_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si Entonces - SiNo
            //if - else- else if

            double temperatura;

            Console.WriteLine("Ingrese la temperatura deseada: ");
            temperatura = double.Parse(Console.ReadLine());

            if (temperatura >= 28)
            {
                Console.WriteLine("Hay mucho calor");
            }
            else
            {
                Console.WriteLine("El clima es templado");
            }

            Console.ReadKey();
        }
    }
}
