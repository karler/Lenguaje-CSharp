using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_09
{
    internal class Program
    {
        public int z;
        static void Main(string[] args)
        {
            int y = 10;
            if (y >= 5)
            {
                int x = 10; // x solo es accesible dentro del bloque if
                y = 2;
            }else
            {
                y = 20;

            }
            // x no es accesible aquí

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(y);
            }
        }
    }
}
