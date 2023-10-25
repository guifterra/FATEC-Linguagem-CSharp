using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_60
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 60
            int inicio = 1, fim = 100, aux, soma = 0;

            Console.WriteLine("\n");

            // Loop
            for (aux = inicio; aux <= fim; aux++)
            {
                if (((aux % 2) == 0)){

                    Console.WriteLine("\t" + aux);
                    soma += aux;
                }
                else
                {
                    if (((aux % 5) == 0))
                    {

                        Console.WriteLine("\t" + aux);
                        soma += aux;
                    }
                    else
                    {
                        if (((aux % 7) == 0))
                        {

                            Console.WriteLine("\t" + aux);
                            soma += aux;
                        }
                    }
                }
                
            }

            Console.WriteLine("\n\n A soma dos numeros é: " + soma + "\n\n");
        }
    }
}
