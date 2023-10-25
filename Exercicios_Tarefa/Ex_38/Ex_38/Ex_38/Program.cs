using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_38
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 38
            double v_produto, v_produto_c_desconto;
            const double desconto = 0.91;

            // Leitura de valor
            Console.Write("\n Inserir valor do produto: ");
            v_produto = Convert.ToDouble(Console.ReadLine());

            // Condiaca0
            switch (v_produto > 0)
            {
                case true:

                    // Calculo
                    v_produto_c_desconto = v_produto * desconto;

                    // Impressoes
                    Console.WriteLine("\n\n O valor do produto é " + v_produto + " R$");
                    Console.WriteLine(" O valor do produto com desconto de 9% é " + v_produto_c_desconto + " R$ ! \n\n");

                    break;

                case false:

                    Console.WriteLine("\n\n O valor inserido é invalido, pois é menor ou igual do que 0 ! \n\n");

                    break;
            }
        }
    }
}
