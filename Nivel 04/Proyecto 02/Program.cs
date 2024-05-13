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
                num1 = aleatorio.Next(1, 15);
                num2 = aleatorio.Next(5, 20);
                operacion = aleatorio.Next(1, 3);
               
                //Mostrar en pantalla la operación
                if(operacion == 1)
                {
                    Console.Write($"{num1} + {num2} = ");
                }
                if(operacion == 2)
                {
                    Console.Write($"{num1} - {num2} = ");
                }
                
                // Calculamos el resultado
                if (operacion == 1)
                {
                    resultado = num1 + num2;
                }
                if (operacion == 2)
                {
                    resultado = num1 - num2;
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
