using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sumar(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return n + Sumar(n - 1);
                }
                
            }
            Console.WriteLine(Sumar(5));
            Console.ReadLine();
        }
    }
}
