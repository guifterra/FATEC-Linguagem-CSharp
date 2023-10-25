using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_39
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 39
            double num, num_quadrado, num_raiz_3;

            // Leitura
            Console.Write("\n Inserir valor: ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\n O valor inserido é : " + num);
            // Condica0
            if(num == 10)
            {
                Console.WriteLine("\n\n O valor inserido é igual a dez \n\n");
            }
            else
            {
                if(num > 10)
                {
                    Console.WriteLine("\n\n O valor inserido é maior que dez");

                    // Calculo
                    double cubo = 1;
                    cubo /= 3;

                    num_raiz_3 = (Math.Pow(num,cubo));

                    Console.WriteLine(" A raiz cubica do numero é " + num_raiz_3 + "! \n\n");
                }
                else
                {
                    Console.WriteLine("\n\n O valor inserido é menor que dez \n\n");
                }
            }
        }
    }
}
