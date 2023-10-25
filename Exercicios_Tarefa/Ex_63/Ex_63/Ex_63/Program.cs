using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_63
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 63
            double aux, soma = 0;

            // Loop
            for (aux = 1; aux <= 200; aux++)
            {
                if ((aux%2) != 0)
                {
                    soma += aux;
                }
            }

            // Impressao
            Console.WriteLine("\n A soma dos numeros impares de 1 a 200 é : " + soma + "\n");
        }
    }
}
