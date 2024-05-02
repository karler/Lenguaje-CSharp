using System;
namespace Proyecto_01
{
    internal class Program
    {
        public class Perro
        {
            // Propiedades
            public string Nombre { get; set; }
            public string Raza { get; set; }
            public int Edad { get; set; }

            // Método
            public void Ladrar()
            {
                Console.WriteLine($"{Nombre}: Guau!");
            }
        }
        static void Main(string[] args)
        {
            // Creación de objetos
            Perro miPerro = new Perro();
            miPerro.Nombre = "Buddy";
            miPerro.Raza = "Labrador";
            miPerro.Edad = 5;

            Perro perroVecino = new Perro();
            perroVecino.Nombre = "Rex";
            perroVecino.Raza = "Pastor Alemán";
            perroVecino.Edad = 3;

            // Uso de métodos
            miPerro.Ladrar(); // Salida: Guau!
            perroVecino.Ladrar();
            Console.ReadLine();
        }
    }
}
