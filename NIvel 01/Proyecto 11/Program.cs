using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, j=10; i <= 10; i++,j--)
            {
                Console.WriteLine($"i = {i}   j = {j}");
                if (i==2 && j>5)
                {
                    i = 8;
                }
            }
            Console.ReadLine();
        }
    }
}
