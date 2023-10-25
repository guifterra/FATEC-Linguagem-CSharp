using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_72
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 72
            int aux;

            Console.WriteLine("\n");
            for (aux = 1; aux <= 100; aux++)
            {
                if((aux%2) == 0)
                {
                    Console.WriteLine("@@ - " + aux);
                }
                else
                {
                    Console.WriteLine("*  - " + aux);
                }
            }
            Console.WriteLine("\n");
        }
    }
}
