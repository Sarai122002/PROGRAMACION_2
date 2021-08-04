using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Calificacion1, Calificacion2, Calificacion3;
            int NotaF;
            int valorapli1, valorapli2, valorapli3;


            Console.WriteLine("Ingrese la Calificacion 1:");
            Calificacion1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Calificacion 2:");
            Calificacion2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Calificacion 3:");
            Calificacion3 = int.Parse(Console.ReadLine());

            valorapli1 = 35 * Calificacion1 / 100;
            valorapli2 = 30 * Calificacion2 / 100;
            valorapli3 = 25 * Calificacion3 / 100;

            Console.WriteLine("");
            Console.WriteLine("la Primer Calificacion segun el valor aplicado del 35% es: " + valorapli1);
            Console.WriteLine("");
            Console.WriteLine("La Segunda Calificacion segun el valor aplicado del 30% es: " + valorapli2);
            Console.WriteLine("");
            Console.WriteLine("La Tercera Calificacion segun el valor aplicado del 25% es: " + valorapli3);
            Console.WriteLine("");

            NotaF = valorapli1 + valorapli2 + valorapli3;

            Console.WriteLine("La Calificacion final que obtuvo es: " + NotaF);
            Console.ReadKey();
        }
    }
}