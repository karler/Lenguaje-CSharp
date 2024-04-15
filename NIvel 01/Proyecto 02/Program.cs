using System;

namespace Proyecto_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enteros
            int entero = 123; //-2 147 483 648 hasta 2 147 483 648 
            short enterocorto = 32000; //-32 768 hasta 32 768
            long enterolargo = 1234567890123456789L; // -9 trillones hasta 9 trillones
            
            //Decimales
            float flotante = 123.456F; //6-9 digitos de presición
            double doble = 123.45678901234; //15-17 digitos de presición
            decimal decimalnum = 123.654654654654646546546546M; // 29-29 digitos de presición
            //Booleanos
            bool booleano = true; // false (falso) ó true (verdadero)
            //Caracter
            char caracter = 'a'; // Almacena un único carácter Unicode
            //Cadena
            string Texto = "Hola mundo"; // Almacena un grupo de caracteres
            Console.WriteLine($"int: {entero}");
            Console.WriteLine($"short: {enterocorto}");
            Console.WriteLine($"long: {enterolargo}");
            Console.WriteLine($"float: {flotante}");
            Console.WriteLine($"double: {doble}");
            Console.WriteLine($"decimal: {decimalnum}");
            Console.WriteLine($"bool: {booleano}");
            Console.WriteLine($"char: {caracter}");
            Console.WriteLine($"string: {Texto}");

            Console.ReadLine();
        }
    }
}
