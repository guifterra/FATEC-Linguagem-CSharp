using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_56
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 56
            int numero, aux = 1;

            // Loop 1 
            while(aux <= 5)
            {
                Console.Write("\n Inserir numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" O valor do numero {0} ao quadrado é: {1}", numero, (Math.Pow(numero, 2)));

                aux++;
            }

            Console.WriteLine("\n");

        }
    }
}
