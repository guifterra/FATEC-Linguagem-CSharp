using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_48
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 48
            double nota1,
                   nota2,
                   nota3,
                   media,
                   escolha;

            // Leitura
            Console.Write("\n Inserir nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            // Escolha
            Console.WriteLine("\n\n 1- Aritmetica \n 2- Ponderada \n\n");

            Console.Write("\n Inserir escolha: ");
            escolha = Convert.ToDouble(Console.ReadLine());

            // Impressao + condica0
            if ((escolha == 1) || (escolha == 2))
            {
                if(escolha == 1)
                {
                    media = (nota1 + nota2 + nota3) / 3;
                    Console.WriteLine("\n\n Media aritmetica: {0} \n\n", media);
                }
                else
                {
                    media = ((nota1 * 3) + (nota2 * 3) + (nota3 * 4)) / 10;
                    Console.WriteLine("\n\n Media ponderada: {0} \n\n", media);
                }
            }
            else
            {
                Console.WriteLine("\n\n Escolha nao identificada! \n\n ");
            }
        }
    }
}
