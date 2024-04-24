using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Array de palabras para adivinar
            //string[] frutas = { "manzana", "banana", "cereza", "durazno", "fresa", "kiwi", "mango", "naranja", "pera", "piña" };
            string[] frutas = {
            "Aguaje",
            "Camu camu",
            "Chirimoya",
            "Cocona",
            "Guanábana",
            "Lúcuma",
            "Maracuyá",
            "Pacae",
            "Pepino dulce",
            "Pitahaya",
            "Tuna",
            "Uva",
            "Manzana",
            "Plátano",
            "Naranja",
            "Mandarina",
            "Lima",
            "Limón",
            "Toronja",
            "Piña",
            "Mango",
            "Papaya",
            "Sandía",
            "Melón",
            "Palta",
            "Granadilla",
            "Guayaba",
            "Ciruela",
            "Durazno",
            "Higo",
            "Membrillo",
        };
            Random rnd = new Random();
            int indice = rnd.Next(frutas.Length);
            string frutaSecreta = frutas[indice];

            Console.WriteLine("¡Adivina la fruta que estoy pensando!");

            int intentos = 0;
            bool adivinado = false;

            while (!adivinado)
            {
                intentos++;
                Console.Write($"Intento {intentos}: ");
                string frutaUsuario = Console.ReadLine().ToLower();

                if (frutaSecreta == frutaUsuario)
                {
                    adivinado = true;
                    Console.WriteLine("¡Felicidades, adivinaste la fruta secreta! :D");
                }
                else
                {
                    Console.WriteLine("¡Incorrecto! Sigue intentando...");

                    // Pista cada 2 intentos fallidos
                    if (intentos % 2 == 0 && intentos < frutaSecreta.Length * 2)
                    {
                        int letrasReveladas = intentos / 2;
                        string pista = frutaSecreta.Substring(frutaSecreta.Length - letrasReveladas);
                        Console.WriteLine($"Pista: Las últimas {letrasReveladas} letras son: {pista}");
                    }
                }
            }

            Console.WriteLine($"Lo lograste en {intentos} intentos.");
            Console.ReadLine();

        }
    }
}
