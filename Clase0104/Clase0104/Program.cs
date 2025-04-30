using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");

            int numero;
            float dcml;
            string nombre;
            bool b;

            Console.WriteLine("Ingrese el valor numerico: ");
            //Parseo -> conversión a un tipo de dato
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor decimal: ");
            dcml = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Tipo de dato True o False: ");
            b = bool.Parse(Console.ReadLine());

            Console.WriteLine("El numero es: " + numero);
            Console.WriteLine("El decimal es: " + dcml);
            Console.WriteLine("El nombre es: " + nombre);
            Console.WriteLine("El valor booleano es: " + b);

            Console.ReadKey();
        }
    }
}
