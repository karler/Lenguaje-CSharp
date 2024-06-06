using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_10
{
    class Circulo
    {
        public double radio {  get; set; }

        public double CalcularCircunferencia()
        {
            return 2*Math.PI*radio;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            circulo.radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La circunferencia es: {circulo.CalcularCircunferencia()}");
            Console.ReadLine();
        }
    }
}
