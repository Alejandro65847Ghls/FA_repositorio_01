using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer1();
                Console.ReadKey();

            
            
                ejer2();
                Console.ReadKey();

            ejer3();
            Console.ReadKey();

        }


        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera");
            carrera = Console.ReadLine();


            Console.WriteLine($"\n{nombre}, bienvenido al FA de {carrera}");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Alejandro\"");

        }
        static void ejer3()
        {
            Console.Write("Ingrese num 1:");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese num 2:");
            int y = Convert.ToInt32(Console.ReadLine());

            double divi = x / y;
            //double divi Devuelve el resultado en decimal

            Console.WriteLine("\nSuma: " + (x + y));
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicación: " + (x * y));
            Console.WriteLine("División: " + divi);
        }




    }
}
