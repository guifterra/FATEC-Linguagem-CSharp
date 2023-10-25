using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_43
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 43
            int num;

            // Leitura
            Console.Write("\n Inserir numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Condica0
            if (num == 0)
            {
                Console.WriteLine("\n\n O numero inserido é neutro! \n\n");
            }
            else
            {
                if(num > 0)
                {
                    Console.WriteLine("\n\n O numero digitado é : " + num);

                    Console.WriteLine(" Sua raiz quadrada é : " + (Math.Round(Math.Sqrt(num),2)) + "\n\n" );
                }
                else
                {
                    Console.WriteLine("\n\n O numero digitado é : " + num);

                    Console.WriteLine(" Seu valor elevado ao quadrado é : " + (Math.Pow(num,2)) + "\n\n");
                }
            }
        }
    }
}
