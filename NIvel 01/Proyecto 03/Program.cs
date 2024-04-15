using System;

namespace Proyecto_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de una variable entera
            int edad = 30;
            //Declaración de una onstante
            const double PI = 3.1415926535;

            Console.WriteLine($"Edad actual es: {edad}");
            edad = 31;
            Console.WriteLine($"Edad despues del cumpleaños es: {edad}");

            // Uso de la constante
            Console.WriteLine($"Valor de PI: {PI}");
            Console.ReadLine();

        }
    }
}
