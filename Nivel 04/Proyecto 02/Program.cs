using System;

namespace Proyecto_02
{
    internal class Program
    {
        static void Main(string[] args) {
            Random aleatorio = new Random();

            int num1;
            int num2;
            int operacion;
            int puntaje = 0;
            int respuesta;
            int resultado=0;
            bool juego = true;

            while (juego)
            {
                //Generamos los numeros aleatorios
                num1 = aleatorio.Next(10, 25);
                num2 = aleatorio.Next(5, 10);
                operacion = aleatorio.Next(1, 5);
               
                //Mostrar en pantalla la operación y calculamos el resultado
                if(operacion == 1)
                {
                    Console.Write($"{num1} + {num2} = ");
                    resultado = num1 + num2;
                }
                if(operacion == 2)
                {
                    Console.Write($"{num1} - {num2} = ");
                    resultado = num1 - num2;
                }
                if (operacion == 3)
                {
                    Console.Write($"{num1} * {num2} = ");
                    resultado = num1 * num2;
                }
                if (operacion == 4)
                {
                    num1 = num2 * num1;
                    Console.Write($"{num1} / {num2} = ");
                    resultado = num1 / num2;
                }
                
                //Recibimos la respuesta del usuario
                respuesta = Convert.ToInt32(Console.ReadLine());

                //comparamos las respuestas
                if (respuesta == resultado)
                {
                    Console.WriteLine("¡Correcto!");
                    puntaje++;
                }
                else
                {
                    Console.WriteLine($"Perdiste!  tu puntaje es: {puntaje}");
                    juego = false;
                }
            }
            Console.ReadLine();
        }
    }
}
