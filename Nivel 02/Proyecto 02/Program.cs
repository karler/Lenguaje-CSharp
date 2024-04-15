using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Suma de los 20 primeros números usando FOR
            int suma = 0;
            int totalnum = 20;
            Console.WriteLine("            suma = suma + i");
            Console.WriteLine("-----------------------------------");
            for (int i = 1; i <= totalnum; i += 1)
            {
                Console.WriteLine($"Iteración {i} -> {suma + i} = {suma} + {i}");
                suma = suma + i;
            }
            Console.WriteLine($"La suma de los {totalnum} primeros números es: {suma}");
            Console.ReadLine();
        }
    }
}
