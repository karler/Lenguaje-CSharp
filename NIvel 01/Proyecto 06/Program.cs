using System;

namespace Proyecto_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 12;

            int mayor;

            if (num1 > num2)
            {// num1 > num2 => ingresa cuando num1 es mayor
                mayor = num1;
                //Console.WriteLine("Ingreso al lado del True");
            }
            else
            {// num 1 <= num2 => ingresa cuando num2 es mayor o igual
                mayor = num2;
                //Console.WriteLine("Ingreso al lado del False");
            }

            //Console.WriteLine("El número mayor es {0}", mayor);

            double montoCompra = 99;
            double descuento = 0;

            if (montoCompra >= 200)
            {// montocompra >= 200
                descuento = 0.15; // 15% de descuento
                Console.WriteLine("Ingreso al lado del True");
            }
            else if (montoCompra >= 100)
            {//montocompra < 200 y montocompra >= 100
                descuento = 0.10; // 10% de descuento
                Console.WriteLine("Ingreso al lado del else if");
            }
            else
            {// {montocompra >= 200} o montocompra < 100
                descuento = 0; // No hay descuento
                Console.WriteLine("Ingreso al lado del else if - else");
            }

            double montoPagar = montoCompra * (1 - descuento);

            Console.WriteLine("El monto de la compra es: {0:C2}", montoCompra);
            Console.WriteLine("El descuento aplicado es: {0:P}", descuento);
            Console.WriteLine("El monto a pagar es: {0:C2}", montoPagar);
            Console.ReadLine();
        }
    }
}
