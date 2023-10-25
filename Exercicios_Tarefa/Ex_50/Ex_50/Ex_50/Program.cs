using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_50
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 50
            int i = 0, numero;

            // Leitura
            Console.Write("\n Inserir um numero maior que 0: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            if (numero > 0)
            {
                while (i <= numero)
                {
                    Console.WriteLine("\t" + i);
                    i++;
                }

                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\n Valor invalido! \n");
            }
        }
    }
}
