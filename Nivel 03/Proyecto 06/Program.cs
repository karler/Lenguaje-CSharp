using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Argumentos - Paso por referencia
            int num1 = 11;
            int num2 = 6;
            // la funcion suma tiene 2 argumentos de paso por valor
            // y un argumento por referencia (a)
            double suma(ref int a, int b, int c = 0)
            {
                //Aqui se incrementa el valor del argumento de la variable a
                a++;
                return a + b + c;
            }

            Console.WriteLine($"la función suma devuelve: {suma(ref num1, num2)}");
            //A pesar de haber incrementado el argumento a de la funcion suma, no se modifica la variable num1
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.ReadLine();
        }
    }
}
