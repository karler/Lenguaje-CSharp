using System;

namespace Proyecto_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 10 + 5;
            int resta = 10 - 5;
            int multiplicacion = 10 * 5;
            double division = 10 / 3.0;
            int modulo = 10 % 3;
            int incremento = 10;
            incremento++;
            int decremento=10;
            decremento--;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta; {resta}");
            Console.WriteLine($"Multiplicación: {multiplicacion}");
            Console.WriteLine($"División: {division}");
            Console.WriteLine($"Módulo: {modulo}");
            Console.WriteLine($"Incremento: {incremento}");
            Console.WriteLine($"Decremento: {decremento}");
            Console.ReadLine();
        }
    }
}
