using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Ex_15
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ex 15
            double lado1, lado2, lado3, Volume;

            // Leitura de Lados
            Console.Write("\n\n\t Inserir o valor do lado 1: ");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\t Inserir o valor do lado 2: ");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\t Inserir o valor do lado 3: ");
            lado3 = Convert.ToDouble(Console.ReadLine());

            // Calculo de Volume
            Volume = lado1 * lado2 * lado3;

            // Impressao
            Console.WriteLine("\n\n\t Volume = lado1 * lado2 * lado3 = {0} * {1} * {2} = {3}\n", lado1, lado2, lado3, Volume);
        }
    }
}
