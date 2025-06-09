using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2904
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, respuesta;
            char op;

            Console.WriteLine("Ingrese número 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su operador: +,-,*,/");
            op = char.Parse(Console.ReadLine());

            switch (op) 
            {
                case '+':
                    respuesta = n1 + n2;
                    Console.WriteLine("La suma es: "+ respuesta);
                    break;
                case '-':
                    respuesta = n1 - n2;
                    Console.WriteLine("La resta es: "+respuesta);
                    break;
                case '*':
                    respuesta = n1 * n2;
                    Console.WriteLine("La multiplicación es: " + respuesta);
                    break;
                case '/':
                    respuesta = n1 / n2;
                    Console.WriteLine("La división es: " + respuesta);
                    break;
                default:
                    Console.WriteLine("No es un operador válido");
                    break;
            }



        }
    }
}
