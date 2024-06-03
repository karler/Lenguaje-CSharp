using System;

namespace proyecto_08
{
    public class calculadora
    {
        private double a;
        private double b;
        private string operacion;
        private double resultado;

        public void ingresarDatos()
        {
            Console.Write("Ingrese el 1er número: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la operación (+, -, *, /): ");
            operacion = Console.ReadLine();
            Console.Write("Ingrese el 2do número: ");
            b = double.Parse(Console.ReadLine());
        }
        private double sumar()
        {
            return a + b;
        }
        private double restar()
        {
            return a - b;
        }
        private double multiplicar()
        {
            return b * a;
        }
        private double dividir()
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a / b;
            }
        }
        public string MostrarResultado()
        {
            return $"El resultado es: {resultado}";
        }
        public void calcular() 
        {
            switch (operacion)
            {
                case "+":
                    resultado = sumar();
                    break;
                case "-":
                    resultado = restar();
                    break;
                case "*":
                    resultado = multiplicar();
                    break;
                case "/":
                    resultado = dividir();
                    break;
                default:
                    Console.WriteLine("Operación erronea");
                    break;
            }
        }
    }
        

    internal class Program
    {
        static void Main(string[] args)
        {
            calculadora micalculadora = new calculadora();
            micalculadora.ingresarDatos();
            micalculadora.calcular();
            Console.WriteLine(micalculadora.MostrarResultado());
            Console.ReadLine();
        }
    }
}
