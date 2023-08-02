using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Bienvenido a C#.");
            Console.WriteLine("¡Espero que te encuentres bien!");

            Console.WriteLine("Mi nombre es Ismael y tengo 18");
            Console.WriteLine();

            int edad;
            Console.WriteLine("¿Cual es tu edad?");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Wow, tu edad es "+edad);
            Console.ReadLine();
            
             
            Console.ReadKey();
        }
    }
}
