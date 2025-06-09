using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0304
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de dato float y double

            float no1, no2;
            float resultado;
            double resultado2;

            no1 = 15;
            no2 = 110;
            resultado = no1 / no2;
            resultado2 = no1 / no2;

            Console.WriteLine("El resultado float es: " +  resultado);
            Console.WriteLine("El resultado double es: " + resultado2);
            Console.ReadKey();

        }
    }
}
