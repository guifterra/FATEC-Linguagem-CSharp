using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome_1, nome_2;

            Console.Write("\n Inserir nome 1: ");
            nome_1 = Console.ReadLine();

            Console.Write("\n Inserir nome 2: ");
            nome_2 = Console.ReadLine();

            Console.WriteLine("\n\n ---> ORDEM DIRETA:");
            Console.WriteLine("O primeiro nome escrito foi " + nome_1 + "!!");
            Console.WriteLine("O segundo nome escrito foi " + nome_2 + "!! \n");

            Console.WriteLine("\n\n ---> ORDEM REVERSA:");
            Console.WriteLine("O segundo nome escrito foi " + nome_2 + "!!");
            Console.WriteLine("O primeiro nome escrito foi " + nome_1 + "!! \n");
        }
    }
}
