using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_83
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 83
            double aux, soma = 0;

            for (aux = 1; aux <= 100; aux++)
            {
                Console.WriteLine("\n " + aux);
                soma += aux;
            }
            Console.WriteLine("\n Soma dos numeros: "+ soma + "\n");
        }
    }
}
