using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_55
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 55
            int numero = 0, maior = 0, menor = 0;

            // Loop 1
            while (numero >= 0)
            {
                Console.Write("\n Inserir numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (maior < numero)
                {
                    maior = numero;
                }

                if (menor > numero)
                {
                    menor = numero;
                }
            }

            // Impressao
            Console.WriteLine("\n O Maior valor inserido foi: " + maior);

            Console.WriteLine("\n O Menor valor inserido foi: " + menor + "\n");
        }
    }
}
