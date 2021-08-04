using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.WriteLine("Ingrese la cantidad de Grados Centigrados: ");
            c = Convert.ToDouble(Console.ReadLine());

            f = (9 / 5) * c + 32;

            Console.WriteLine("Grados Fahrenheit: " + f);
            Console.ReadKey();
        }
    }
}