using System;

namespace Proyecto_03
{
    public class Operacion
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        private Random aleatorio = new Random();

        public void generaNumeros()
        {
            Numero1 = aleatorio.Next(1, 101); // Genera un número aleatorio entre 1 y 100 (inclusive)
            Numero2 = aleatorio.Next(1, 101); // Genera otro número aleatorio entre 1 y 100 (inclusive)
        }
        public int CalcularResultado()
        {
            return Numero1 + Numero2;
        }

        public string pregunta()
        {
            return $"{Numero1} + {Numero2} = "; // Ejemplo: "23 + 45 = "
        }
    }

    public class Juego
    {
        private int puntaje = 0;
        private bool juegoActivo = true;

        public void jugar()
        {
            while (juegoActivo)
            {
                Operacion operacionSuma = new Operacion();
                operacionSuma.generaNumeros();
                Console.WriteLine(operacionSuma.pregunta());

                int respuestaUsuario = Convert.ToInt32(Console.ReadLine());
                int resultadoCorrecto = operacionSuma.CalcularResultado();

                if (respuestaUsuario == resultadoCorrecto)
                {
                    Console.WriteLine("Correcto!");
                    puntaje++;
                }
                else
                {
                    Console.WriteLine($"Incorrecto. fin del juego. Puntaje = {puntaje}");
                    juegoActivo = false;
                }
            }
            Console.ReadLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Juego juegoSuma = new Juego();
            juegoSuma.jugar();
        }
    }
}