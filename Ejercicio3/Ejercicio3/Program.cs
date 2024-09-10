using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rangos = new int[9];
            double salarioBase= 200, ventasBrutas, salario, comision = 0.09;

            Console.WriteLine("Ingrese el número de vendedores");
            int numVendedores = int.Parse(Console.ReadLine());

            for (int i = 0; i < numVendedores; i++) 
            {
                Console.WriteLine($"Ventas brutas del vendedor {i + 1}: ");
                ventasBrutas = double.Parse(Console.ReadLine());
                salario = (ventasBrutas * comision)+ salarioBase;

                // Determinar en qué rango cae el salario
                if (salario >= 200 && salario <= 299)
                    rangos[0]++;
                else if (salario >= 300 && salario <= 399)
                    rangos[1]++;
                else if (salario >= 400 && salario <= 499)
                    rangos[2]++;
                else if (salario >= 500 && salario <= 599)
                    rangos[3]++;
                else if (salario >= 600 && salario <= 699)
                    rangos[4]++;
                else if (salario >= 700 && salario <= 799)
                    rangos[5]++;
                else if (salario >= 800 && salario <= 899)
                    rangos[6]++;
                else if (salario >= 900 && salario <= 999)
                    rangos[7]++;
                else if (salario >= 1000)
                    rangos[8]++;
            }
            // Mostrar los resultados
            Console.WriteLine("\nCantidad de vendedores en cada rango de salario:");
            Console.WriteLine("$200 - $299: " + rangos[0]);
            Console.WriteLine("$300 - $399: " + rangos[1]);
            Console.WriteLine("$400 - $499: " + rangos[2]);
            Console.WriteLine("$500 - $599: " + rangos[3]);
            Console.WriteLine("$600 - $699: " + rangos[4]);
            Console.WriteLine("$700 - $799: " + rangos[5]);
            Console.WriteLine("$800 - $899: " + rangos[6]);
            Console.WriteLine("$900 - $999: " + rangos[7]);
            Console.WriteLine("$1000 o más: " + rangos[8]);
            Console.ReadKey();
        }
    }
}
