using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_53
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 53
            int numero1, numero2, aux, soma = 0;

            // Leitura
            Console.Write("\n Inserir numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Inserir numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            int maior, menor;

            Console.WriteLine("\n");

            // Condicao
            if (numero1 > numero2)
            {
                maior = numero1;
                menor = numero2;

                aux = menor;

                while (aux <= maior)
                {
                    soma += aux;
                    aux++;
                }
                Console.WriteLine(" o Valor da soma dos numero entre {0} e {1} é {2} ! \n\n", numero1, numero2, soma);
            }
            else
            {
                menor = numero1;
                maior = numero2;

                aux = menor;
                while (aux <= maior)
                {
                    soma += aux;
                    aux++;
                }
                Console.WriteLine(" o Valor da soma dos numero entre {0} e {1} é {2} ! \n\n", numero1, numero2, soma);
            }
        }
    }
}
