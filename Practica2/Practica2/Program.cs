using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabla1 = new int[3, 3];
            int f, c;
            double suma;
            Console.WriteLine("Programa usando arreglos bidimensionales");
            Console.WriteLine("Digita los datos del arreglo");
            //Llenar el arreglo
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    tabla1[f, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("");
            //Imprimir el arreglo
            Console.WriteLine("Imprimiendo el arreglo...");
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write(" " + tabla1 [ f , c ] );
                } 
                Console.WriteLine("");
                suma = f + c;
            }
            Console.WriteLine(value: $"La suma del arreglo es:{suma}");
            Console.ReadKey();
        }
    }
}
