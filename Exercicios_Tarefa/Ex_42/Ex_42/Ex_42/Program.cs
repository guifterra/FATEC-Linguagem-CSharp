using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_42
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 42
            int decisao;

            // Opções
            Console.WriteLine("\n\t 1- Soma");
            Console.WriteLine("\t 2- Subtracao");
            Console.WriteLine("\t 3- Multiplicacao");
            Console.WriteLine("\t 4- Divisao\n");
            Console.WriteLine("\t Outros- Sair \n\n");

            // Leitura
            Console.Write("\t Inserir escolha: ");
            decisao = Convert.ToInt32(Console.ReadLine());

            // Opc
            if ((decisao >= 1) && (decisao <= 4))
            {
                double num1, num2;

                // Leitura
                Console.Write("\n\n\t Inserir valor para op: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\n\t Inserir outro valor para op: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                switch (decisao)
                {
                    case 1:

                        Console.WriteLine("\n\t --> {0} + {1} = {2}", num1, num2, (num1 + num2));

                        Console.WriteLine("\n\n\t Fim de  programa . . . \n\n");

                        break;

                    case 2:

                        Console.WriteLine("\n\t --> {0} - {1} = {2}", num1, num2, (num1 - num2));

                        Console.WriteLine("\n\n\t Fim de  programa . . . \n\n");

                        break;

                    case 3:

                        Console.WriteLine("\n\t --> {0} x {1} = {2}", num1, num2, (num1 * num2));

                        Console.WriteLine("\n\n\t Fim de  programa . . . \n\n");

                        break;

                    case 4:

                        if(num2 == 0)
                        {
                            Console.WriteLine("\t --> O denominador é 0, a op não pode ser feita!");

                            Console.WriteLine("\n\n\t Fim de  programa . . . \n\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\t --> {0} / {1} = {2}", num1, num2, (Math.Round((num1 / num2),2)));

                            Console.WriteLine("\n\n\t Fim de  programa . . . \n\n");
                        }

                        break;
                }

            }
            else
            {
                Console.WriteLine("\n\n\t Fim de  programa . . . \n\n");
            }
        }
    }
}
