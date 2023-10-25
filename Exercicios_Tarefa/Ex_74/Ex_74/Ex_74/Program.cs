using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_74
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 74
            int numero, aux = 1;

            // Loop
            Console.WriteLine("\n");
            while(aux <= 10)
            {

                Console.Write("\n Inserir numero " + aux + ": ");
                numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" A metade do numero lido é : " + ((double)numero / 2) + "\n");

                aux++;
            }
            Console.WriteLine("\n");
        }
    }
}
