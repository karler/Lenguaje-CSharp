using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Genera numeros pares del 1 al 10
            for (int i = 1; i <= 10; i++) {
                if (i % 2 == 0) { 
                    Console.WriteLine(i);
                }
            }
            //Genera Números pares del 1 al 10
            for (int i = 2; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
