using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1505_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int n1, n2, suma, resta;
            bool cont = true;

            while(cont)
            {
                Console.WriteLine("Bienvenido: ");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Salir");

                Console.WriteLine("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese n1: ");
                         n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese n2: ");
                         n2 = int.Parse(Console.ReadLine());

                         suma = n1 + n2;
                        Console.WriteLine("Suma: " + suma);
                        
                        break;
                    case 2:
                        Console.WriteLine("Ingrese n1: ");
                         n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese n2: ");
                        n2 = int.Parse(Console.ReadLine());

                        resta = n1 - n2;
                        Console.WriteLine("Resta: " + resta);
                        break;
                    case 3:
                        cont = false;
                        break;

                }
            }
            Console.ReadKey();

        }
    }
}
