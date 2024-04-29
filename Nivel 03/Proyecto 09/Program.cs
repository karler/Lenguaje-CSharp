using System;

namespace Proyecto_09
{
    internal class Program
    {
        // Variable de ámbito de clase (también conocida como variable de instancia)
        private int variableDeClase = 10;

        // Variable estática (simula un ámbito global dentro del contexto de la clase)
        private static int variableGlobal = 20;

        static void Main(string[] args)
        {
            // Creación de un objeto de la clase Program
            Program demo = new Program();

            // Llamada al método de la instancia que muestra el uso de variables
            demo.MetodoDeInstancia();

            // Llamada al método estático
            MetodoEstatico();
        }

        void MetodoDeInstancia()
        {
            // Variable de ámbito de método
            int variableLocal = 5;

            if (variableLocal > 0)
            {
                // Variable de ámbito de bloque
                int variableDeBloque = variableLocal + variableDeClase;
                Console.WriteLine("Variable de Bloque: " + variableDeBloque);
            }

            // Aquí no podemos acceder a variableDeBloque porque su ámbito es solo dentro del bloque if

            Console.WriteLine("Variable Local: " + variableLocal);
            Console.WriteLine("Variable de Clase (Instancia): " + variableDeClase);
        }

        static void MetodoEstatico()
        {
            // Acceso a la variable estática (global dentro de la clase)
            Console.WriteLine("Variable Global (Estática): " + variableGlobal);

            // No se puede acceder a variableDeClase porque es una variable de instancia
            // Intentar hacerlo aquí causaría un error de compilación
        }
    }
}
