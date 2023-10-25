using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_76
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 76
            double aux;

            Console.WriteLine("");
            for (aux = 1; aux <= 10; aux++)
            {
                if((aux % 2) == 0)
                {
                    Console.Write(aux + " ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
