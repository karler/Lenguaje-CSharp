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
            // Función para sumar dos enteros
            int Sumar(int a, int b)
            {
                return a + b;
            }

            // Función para sumar tres enteros
            int Sumar(int a, int b, int c)
            {
                return a + b + c;
            }

            // Función para sumar dos doubles
            double Sumar(double a, double b)
            {
                return a + b;
            }

            // Llamando a la función
            int suma = Sumar(3, 3, 5); // suma ahora vale 8
            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
