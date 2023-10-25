using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_1, numero_2, quantidade_impar_m5 = 0, maior, menor, aux;

            // Leitura
            Console.Write("\n Inserir Primeiro Numero: ");
            numero_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Inserir Segundo Numero: ");
            numero_2 = Convert.ToInt32(Console.ReadLine());

            // Identificacao
            if (numero_1 > numero_2)
            {
                maior = numero_1;
                menor = numero_2;
            }
            else
            {
                maior = numero_2;
                menor = numero_1;
            }

            // Contagem
            for (aux = menor; aux <= maior; aux++)
            {
                if (((aux % 2) != 0) && ((aux % 5) == 0))
                {
                    quantidade_impar_m5 += 1;
                }
            }

            Console.WriteLine("\n A quantidade de numeros impares multiplos de 5 no intervalo de " + menor + " a " + maior + " é: " + quantidade_impar_m5);
            Console.WriteLine("");
        }
    }
}
