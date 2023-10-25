using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_21
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ex 21
            double nota1, nota2, nota3, nota4, media;
            const int peso1 = 3, peso2 = 5, peso3 = 6, peso4 = 6;

            // Leitura de notas
            Console.Write("\n Inserir sua nota no peso 3: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir sua nota no peso 5: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir sua nota no peso 6: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir sua nota no peso 6: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            // Media
            media = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3) + (nota4 * peso4)) / (peso1 + peso2 + peso3 + peso4);

            Console.WriteLine("\n\n A média do aluno é " + media);

            // Passou ou rec?
            if(media >= 6.0)
            {
                Console.WriteLine(" O aluno foi aprovado! \n");
            }
            else
            {
                Console.WriteLine(" O aluno foi reprovado \n");
            }




        }
    }
}
