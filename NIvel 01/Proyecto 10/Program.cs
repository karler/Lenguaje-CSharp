using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 5;

            switch (value)
            {
                case int n when (n >= 0 && n <= 10):
                    Console.WriteLine("Entre 0 y 10");
                    break;
                case int n when (n > 10 && n <= 20):
                    Console.WriteLine("Entre 11 y 20");
                    break;
                // Añadir más rangos según sea necesario
                default:
                    Console.WriteLine("Fuera de rango");
                    break;
            }
            Console.ReadLine();
        }
    }
}
