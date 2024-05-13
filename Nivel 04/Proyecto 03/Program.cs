using Proyecto_02;
using System;

namespace Proyecto_02
{
    // Clase para manejar las operaciones de suma
    public class OperacionSuma
    {
        public int Numero1 { get; private set; }
        public int Numero2 { get; private set; }
        private Random random = new Random();

        public OperacionSuma()
        {
            // Al crear una nueva operación, generamos dos números aleatorios
            Numero1 = random.Next(1, 101);
            Numero2 = random.Next(1, 101);
        }

        public int CalcularResultado()
        {
            return Numero1 + Numero2;
        }

        public string pregunta()
        {
            return $"{Numero1} + {Numero2} = ";
        }
    }

    // Clase para manejar la lógica del juego
    public class JuegoSuma
    {
        private int puntaje = 0;
        private bool juegoActivo = true;

        public void Jugar()
        {
            while (juegoActivo)
            {
                OperacionSuma operacion = new OperacionSuma();
                Console.Write(operacion.pregunta());

                int respuestaUsuario = Convert.ToInt32(Console.ReadLine());
                int resultadoCorrecto = operacion.CalcularResultado();

                if (respuestaUsuario == resultadoCorrecto)
                {
                    puntaje++;
                    Console.WriteLine("¡Correcto!");
                }
                else
                {
                    Console.WriteLine($"Incorrecto. Fin del juego. Puntaje = {puntaje}");
                    juegoActivo = false;
                }
            }
            Console.ReadLine();
        }
    }

    // Clase principal que inicia el juego
    internal class Program
    {
        static void Main(string[] args)
        {
            JuegoSuma juego = new JuegoSuma();
            juego.Jugar();
        }
    }
}
