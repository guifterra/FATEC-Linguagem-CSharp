using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_58
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 58
            bool loop = true;
            int numero, soma = 0, quantidade = 0, soma_pares = 0, quantidade_pares = 0;
            double media = 0, media_pares = 0;

            while (loop)
            {
                Console.Write("\n Inserir numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                {
                    loop = false;
                }
                else
                {

                soma += numero;
                quantidade += 1;
                media = (double)soma / (double)quantidade;

                if ((numero % 2) == 0)
                {
                    soma_pares += numero;
                    quantidade_pares += 1;
                    media_pares = (double)soma_pares / (double)quantidade_pares;
                }
                }

            }

            Console.WriteLine("\n\n A soma dos numeros inseridos é: " + soma);
            Console.WriteLine(" A quantidade de numeros inseridos é: " + quantidade);
            Console.WriteLine(" A média dos numeros inseridos é: " + media);
            Console.WriteLine(" A média dos números pares inseridos é: " + media_pares + "\n\n");
        }
    }
}
