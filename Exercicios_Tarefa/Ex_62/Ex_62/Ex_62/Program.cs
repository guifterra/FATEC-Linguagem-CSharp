using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_62
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 62
            int numero1, numero2, aux = 0;

            Console.Write("\n Inserir Numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Inserir Numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            // Ajuste
            if (numero1 > numero2)
            {
                aux = numero1;
                numero1 = numero2;
                numero2 = aux;
            }

            int inicio = numero1, fim = numero2;

            // Loop de impressao
            Console.WriteLine("");
            for (aux = inicio; aux <= fim; aux++){

                if (((aux%2) == 0) && ((aux%7) == 0))
                {
                    Console.WriteLine("\t" + aux);
                }

            }
            Console.WriteLine("");
        }
    }
}
