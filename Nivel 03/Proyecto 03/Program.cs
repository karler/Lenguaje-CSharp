using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorial(int num)
            {
                if (num != 1) {
                    return num * factorial(num - 1);
                }
                else
                {
                    return 1;
                }
            }
            Console.WriteLine(factorial(6));
            Console.ReadLine();
        }
    }
}
