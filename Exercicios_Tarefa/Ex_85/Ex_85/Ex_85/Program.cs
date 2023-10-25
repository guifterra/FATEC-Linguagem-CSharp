using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_85
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 85
            double limite, aux;

            Console.Write("\n Inserir limite superior: ");
            limite = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            for (aux = limite-1; aux >= 1; aux--)
            {
                if ((aux % 2) != 0)
                    Console.WriteLine("\t" + aux);
            }
            Console.WriteLine("");
        }
    }
}
