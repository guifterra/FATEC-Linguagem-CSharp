using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 31
            double num1, num2, num3, soma;

            // Leitura de Valores
            Console.Write("\n Inserir o valor do numero 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Inserir o valor do numero 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Inserir o valor do numero 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            // Calculo
            soma = ((Math.Pow(num1,2)) + (Math.Pow(num2, 2)) + (Math.Pow(num3, 2)));

            // Impressao
            Console.WriteLine("\n\n A soma dos numeros {0}, {1} e {2} ao quadrado é {3} !", num1, num2, num3, soma);

            // Impressao par ou impar
            if ((soma%2) == 0)
            {
                Console.WriteLine(" A soma deles é par! \n\n");
            }
            else
            {
                Console.WriteLine(" A soma deles é impar! \n\n");
            }
        }
    }
}
