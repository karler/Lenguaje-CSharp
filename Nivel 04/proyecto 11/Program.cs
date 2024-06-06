using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_11
{
    class Perro
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Mi nombre es: {Nombre}");
            Console.WriteLine($"Mi raza es: {Raza}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro dido = new Perro();
                dido.Nombre = "Dido Garcia";
                dido.Raza = "Afgano";
            Perro boby = new Perro();
                boby.Nombre = "Boby Quispe";
                boby.Raza = "Bedllington Terrier";

            Console.WriteLine($"Mi perro {dido.Nombre} es de raza {dido.Raza}");
            dido.MostrarDetalles();
            boby.MostrarDetalles();
            Console.ReadLine();
        }
    }
}
