using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cp = 0;
            int cip = 0;
            const int tam = 10;
            int[] num = new int[tam];
            Console.WriteLine("Digite los datos del arreglo");
            Console.WriteLine();
            for (int i = 0; i < tam; i++) {
                Console.WriteLine("Ingresa número: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Datos del arreglo: ");
            Console.WriteLine();
            for (int i = 0; i < tam; i++) {
                if (num[i] % 2 == 0)
                {
                    cp++;
                }
                else 
                {
                    cip++;
                }
                Console.WriteLine(num[i] + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine($"Cantidad de pares: {cp}");
            Console.WriteLine($"Cantida de impares: {cip}");
            Console.ReadKey();
        }
    }
}
