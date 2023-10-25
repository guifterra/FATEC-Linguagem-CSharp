using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 26
            int numero = 0, loop = 0;

            // Leitura
            while(loop == 0)
            {
                Console.Write("\n Inserir numero positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    loop = 1;
                }
                else
                {
                    Console.WriteLine("\n O numero inserido nao é positivo, por favor, troque-o!");
                }
            }

            Console.WriteLine("\n O valor inserido foi " + numero);

            if((numero%2) == 0)
            {
                Console.WriteLine("\n O numero {0} é par! \n", numero);
            }
            else
            {
                Console.WriteLine("\n O numero {0} é impar! \n", numero);
            }

        }
    }
}
