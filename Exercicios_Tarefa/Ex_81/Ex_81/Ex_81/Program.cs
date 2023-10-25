using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_81
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 81
            double aux;

            for(aux = 1; aux <= 600; aux++)
            {
                if ((aux % 2 ) == 0)
                 Console.WriteLine("\n " + aux);
            }
            Console.WriteLine("");
        }
    }
}
