using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 0, numero, soma = 0, quantidade = 0, quantidade_impares = 0;

            double media = 0;

            while (loop == 0)
            {
                // Leitura
                Console.Write("\n Inserir numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                // Condica0 de saida
                if(numero < 0)
                {
                    // Forçamento de saida imediata
                    loop = 1;
                    break;
                }
                else
                {
                    // Obtenção de dados
                    soma += numero;
                    quantidade++;

                    if((numero % 2) != 0)
                    {
                        quantidade_impares++;
                    }
                }

            }

            // Calculo de media final
            media = (double)soma / (double)quantidade;

            // Impressao
            Console.WriteLine("\n A soma dos numeros digitados é: " + soma);
            Console.WriteLine(" A quantidade de numeros digitados é: " + quantidade);
            Console.WriteLine(" A quantidade de numeros impares digitados é: " + quantidade_impares);
            Console.WriteLine(" A media dos numeros digitados é: " + media);

            // Espaçamento
            Console.WriteLine("");

        }
    }
}
