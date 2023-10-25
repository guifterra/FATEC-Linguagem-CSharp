using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_1, numero_2, maior, menor, aux, controle_igual = 0;

            // Leitura de Numeros
            Console.Write("\n Inserir Primeiro Numero: ");
            numero_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Inserir Segundo Numero: ");
            numero_2 = Convert.ToInt32(Console.ReadLine());

            // Determinação de Maior e Menor
            if (numero_1 > numero_2)
            {
                maior = numero_1;
                menor = numero_2;
            }else if(numero_1 == numero_2)
            {
                controle_igual = 1;
                maior = 0;
                menor = 0;
            }
            else
            {
                maior = numero_2;
                menor = numero_1;
            }

            // Impressa0
            if (controle_igual == 0)
            {
                Console.WriteLine("\n\n O maior numero é: " + maior);
                Console.WriteLine(" O menor numero é: " + menor);
            }
            else
            {
                Console.WriteLine("\n\n Os números são iguais !");
            }

            if (controle_igual == 0)
            {
                Console.Write("\n\n Intervalo: ");
                for (aux = menor; aux <= maior; aux++)
                {
                    Console.Write(aux + " ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\n\n Intervalo: " + numero_1);
                Console.WriteLine("\n");
            }
            
        }
    }
}
