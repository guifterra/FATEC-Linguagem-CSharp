using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_52
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 52
            int numero1, numero2, aux;

            // Leitura
            Console.Write("\n Inserir numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Inserir numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            int maior, menor;

            Console.WriteLine("\n");

            // Condicao
            if (numero1 != numero2)
            {


                if (numero1 > numero2)
                {
                    maior = numero1;
                    menor = numero2;

                    aux = menor;

                    while (aux <= maior)
                    {
                        Console.WriteLine("\t" + aux);
                        aux++;
                    }
                    Console.WriteLine("\n");
                }
                else
                {
                    menor = numero1;
                    maior = numero2;

                    aux = menor;
                    while (aux <= maior)
                    {
                        Console.WriteLine("\t" + aux);
                        aux++;
                    }
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine(" Os numeros sao iguais, ERRO! \n\n");
            }
        }
    }
}
