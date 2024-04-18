using System;

namespace AdivinaLaPalabra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de palabras para adivinar
            string[] frutas = { "manzana", "banana", "cereza", "durazno", "fresa", "kiwi", "mango", "naranja", "pera", "piña" };
            Random rnd = new Random();
            int indice = rnd.Next(frutas.Length);
            string frutaSecreta = frutas[indice];
            Console.WriteLine("Adivina en cual de estas frutas estoy pensando");
            foreach (string fruta in frutas)
            {
                Console.Write($"{fruta} ");
            }
            string frutaUsuario;
            do
            {
                frutaUsuario = Console.ReadLine().ToLower();
                if(frutaSecreta == frutaUsuario)
                {
                    Console.WriteLine("Felicidades, adivinaste mi fruta secreta !! :D");
                }
                else
                {
                    Console.WriteLine("Intenta de nuevo...");
                }
            }while(frutaSecreta != frutaUsuario);
            Console.ReadLine();
        }
    }
}
