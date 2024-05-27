using System;

namespace proyecto_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar un char y un string
            char inicial = 'J';
            string nombre = "Juan";

            // Imprimir la inicial en mayúscula
            Console.WriteLine("Inicial: " + char.ToLower(inicial));

            // Concatenar la inicial con el nombre
            Console.WriteLine("Nombre completo: " + inicial + " " + nombre);

            // Calcular la longitud del nombre
            Console.WriteLine("Longitud del nombre: " + nombre.Length);

            Console.WriteLine("Minusculas del nombre: " + nombre.ToLower());
            // Verificar si el nombre contiene la letra "a"
            Console.WriteLine("¿Contiene la letra 'a'?: " + nombre.Contains("a"));

            // Ahora trabajaremos con cada letra de un STRING
            string frase = "Hola mundo";
            char[] caracteres = frase.ToCharArray();

            Console.WriteLine("Longitud del array: " + caracteres.Length);

            Console.WriteLine("Tercer carácter: " + caracteres[2]);

            // Recoremos todas las letras con FOREACH
            foreach (char letra in caracteres)
            {
                Console.WriteLine(letra);
            }
            
            // Si queremos tener la posición en una variable i, usamos FOR
            int i;
            string fraseinversa="";
            for (i = caracteres.Length - 1; i >= 0; i--)
            {
                if (caracteres[i] == 'a')
                {
                    caracteres[i] = 'F';
                }
                fraseinversa = fraseinversa + caracteres[i];
            }
            Console.WriteLine(fraseinversa);
            Console.ReadLine();
        }
    }
}