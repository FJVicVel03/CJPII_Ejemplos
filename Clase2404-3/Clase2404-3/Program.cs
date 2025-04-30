using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2404_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, resultado;
            int n1, n2;

            Console.WriteLine("Ingrese una opcion: ");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion) 
            {
                case 1:
                    Console.WriteLine("Ingrese numero 1:");
                    n1 = int.Parse(Console.ReadLine());
                     Console.WriteLine("Ingrese numero 2:");
                    n2 = int.Parse(Console.ReadLine());

                    resultado = n1 + n2;
                    Console.WriteLine(resultado);
                    break;
                case 2:
                    Console.WriteLine("Ingrese numero 1:");
                    n1 = int.Parse(Console.ReadLine());
                     Console.WriteLine("Ingrese numero 2:");
                    n2 = int.Parse(Console.ReadLine());

                    resultado = n1 - n2;
                    Console.WriteLine(resultado);

                    break;
                case 3:
                    Console.WriteLine("Ingrese numero 1:");
                    n1 = int.Parse(Console.ReadLine());
                     Console.WriteLine("Ingrese numero 2:");
                    n2 = int.Parse(Console.ReadLine());

                    resultado = n1 * n2;
                    Console.WriteLine(resultado);

                    break;
                case 4:
                    Console.WriteLine("Ingrese numero 1:");
                    n1 = int.Parse(Console.ReadLine());
                     Console.WriteLine("Ingrese numero 2:");
                    n2 = int.Parse(Console.ReadLine());

                    resultado = n1 / n2;
                    Console.WriteLine(resultado);

                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;

            }
            Console.ReadKey();


        }
    }
}
