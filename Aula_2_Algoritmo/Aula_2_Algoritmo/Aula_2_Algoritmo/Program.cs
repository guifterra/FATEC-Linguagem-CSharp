using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_Algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, resto;
            int soma, sub, mult;
            double div;

            Console.Write("\n");

            Console.Write("\t Inserir numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\t Inserir numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            // Título
            Console.WriteLine("\n\t - - - Cálculos - - - ");

            // Soma 
            soma = num1 + num2;
            Console.WriteLine("\n\t {0} + {1} = {2}", num1, num2, soma);

            // Sub
            sub = num1 - num2;
            Console.WriteLine("\n\t {0} - {1} = {2}", num1, num2, sub);

            // Mult
            mult = num1 * num2;
            Console.WriteLine("\n\t {0} x {1} = {2}", num1, num2, mult);

            // Div
            div = (double)num1 / num2;
            Console.WriteLine("\n\t {0} / {1} = {2}", num1, num2, div);

            // Resto
            resto = num1 % num2;
            Console.WriteLine("\n\t {0} % {1} = {2} \n", num1, num2, resto);

        }
    }
}
