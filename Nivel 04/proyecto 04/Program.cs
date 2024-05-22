using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static proyecto_04.Program;

namespace proyecto_04
{
    internal class Program
    {
        public class Operacion
        {
            public int Numero1 { get; set; }
            public int Numero2 { get; set;}
            public int operador { get; set; }

            private Random aleatorio = new Random();
            public void generaNumeros()
            {
                Numero1 = aleatorio.Next(10, 31); // Genera un número aleatorio entre 1 y 100 (inclusive)
                Numero2 = aleatorio.Next(5, 11); // Genera otro número aleatorio entre 1 y 100 (inclusive)
                operador = aleatorio.Next(1, 5); //genera la opración
            }
            public string pregunta()
            {
                string mensaje = "";
                    switch (operador)
                    {
                    case 1:
                        mensaje = $"{Numero1} + {Numero2} = ";
                        break;
                    case 2:
                        mensaje = $"{Numero1} - {Numero2} = ";
                        break;
                    case 3:
                        mensaje = $"{Numero1} * {Numero2} = ";
                        break;
                    case 4:
                        Numero1 = Numero1 * Numero2;
                        mensaje = $"{Numero1} / {Numero2} = ";
                        break;
                    }
                    return mensaje;
            }
            public int CalcularResultado()
            {
                int resultado = 0;
                switch (operador)
                {
                    case 1:
                        resultado = Numero1 + Numero2;
                        break;
                    case 2:
                        resultado = Numero1 - Numero2;
                        break;
                    case 3:
                        resultado = Numero1 * Numero2;
                        break;
                    case 4:
                        resultado = Numero1 / Numero2;
                        break;
                }
                return resultado;
            }
        }

        public class juego
        {
            private int puntaje = 0;
            private bool juegoActivo = true;

            public void jugar()
            {
                while (juegoActivo)
                {
                    Operacion operaciones = new Operacion();
                    operaciones.generaNumeros();
                    Console.Write(operaciones.pregunta());

                    int respuestaUsuario = Convert.ToInt32(Console.ReadLine());
                    int resultadoCorrecto = operaciones.CalcularResultado();

                    if (respuestaUsuario == resultadoCorrecto)
                    {
                        Console.WriteLine("Correcto!");
                        puntaje++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrecto.({resultadoCorrecto}) fin del juego. Puntaje = {puntaje}");
                        juegoActivo = false;
                    }
                }
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            juego juego4operaciones = new juego();
            juego4operaciones.jugar();
        }
    }
}
