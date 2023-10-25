using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_49
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 49
            double i = 0, soma = 0;

            // Loop 1
            while (i <= 100)
            {
                soma += i;
                i++;
            }

            // Impressao
            Console.WriteLine("\n O valor da soma dos numeros de 0 a 100 é: {0} \n\n", soma);
        }
    }
}
