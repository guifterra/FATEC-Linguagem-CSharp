using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_47
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 47

            // Codigos
            const double c1 = 100,
                         c2 = 101,
                         c3 = 102,
                         c4 = 103,
                         c5 = 104;

            // Precos
            const double p1 = 4.5,
                         p2 = 4.5,
                         p3 = 5.5,
                         p4 = 6.5,
                         p5 = 3.5;

            // Leitura
            double pedido, quantidade;

            Console.Write("\n Inserir codigo do pedido: ");
            pedido = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir quantidade: ");
            quantidade = Convert.ToDouble(Console.ReadLine());

            // Calculo + Condica0
            if ((pedido >= c1) && (pedido <= c4))
            {
                switch (pedido)
                {
                    case c1:

                        Console.WriteLine("\n\n Valor a ser pago: " + (p1 * quantidade) + " R$ \n\n");

                        break;

                    case c2:

                        Console.WriteLine("\n\n Valor a ser pago: " + (p2 * quantidade) + " R$ \n\n");

                        break;

                    case c3:

                        Console.WriteLine("\n\n Valor a ser pago: " + (p3 * quantidade) + " R$ \n\n");

                        break;


                    case c4:

                        Console.WriteLine("\n\n Valor a ser pago: " + (p4 * quantidade) + " R$ \n\n");

                        break;

                    case c5:

                        Console.WriteLine("\n\n Valor a ser pago: " + (p5 * quantidade) + " R$ \n\n");

                        break;
                }
            }
            else
            {
                Console.WriteLine("\n\n Pedido nao identificado! \n\n");
            }


        }
    }
}
