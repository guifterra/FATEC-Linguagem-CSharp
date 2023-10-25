using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado = 0,perimetro,area;

            Console.Write("\n Inserir lado do quadrado: ");
            lado = Convert.ToInt32(Console.ReadLine());

            perimetro = lado * 4;
            area = lado * lado;

            Console.WriteLine("\n\n ---> informacoes: \n");
            Console.WriteLine($" O lado do quadrado é {lado}");
            Console.WriteLine($" O perimeitro do quadrado é {perimetro}");
            Console.WriteLine($" A área do quadrado é {area} \n\n");


        }
    }
}
