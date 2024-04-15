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

            int fromInt = 123;
            double fromDouble = 123.45;
            string fromString = "01/04/2024 10:00:01";
            bool fromBoolean = true;
            DateTime fromDateTime = DateTime.Now;

            // Ejemplos de conversión
            byte toByte = Convert.ToByte(fromInt);
            //double toDouble = Convert.ToDouble(fromString);
            int toInt = Convert.ToInt32(fromDouble);
            bool toBoolean = Convert.ToBoolean(fromInt);
            string toString = Convert.ToString(fromDateTime);
            DateTime toDateTime = Convert.ToDateTime(fromString);

            // Trabajando con base 64
            byte[] bytes = new byte[] { 1, 2, 3, 4, 5 };
            string base64String = Convert.ToBase64String(bytes);
            byte[] bytesFromBase64String = Convert.FromBase64String(base64String);
            Console.WriteLine(toDateTime);
            Console.ReadLine();
        }
    }
}
