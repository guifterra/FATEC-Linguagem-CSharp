using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_44
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 44
            double nota1, nota2, media;
            string nome;

            // Leitura
            Console.Write("\n Inserir o nome: ");
            nome = Console.ReadLine();

            Console.Write("\n Inserir a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            // Condicao
            if ((nota1 >= 0) && (nota1 <= 10) && (nota2 >= 0) && (nota2 <= 10))
            {
                // Calculo
                media = (nota1 + nota2) / 2;

                // Impressoes
                Console.WriteLine("\n\n Usuario: " + nome);
                Console.WriteLine(" Nota 1: " + nota1);
                Console.WriteLine(" Nota 2: " + nota2);
                Console.WriteLine(" Media: " + media);

                // Condica0
                if (media >= 7)
                {
                    Console.WriteLine(" Situacao: Aprovado! \n\n");
                }
                else
                {
                    if (media <= 5)
                    {
                        Console.WriteLine(" Situacao: Retido :( \n\n");
                    }
                    else
                    {
                        Console.WriteLine(" Situacao: Recuperação :/ \n\n");
                    }
                }

            }
            else
            {
                Console.WriteLine("\n\n ERRO! Um dos numeros inseridos não está no intervalo de 0 a 10! \n\n");
            }


        }
    }
}
