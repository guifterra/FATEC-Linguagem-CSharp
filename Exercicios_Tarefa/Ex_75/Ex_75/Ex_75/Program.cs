using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_75
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 75
            double numero, quadrado, aux;

            for(aux = 1; aux <= 5; aux++)
            {
                Console.Write("\n Inserir numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                quadrado = Math.Pow(numero, 2);

                Console.WriteLine(" O valor de " + numero + " ao quadrado é: " + quadrado);
            }
            Console.WriteLine("");

        }
    }
}
