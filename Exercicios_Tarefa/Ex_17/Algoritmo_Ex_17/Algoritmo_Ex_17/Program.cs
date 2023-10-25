using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Ex_17
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ex 17
            double lado_triangulo, altura_prisma, raiz_de_3, Volume, area_Base;

            // Leitura de Valores
            Console.Write("\n\t Inserir valor do lado do triangulo da base: ");
            lado_triangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\t Inserir valor da altura do prisma: ");
            altura_prisma = Convert.ToDouble(Console.ReadLine());

            // Atrbuição do raiz de 3
            raiz_de_3 = Math.Pow((double)3, 0.5);

            // Calculos
            area_Base = ((Math.Pow(lado_triangulo, 2)) * raiz_de_3) / (double)4;
            Volume = area_Base * altura_prisma;

            // Impressao
            Console.WriteLine("\n\n\n\t O valor da area da base é: {0}", Math.Round(area_Base,4));
            Console.WriteLine("\n\t O valor do Volume do prisma é: " + Volume + "\n\n");

        }
    }
}
