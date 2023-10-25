using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_36
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 36
            double diagonal_1, diagonal_2, area_losango;

            // Leitura
            Console.Write("\n Inserir valor da diagonal 1: ");
            diagonal_1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir valor da diagonal 2: ");
            diagonal_2 = Convert.ToDouble(Console.ReadLine());

            switch((diagonal_1 > 0) && (diagonal_2 > 0))
            {

                case true:

                    area_losango = (diagonal_1 * diagonal_2) / 2;

                    // Impreesao
                    Console.WriteLine("\n\n A area do losango de diagonais {0} e {1} é {2} \n\n",diagonal_1, diagonal_2, area_losango);

                    break;

                default:

                    Console.WriteLine("\n\n Um dos valores inseridos é invalido \n\n");

                    break;

            }


        }
    }
}
