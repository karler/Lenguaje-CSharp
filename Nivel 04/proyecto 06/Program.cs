using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_06
{
    internal class Program
    {
        public class Atbash
        {
            
            public string Cifrar(string mensaje)    
            {
                char[] alfabetoa = "abcdefghijklmn".ToCharArray();
                char[] alfabetob = "zyxwvutsrqpoñ ".ToCharArray();
                string resultado = "";
                int posa, posb;

                char[] mensajeOriginal = mensaje.ToCharArray();

                foreach(char letra in mensajeOriginal)
                {
                    posa = Array.IndexOf(alfabetoa, letra);
                    if (posa >= 0)
                    {
                        resultado = resultado + alfabetob[posa];
                    }

                    posb = Array.IndexOf(alfabetob, letra);
                    if (posb >= 0)
                    {
                        resultado = resultado + alfabetoa[posb];
                    }
                }
                return resultado;
            }
            
      


        }
        static void Main(string[] args)
        {
            string texto;
            Atbash cifradoAtbash = new Atbash();
            texto = Console.ReadLine();
            Console.WriteLine(cifradoAtbash.Cifrar(texto));
            Console.ReadLine();
        }
    }
}
