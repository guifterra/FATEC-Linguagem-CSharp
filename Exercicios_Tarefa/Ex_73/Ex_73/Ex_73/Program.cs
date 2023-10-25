using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_73
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 73
            int aux;

            Console.WriteLine("\n");
            for (aux = 1; aux <= 100; aux++)
            {
                if ((aux%4) == 0)
                {
                    Console.WriteLine("\tPI");
                }
                else
                {
                    Console.WriteLine("\t" + aux);
                }
            }
            Console.WriteLine("\n");
        }
    }
}
