using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Argumentos - Paso por valor
            int num1 = 11;
            int num2 = 6;
            // la funcion suma tiene 3 argumentos de paso por valor y un argumento opcional (c)
            double suma(int a, int b, int c = 0)
            {
                //Aqui se incrementa el valor del argumento a
                a++;
                return a + b + c;
            }

            Console.WriteLine($"la función suma devuelve: {suma(num1, num2)}");
            //A pesar de haber incrementado el argumento a de la funcion suma, no se modifica la variable num1
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.ReadLine();
        }
    }
}
