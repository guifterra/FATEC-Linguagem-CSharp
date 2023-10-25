using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 29
            double num1, num2, soma;

            // Leitura
            Console.Write("\n Inserir numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Calculo
            soma = num1 + num2;

            if(soma > 10)
            {
                // Auxiliar 0,333333
                double um_terco = 1;
                um_terco /= 3;

                Console.WriteLine("\n\n Os numeros digitados foram {0} e {1}", num1, num2);
                Console.WriteLine(" Sua soma é " + soma);
                Console.WriteLine(" A raiz cubica de sua soma é " + (Math.Pow(soma, um_terco)));
            }
            else
            {
                Console.WriteLine("\n\n Os numeros digitados foram {0} e {1}", num1, num2);
                Console.WriteLine(" Sua soma é " + soma);
            }

            Console.WriteLine("");

        }
    }
}
