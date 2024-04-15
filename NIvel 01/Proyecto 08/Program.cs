using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool estaConectado = false;
            string mensaje = (estaConectado) ? "Conectado" : "Desconectado";
            Console.WriteLine(mensaje);
            Console.ReadLine();
        }
    }
}
