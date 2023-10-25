using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_86
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 86
            double limite, aux, controle = 1;

            Console.Write("\n Inserir valor: ");
            limite = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            for(aux = 2; controle <= limite; controle++)
            {
                Console.WriteLine("\t" + aux);
                aux += 2;
            }
            Console.WriteLine("");
        }
    }
}
