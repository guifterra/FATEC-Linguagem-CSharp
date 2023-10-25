using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_46
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 46

            // Precos dos tipos de P
            const double preco_p1 = 1.50, 
                         preco_p2 = 2.60,
                         preco_p3 = 3.75;

            // Quantidade de P
            double q_p1 = 0, 
                   q_p2 = 0,
                   q_p3 = 0;

            // Leitura
            Console.Write("\n Inserir quantidade de Picoles 1: ");
            q_p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir quantidade de Picoles 2: ");
            q_p2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir quantidade de Picoles 3: ");
            q_p3 = Convert.ToDouble(Console.ReadLine());

            // Condicao de existencia
            if ((q_p1 >= 0) && (q_p2 >= 0) && (q_p3 >= 0))
            {
                double total, q_vendida;

                // Calculos
                total = q_p1 * preco_p1 + q_p2 * preco_p2 + preco_p3 * q_p3;

                q_vendida = q_p1 + q_p2 + q_p3;

                // Impressao
                Console.WriteLine("\n\n A quantidade total de picoles vendidos foi {0}, sendo:", q_vendida);

                Console.WriteLine("\n {0} do tipo 1 !",q_p1);
                Console.WriteLine(" {0} do tipo 2 !", q_p2);
                Console.WriteLine(" {0} do tipo 3 !", q_p3);

                Console.WriteLine("\n O preço total a ser pago é: {0} R$\n\n", total);
            }
            else
            {
                Console.WriteLine("\n\n Algum dos valores é invalido! \n\n");
            }
        }
    }
}
