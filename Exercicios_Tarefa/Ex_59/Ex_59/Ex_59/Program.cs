using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_59
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 59
            int inicio = 1000, fim = 0, aux, soma = 0;

            // Loop
            for (aux = inicio; aux >= 0; aux--)
            {

                if (((aux%3) == 0) && ((aux%5) == 0))
                {
                    soma += aux;
                }

            }

            Console.WriteLine("\n A soma dos numeros entre 0 e 1000 divisíveis por 3 e por 5 é {0} \n\n", soma);
        }
    }
}
