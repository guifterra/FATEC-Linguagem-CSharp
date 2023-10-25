using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Ex_12
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ex 12
            double num, raiz_2, raiz_3;

            // Leitura de valor
            Console.Write("\n\t Inserir valor para obtencao de raiz: ");
            num = Convert.ToDouble(Console.ReadLine());

            const double c1 = 0.5;
            const double c2 = ((double)1/3);

            // Calculo de raizes
            raiz_2 = Math.Pow(num, c1);
            raiz_3 = Math.Pow(num, c2);

            // Impressao
            Console.WriteLine("\n\t O numero digitado foi: " + num);
            Console.WriteLine("\t A raiz quadrada é: " + raiz_2);
            Console.WriteLine("\t A raiz cúbica é: " + raiz_3);

            // Distanciamento 
            Console.WriteLine("\n\n");

        }
    }
}
