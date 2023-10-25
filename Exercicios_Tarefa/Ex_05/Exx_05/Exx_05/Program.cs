using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exx_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];

            int i;

            for (i = 0; i <= 4; i++)
            {
                Console.Write($"\n Inserir o valor {i+1} : ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n ---> Valores inseridos: ");

            for (i = 0; i <= 4; i++)
            {
                Console.Write($"\n O valor {i+1} inserido foi : {vet[i]}");
            }

            Console.WriteLine("\n\n ---> Soma dos Valores inseridos: \n");

            int soma = 0;
            for (i = 0; i <= 4; i++)
            {
                Console.Write($" {vet[i]} ");

                soma = soma + vet[i];

                if (i <= 3)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write($"= {soma} \n\n");
                }
            }

        }
    }
}
