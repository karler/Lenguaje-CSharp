using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Función que suma dos números y devuelve el resultado
            int Sumar(int a, int b)
            {
                int resultado = a + b;
                return resultado;
            }

            // Llamando a la función
            int suma = Sumar(3, 3); // suma ahora vale 8
            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
