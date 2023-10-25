using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado_1 = 0, lado_2 = 0, perimetro, area;

            Console.Write("\n Inserir lado do retangulo: ");
            lado_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Inserir base do retangulo: ");
            lado_2 = Convert.ToInt32(Console.ReadLine());

            perimetro = lado_1 * 2 + lado_2 * 2;
            area = lado_1 * lado_2;

            Console.WriteLine("\n\n ---> informacoes: \n");
            Console.WriteLine($" O lado do retangulo é {lado_1} e sua base é {lado_2}");
            Console.WriteLine($" O perimeitro do retangulo é {perimetro}");
            Console.WriteLine($" A área do retangulo é {area} \n\n");


        }
    }
}
