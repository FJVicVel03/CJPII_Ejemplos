using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1905_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            bool continuar = true;
            do
            {
                Console.WriteLine("---Menu interactivo---");
                Console.WriteLine("1. Multiplicación");
                Console.WriteLine("2. División");
                Console.WriteLine("3. Salir");
                Console.Write("Ingresa una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Multiplicacion();
                        break;
                    case 2:
                        Dividir();
                        break;
                    case 3:
                        continuar = false;
                        break;
    
                }

            }while(continuar);
        }

        private static void Multiplicacion()
        {
            int n1, n2, resultado;
            Console.WriteLine("Ingrese el valor no.1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor no.2: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 * n2;
            Console.WriteLine("La multiplicación es: " +  resultado);
        }
        private static void Dividir()
        {
            int n1, n2, resultado;
            Console.WriteLine("Ingrese el valor no.1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor no.2: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 / n2;
            Console.WriteLine("La división es: " + resultado);
        }
    }
}
