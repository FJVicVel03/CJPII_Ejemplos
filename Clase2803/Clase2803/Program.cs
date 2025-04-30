using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2803
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Fernando";
            string grado;
            Console.WriteLine("Hola mundo");

            Console.WriteLine("Mi nombre es: " + nombre);

            Console.WriteLine("En qué grado se encuentra? ");
            grado = Console.ReadLine();

            Console.WriteLine("Estoy en el grado de: " + grado);
            Console.ReadKey();
        }
    }
}
