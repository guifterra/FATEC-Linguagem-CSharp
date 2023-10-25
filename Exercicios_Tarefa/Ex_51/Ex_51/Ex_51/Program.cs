using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_51
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 51
            int numero, i = 20;

            // Leitura
            Console.Write("\n Inserir valor menor que 10: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            // Condica0
            if (numero < 10)
            {
                while (i != numero)
                {
                    Console.WriteLine("\t" + i);
                    i--;
                }

                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine(" Valor invalido! \n");
            }

        }
    }
}
