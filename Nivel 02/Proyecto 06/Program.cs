using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = {"Cristian","Yunior", "Cheila", "Jolauos", "Julio" };
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Nombre {i} : {nombres[i]}");
            }

            foreach (string nombre in nombres)
            {
                Console.WriteLine($"Nombre : {nombre}");
            }

            Console.ReadLine();
        }
    }
}
