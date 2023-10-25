using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 23
            int numero;
            double quadrado, cubo;

            // Leitura de valor
            Console.Write("\n Inserir numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Teste
            if ((numero%2) == 0){

                Console.WriteLine("\n O numero {0} é par!",numero);

                quadrado = Math.Pow(numero, 2);
                Console.WriteLine("\n Seu valor ao quadrado é " + quadrado + "\n");

            }
            else
            {
                Console.WriteLine("\n O numero {0} é impar!",numero);

                cubo = Math.Pow(numero, 3);
                Console.WriteLine("\n Seu valor ao cubo é " + cubo + "\n");
            }
        }
    }
}
