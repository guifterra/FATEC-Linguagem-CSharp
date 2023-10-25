using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_70
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 70
            int variavel;

            // Leitura
            Console.Write("\n Inserir numero: ");
            variavel = Convert.ToInt32(Console.ReadLine());

            // Condica0
            if ((variavel % 2) == 0)
            {
                Console.WriteLine("\n {0} + 5 = {1} \n", variavel, (variavel + 5));
            }
            else
            {
                Console.WriteLine("\n {0} + 8 = {1} \n", variavel, (variavel + 8));
            }
        }
    }
}
