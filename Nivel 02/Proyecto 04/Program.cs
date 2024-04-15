using System;

namespace Proyecto_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Suma de los 20 primeros números usando DO .. WHILE
            int suma = 0;
            int totalNum = 20;
            int i = 1;
            do
            {
                Console.WriteLine($"Iteración {i} -> {suma + i} = {suma} + {i}");
                suma = suma + i;
                i++;
            } while (i<=totalNum);
            Console.WriteLine($"La suma de los {totalNum} primeros números es: {suma}");
            Console.ReadLine();
        }
    }
}
