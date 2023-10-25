using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_87
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 87
            double limite, produto = 1, aux;

            Console.Write("\n Inserir limite: ");
            limite = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            for(aux = 1; aux <= limite; aux++)
            {
                Console.WriteLine("\t" + aux);
                produto *= aux;
            }
            Console.WriteLine("");
            Console.WriteLine("\tO produto dos numeros é: " + produto);
            Console.WriteLine("");
        }
    }
}
