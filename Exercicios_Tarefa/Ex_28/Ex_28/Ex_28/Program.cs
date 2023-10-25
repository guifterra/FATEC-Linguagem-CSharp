using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 28
            int numero1, numero2, numero3;

            // Leitura
            Console.Write("\n Inserir um numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("\n Inserir um numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("\n Inserir um numero: ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            // If de +, nulo ou - do numero 1
            if(numero1 == 0)
            {
                Console.WriteLine(" O valor {0} é nulo !", numero1);
            }
            else
            {
                if(numero1 > 0)
                {
                    Console.WriteLine(" O valor {0} é positivo !", numero1);
                }
                else
                {
                    Console.WriteLine(" O valor {0} é negativo !", numero1);
                }
            }

            // If de +, nulo ou - do numero 2
            if (numero2 == 0)
            {
                Console.WriteLine(" O valor {0} é nulo !", numero2);
            }
            else
            {
                if (numero2 > 0)
                {
                    Console.WriteLine(" O valor {0} é positivo !", numero2);
                }
                else
                {
                    Console.WriteLine(" O valor {0} é negativo !", numero2);
                }
            }

            // If de +, nulo ou - do numero 3
            if (numero3 == 0)
            {
                Console.WriteLine(" O valor {0} é nulo !", numero3);
            }
            else
            {
                if (numero3 > 0)
                {
                    Console.WriteLine(" O valor {0} é positivo !", numero3);
                }
                else
                {
                    Console.WriteLine(" O valor {0} é negativo !", numero3);
                }
            }

            // Impressao do maior
            if (numero1 > numero2)
            {
                if(numero1 > numero3)
                {
                    Console.WriteLine(" O maior num é " + numero1);
                }
                else
                {
                    Console.WriteLine(" O maior num é " + numero3);
                }
            }
            else
            {
                if(numero2 > numero3)
                {
                    Console.WriteLine(" O maior num é " + numero2);
                }
                else
                {
                    Console.WriteLine(" O maior num é " + numero3);
                }
            }

            Console.WriteLine("");


        }
    }
}
