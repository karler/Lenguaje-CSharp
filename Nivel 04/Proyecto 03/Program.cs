// Importa el espacio de nombres System, que contiene clases fundamentales para la programación .NET
using System;

namespace Proyecto_03
{
    // Definición de la clase Operacion, que representa una operación de suma
    public class Operacion
    {
        // Propiedades públicas para almacenar dos números enteros
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        // Campo privado para generar números aleatorios
        private Random aleatorio = new Random();

        // Método para generar números aleatorios entre 1 y 100
        public void generaNumeros()
        {
            Numero1 = aleatorio.Next(1, 101); // Genera un número aleatorio entre 1 y 100 (inclusive)
            Numero2 = aleatorio.Next(1, 101); // Genera otro número aleatorio entre 1 y 100 (inclusive)
        }

        // Método para calcular el resultado de la suma de Numero1 y Numero2
        public int CalcularResultado()
        {
            return Numero1 + Numero2;
        }

        // Método que devuelve una cadena con la pregunta de la suma
        public string pregunta()
        {
            return $"{Numero1} + {Numero2} = "; // Ejemplo: "23 + 45 = "
        }
    }

    // Definición de la clase Juego, que controla la lógica del juego de sumas
    public class Juego
    {
        // Campo privado para almacenar el puntaje del jugador
        private int puntaje = 0;

        // Campo privado para controlar si el juego sigue activo
        private bool juegoActivo = true;

        // Método que contiene la lógica principal del juego
        public void jugar()
        {
            // Bucle que continúa hasta que el juego esté activo
            while (juegoActivo)
            {
                // Crea una nueva instancia de la clase Operacion
                Operacion operacionSuma = new Operacion();

                // Genera números aleatorios para la operación de suma
                operacionSuma.generaNumeros();

                // Muestra la pregunta de la suma en la consola
                Console.WriteLine(operacionSuma.pregunta());

                // Lee la respuesta del usuario desde la consola y la convierte a un número entero
                int respuestaUsuario = Convert.ToInt32(Console.ReadLine());

                // Calcula el resultado correcto de la suma
                int resultadoCorrecto = operacionSuma.CalcularResultado();

                // Compara la respuesta del usuario con el resultado correcto
                if (respuestaUsuario == resultadoCorrecto)
                {
                    // Si la respuesta es correcta, muestra un mensaje y aumenta el puntaje
                    Console.WriteLine("Correcto!");
                    puntaje++;
                }
                else
                {
                    // Si la respuesta es incorrecta, muestra un mensaje y termina el juego
                    Console.WriteLine($"Incorrecto. fin del juego. Puntaje = {puntaje}");
                    juegoActivo = false;
                }
            }

            // Espera a que el usuario presione Enter antes de cerrar la consola
            Console.ReadLine();
        }
    }

    // Clase principal que inicia el juego
    internal class Program
    {
        // Método Main, punto de entrada del programa
        static void Main(string[] args)
        {
            // Crea una nueva instancia de la clase Juego
            Juego juegoSuma = new Juego();

            // Llama al método jugar para iniciar el juego
            juegoSuma.jugar();
        }
    }
}
