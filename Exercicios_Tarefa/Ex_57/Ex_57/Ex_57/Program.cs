using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_57
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 57
            int num = 1, soma = 0, limite = 0;

            // Loop 1
            while (limite < 50)
            {
                if ((num%2) == 0)
                {
                    soma += num;
                    limite += 1;
                }

                num++;
            }

            // Impressao
            Console.WriteLine("\n A soma dos {0} primeiros numeros pares positivos é {1} \n", limite, soma);

        }
    }
}
