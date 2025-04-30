using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2404_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char vocal;
            Console.WriteLine("Ingrese una vocal: ");
            vocal = char.Parse(Console.ReadLine());

            switch(char.ToUpper(vocal))
            {
                case 'A':
                    Console.WriteLine("Avión");
                    break;
                case 'E':
                    Console.WriteLine("Esquirla");
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
