using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Ex_13
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ex_13
            double num1, num2, num3, num4, media_pond;

            // Leitura de Numeros
            Console.Write("\n Inserir numero 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir numero 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir numero 3: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir numero 4: ");
            num4 = Convert.ToDouble(Console.ReadLine());

            // Calculo de media ponderada
            media_pond = (((num1 * 1) + (num2 * 2) + (num3 * 3) + (num4 * 4)) / (double)10);

            // Impressao
            Console.WriteLine("\n\n A media ponderada é: " + media_pond + "\n\n");

        }
    }
}
