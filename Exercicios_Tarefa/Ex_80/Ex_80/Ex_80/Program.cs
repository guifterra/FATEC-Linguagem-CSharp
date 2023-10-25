using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_80
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 80
            double aux, quadrado;

            for(aux = 1; aux <= 20; aux++)
            {
                quadrado = Math.Pow(aux, 2);
                Console.WriteLine("\n O valor de " + aux + " ao quadrado é: " + quadrado);
            }
            Console.WriteLine("");
        }
    }
}
