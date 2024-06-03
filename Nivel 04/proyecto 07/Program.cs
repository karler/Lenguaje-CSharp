using System;

namespace proyecto_07
{
    internal class Program
    {
        public class Cesar
        {
            public string Cifrar(string texto)
            {
                char[] alfabeto = "abcdefghijklmnopqrstuvwxyz ñ".ToCharArray();
                char[] textoOriginal = texto.ToCharArray();
                string textoCifrado = "";
                int i;
                int pos;
                int desplazamiento = 5;
                // de 0 hasta el final
                for (i = 0; i < textoOriginal.Length; i++)
                {
                    pos = Array.IndexOf(alfabeto, textoOriginal[i]);
                    if (pos + desplazamiento > alfabeto.Length-1)
                    {
                        pos = pos - alfabeto.Length;
                    }
                    textoCifrado = textoCifrado + alfabeto[pos + desplazamiento];
                }
                return textoCifrado;
            }

        }
        static void Main(string[] args)
        {
            string texto;
            Cesar cifradoCesar = new Cesar();
            texto = Console.ReadLine();
            Console.WriteLine(cifradoCesar.Cifrar(texto));
            Console.ReadLine();
        }
    }
}
