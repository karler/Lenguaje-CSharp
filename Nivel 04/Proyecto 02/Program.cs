using System;

namespace Proyecto_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int num1 = aleatorio.Next(10,101);
            int num2 = aleatorio.Next(10, 101);
            int respuesta;
            int resultado = num1 + num2;
            Console.Write($"{num1} + {num2} = ");
            respuesta = Convert.ToInt32(Console.ReadLine());
            if(respuesta == resultado ) {
                Console.WriteLine("¡Correcto!");
            } else
            {
                Console.WriteLine("Perdiste!");
            }
            Console.ReadLine();

        }
    }
}
