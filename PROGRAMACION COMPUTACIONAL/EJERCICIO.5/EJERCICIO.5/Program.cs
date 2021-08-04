using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double impuesto, precio, preconimpuesto;
            int producto;

            Console.Write("--Menú--");
            Console.Write("\n1) Frutas");
            Console.Write("\n2) Lacteos");
            Console.Write("\n3) Medicinas");
            Console.Write("\nSelecciona una opción:  ");
            producto = Int32.Parse(Console.ReadLine());

            Console.Write("\nIngrese el impuesto del dia (%): ");
            impuesto = Double.Parse(Console.ReadLine());

            if (producto == 1 || producto == 2)
            {
                Console.Write("\nIngrese el precio del producto: ");
                precio = Double.Parse(Console.ReadLine());
                preconimpuesto = ((impuesto / 100) * precio) + precio;
                Console.Write("\nEl precio del producto es: " + preconimpuesto);
            }
            else if (producto == 3)
            {
                Console.Write("\nIngrese el precio del producto: ");
                precio = Double.Parse(Console.ReadLine());
                Console.WriteLine("\nEl precio del producto es: " + precio);

            }
            else
            {
                Console.WriteLine("\nEl producto no esta disponible");

            }
            Console.ReadKey();
        }
    }
}