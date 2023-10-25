using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_69
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 69
            int A = 0, B = 0, C = 0;
            bool loop_escolha = true;

            // Escolha
            while(loop_escolha == true)
            {
                // Leitura
                Console.Write("\n Inserir numero: ");
                A = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n Inserir numero: ");
                B = Convert.ToInt32(Console.ReadLine());

                // Condica0
                if ((A > 0) && (B > 0))
                {
                    loop_escolha = false;
                }
                else
                {
                    Console.WriteLine(" Os valores inseridos devem ser maiores que 0!");
                }
            }

            if (A == B)
            {
                C = A + B;
                Console.WriteLine("\n {0} + {1} = {2} \n", A, B, C);
            }
            else
            {
                C = A * B;
                Console.WriteLine("\n {0} * {1} = {2} \n", A, B, C);
            }
        }
    }
}
