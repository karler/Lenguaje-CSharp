using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Argumentos - Paso por salida
            int mul;
            double div;
            int res;
            int sum;
            void operaciones(int a, int b,out int s, out int m, out double d, out int r)
            {
                r = a - b;
                m = a * b;
                d = a / b;
                s = a + b;
            }
            operaciones(4, 3, out sum, out mul, out div, out res);
            Console.WriteLine($"suma = {sum} - Resta = {res} - Muti = {mul} - Div = {div}");
            Console.ReadLine();
        }
    }
}
