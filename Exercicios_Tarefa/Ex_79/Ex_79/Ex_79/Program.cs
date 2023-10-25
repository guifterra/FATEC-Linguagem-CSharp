using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_79
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 79
            double aux;

            Console.WriteLine("");
            for (aux = 1; aux <= 500; aux++)
            {
                if((aux % 5) == 0)
                Console.WriteLine(aux);
            }
            Console.WriteLine("");
        }
    }
}
