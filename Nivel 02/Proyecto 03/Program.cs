using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Suma de los 20 primeros números usando FOR
            int totalnum = 20;
            int suma = 0;
            Console.WriteLine("            suma = suma + i");
            Console.WriteLine("-----------------------------------");
            int i = 1;
            while (i <= totalnum)
            {
                Console.WriteLine($"Iteración {i} -> {suma + i} = {suma} + {i}");
                suma = suma + i;
                i++;
            }
            Console.WriteLine($"La suma de los {totalnum} primeros números es: {suma}");
            Console.ReadLine();
        }
    }
}
