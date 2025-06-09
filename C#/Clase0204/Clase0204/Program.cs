using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0204
{
    class Program
    {
        static void Main(string[] args)
        {
            //Volumen de una esfera
            //V = 4/3 * Pi * R^3
            int radio;
            double volumen,superficie; //double superficie
            double pi = 3.141592;
            Console.WriteLine("Ingrese el radio de la esfera: ");
            radio = int.Parse(Console.ReadLine());

            volumen = (4 / 3) * pi * (radio * radio * radio);
            superficie = 4 * pi * (radio * radio); //SA = 4*pi*R^2

            Console.WriteLine("El volumen es: " + volumen);
            Console.WriteLine("La superficie es: " + superficie);
            Console.ReadKey();
        }
    }
}
