using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_88
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 88
            double aux, soma = 0;

            for(aux = 25; aux <= 200; aux++)
            {
                if((aux % 2) == 0)
                {
                    soma += aux;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("\t A soma dos numeros pares entre 25 e 200 é: " + soma);
            Console.WriteLine("");
        }
    }
}
