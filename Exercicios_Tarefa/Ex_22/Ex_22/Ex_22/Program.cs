using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 22

            double nota1, nota2, nota3, media;
            int num_notas = 3;
            const double nota_min = 7.5;

            // Leitura de notas
            Console.Write("\n Inserir a nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir a nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir a nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            // Media
            media = Math.Round(((nota1 + nota2 + nota3) / num_notas),2); // Arredondamento para 2 cadas decimais no máximo

            Console.WriteLine("\n Sua média é " + media + "!");

            // Comparação
            if(media >= nota_min)
            {
                Console.WriteLine("\n Vc foi aprovado! \n");
            }
            else
            {
                Console.WriteLine("\n Vc foi Reprovado :( \n");
            }
        }
    }
}
