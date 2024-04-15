using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            bool llave = false;
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("viernes");
                    break;
                case 6:
                    Console.WriteLine("sabado");
                    break;
                case 7:
                    Console.WriteLine("domingo");
                    break;
                case 8 when (llave):
                    Console.WriteLine("Debes ingresar un valor de semana, entre 1 y 7");
                    break;
                default:
                    Console.WriteLine("Error!, ingresa un valor entre 1 y 7");
                    break;
            }
            Console.ReadLine();
        }
    }
}
