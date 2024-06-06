using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_09
{
    class Rectangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public void CalcularArea()
        {
            Console.WriteLine($"El área del rectángulo es: {Base * Altura}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double area;
            Rectangulo rectangulo = new Rectangulo();
            Console.WriteLine("Ingresa la base del rectángulo");
            rectangulo.Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa la altura del rectángulo");
            rectangulo.Altura = Convert.ToDouble(Console.ReadLine());
            //area = rectangulo.CalcularArea();
            //Console.WriteLine($"El área de un rectángulo de {rectangulo.Base} de base y {rectangulo.Altura} altura es: {area}");
            rectangulo.CalcularArea();
            Console.ReadLine();
        }   
    }
}
