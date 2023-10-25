using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {

            // Aula 4
            double n1;

            // Leitura do Valor
            Console.Write("\n\n\t Inserir numero para extracao de raiz: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            // Exibição do valor
            Console.WriteLine("\n\t O valor inserido foi " + n1);

            double raiz;
            raiz = Math.Sqrt(n1);

            Console.WriteLine("\n\t A raiz quadrada do número {0} é {1} \n\n", n1, raiz);

        }
    }
}
