using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("\n Inserir valor: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n ---> Informacoes: \n");
            Console.WriteLine($" O valor inserido foi {num}, seu antecessor é {num - 1} e seu sucessor é {num + 1} \n\n");

        }
    }
}
