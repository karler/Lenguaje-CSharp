using System;

namespace Proyecto_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promedio = 8.5;
            bool familiaNumerosa = false;

            bool tieneBeca = false;

            if (promedio >= 9.0)
            {//promedio >= 9.0
                tieneBeca = true;
            }
            else if (promedio >= 8.0)
            {//promedio < 9.0 y promedio >= 8.0
                if (familiaNumerosa)
                {//promedio < 9.0 y promedio >= 8.0 y familianumerosa = true
                    tieneBeca = true;
                }
            }

            if (tieneBeca)
            {//tienebeca = true
                Console.WriteLine("¡Felicidades! Has obtenido una beca");
            }
            else
            {//tienebeca = false
                Console.WriteLine("Lo sentimos, no cumples con los requisitos para obtener una beca");
            }
            Console.ReadLine();
        }
    }
}
