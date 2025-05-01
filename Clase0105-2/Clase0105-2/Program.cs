using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0105_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que se ejecute hasta ingresar un
            //número negativo
            int numero = 0;

            while(numero>=0)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingreso el número: " +  numero);
            }
            Console.ReadKey();
        }
    }
}
