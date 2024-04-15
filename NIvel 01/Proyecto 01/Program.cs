using System;

namespace Proyecto_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            Console.WriteLine("Hola, Bienvenido al programa 01");
            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                //Console.WriteLine("Hola " + nombre + ", eres mayor de edad");
                Console.WriteLine($"Hola {nombre}, eres mayor de edad!");
            }
            else
            {
                Console.WriteLine("Hola " + nombre + ", eres menor de edad");
            }          
            Console.ReadLine();
        }

    }
}
