using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_61
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 61
            int inicio = 300, fim = 30, aux;

            Console.WriteLine("");

            // Loop
            for (aux = inicio; aux >= fim; aux--)
            {
                if (((aux % 3) == 0) && ((aux % 5) == 0))
                {
                    Console.WriteLine("\t" + aux);
                }
            }
            Console.WriteLine("");
        }
    }
}
