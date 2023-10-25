using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_37
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 37
            double diagonal_1, diagonal_2, lado;

            // Leitura
            Console.Write("\n Inserir valor da diagonal 1: ");
            diagonal_1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir valor da diagonal 2: ");
            diagonal_2 = Convert.ToDouble(Console.ReadLine());

            // CondicaO
            switch ((diagonal_1 > 0) && (diagonal_2 > 0))
            {
                case true:

                    // Calculo
                    lado = (Math.Sqrt(((Math.Pow((diagonal_1/2),2) + Math.Pow((diagonal_2/2),2)))));

                    Console.WriteLine("\n\n O lado do losango de diagonais {0} e {1} é {2} !\n\n", diagonal_1, diagonal_2, lado);

                    break;

                case false:

                    Console.WriteLine("\n\n Valores invalidos");

                    break;
            }
        }
    }
}
