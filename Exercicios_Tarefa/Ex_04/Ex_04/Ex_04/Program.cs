using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
           
            Console.Write("\n Inserir valor 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Inserir valor 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n ---> Informações inseridas: ");
            Console.WriteLine($"\n O primeiro valor inserido foi {num1} e o segundo valor inserido foi {num2} !!");
            
            Console.WriteLine($"\n O sucessor de {num1} é {num1+1}");
            Console.WriteLine($"\n O antecessor de {num2} é {num2-1} \n");

        }
    }
}
