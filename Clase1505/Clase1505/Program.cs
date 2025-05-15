using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1505
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=02;
            int intentos = 1;
            int numeroIngresado=0;

            Random rnd = new Random();
            int numero = rnd.Next(1, 100);  
            

            while(numeroIngresado!=numero)
            {
                Console.WriteLine("Ingrese el número: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado > numero)
                {
                    Console.WriteLine("Pruebe un número menor");
                    i++;
                }
                else if (numeroIngresado < numero)
                {
                    Console.WriteLine("Pruebe un número mayor");
                    i++;
                } else if (numeroIngresado == numero)
                {
                    Console.WriteLine("Adivinó el número");
                    Console.WriteLine("Intentos: " + i);
                }
                
            }
            Console.ReadLine();
        }
    }
}
