using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_64
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 64
            double aux;

            Console.WriteLine("");
            // Loop
            for (aux = 1000; aux >= 150; aux--)
            {
                if(aux%2 != 0)
                {
                    Console.WriteLine("\t" + aux);
                }
            }
            Console.WriteLine("");
        }
    }
}
