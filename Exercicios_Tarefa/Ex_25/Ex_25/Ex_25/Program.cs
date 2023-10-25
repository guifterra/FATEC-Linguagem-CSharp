using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_25
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 25
            double cateto1 = 0, cateto2 = 0, hip, loop = 0;

            // Leitura de catetos
            while (loop == 0)
            {
                Console.Write("\n Inserir valor do cateto 1: ");
                cateto1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n Inserir valor do cateto 2: ");
                cateto2 = Convert.ToInt32(Console.ReadLine());

                if((cateto1 > 0) && (cateto2 > 0))
                {
                    loop = 1;
                }
                else
                {
                    Console.WriteLine("\n Um dos valores inseridos é menor ou igual a zero, por favor, troque o valor! \n\n");
                }
            }

            // Calculo
            hip = Math.Sqrt(((Math.Pow(cateto1,2)) + (Math.Pow(cateto2,2))));

            // Impressoes
            Console.WriteLine("\n\n O valor dos catetos sao: {0} e {1}",cateto1,cateto2);
            Console.WriteLine("\n O valor da hipotenusa é " + hip + "\n");

        }
    }
}
