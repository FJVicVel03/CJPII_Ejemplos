using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3004
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ciclo While

            int i = 0;
            int numero, resultado;
            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            while (i <= 10)
            {
                resultado = numero * i;
                Console.WriteLine(numero + "*" + i + "=" + resultado);
                i++;
            }
            Console.ReadKey();
        }
    }
}
