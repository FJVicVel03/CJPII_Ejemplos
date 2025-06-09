using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, eleccion;
            string licencia = "Ninguna";

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Ingrese el tipo de licencia que quiere: (1) Carro (2) Moto");
                eleccion = int.Parse(Console.ReadLine());
                if (eleccion == 1)
                {
                    licencia = "Carro";
                }
                else if (eleccion == 2)
                {
                    licencia = "Moto";
                }
                else 
                {
                    licencia = "Ninguna";
                }

            }
            else 
            {
                Console.WriteLine("Menor de edad");
            }

            if (edad >= 18)
            {
                Console.WriteLine("Su licencia es de: " + licencia);
            }
            else 
            {
                Console.WriteLine("Sin derecho a licencia por minoría de edad");
            }

            Console.ReadKey();
        }
    }
}
