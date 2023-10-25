using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_40
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 40
            double num1, num2, soma;

            // Leitura de valores
            Console.Write("\n Inserir valor 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir valor 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Calculo
            soma = num1 + num2;

            if (soma <= 10)
            {
                Console.WriteLine("\n\n --> {0} + {1} = {2} \n\n", num1, num2, soma);
            }
            else
            {
                Console.WriteLine("\n\n --> {0} + {1} = {2}", num1, num2, soma);

                double raiz_3_soma, cubo = 1;
                cubo /= 3;

                raiz_3_soma = (Math.Pow(soma, cubo));

                Console.WriteLine(" --> O valor da raiz cubica de {0} é {1} \n\n", soma, Math.Round(raiz_3_soma,2));
            }
        }
    }
}
