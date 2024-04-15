using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Que la computadora piense en un número
            Random rnd = new Random();
            int numeroSecreto = rnd.Next(1, 100);
            int numeroUsuario;

            do{
                Console.WriteLine("Adivina el número que estoy pensando (entre 1 y 100)");
                numeroUsuario = Convert.ToInt32(Console.ReadLine());
                if(numeroUsuario > numeroSecreto)
                {
                    //numeroUsuario > numeroSecreto
                    Console.WriteLine("El número secreto es menor");
                }
                else if(numeroUsuario < numeroSecreto)
                {
                    //numeroUsuario < numeroSecreto
                    Console.WriteLine("El número secreto es mayor");
                }
                else
                {
                    // numeroUsuario = numeroSecreto
                    Console.WriteLine("¡Felicitaciones! Adivinaste el número");
                }
            }while(numeroUsuario != numeroSecreto);
            Console.ReadLine();
        }
    }
}
