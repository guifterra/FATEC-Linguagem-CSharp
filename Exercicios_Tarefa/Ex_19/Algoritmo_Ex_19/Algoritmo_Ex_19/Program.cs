using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Ex_19
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ex 19
            double raio_base, altura_prisma, Volume, area_base;
            const double pi = Math.PI;

            // Leitura de Valores
            Console.Write("\n\t Inserir valor do raio da circunferencia da base: ");
            raio_base = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\t Inserir valor da altura do prisma: ");
            altura_prisma = Convert.ToDouble(Console.ReadLine());

            // Calculo
            area_base = pi * (Math.Pow(raio_base,2));
            Volume = area_base * altura_prisma;

            // Impressao
            Console.WriteLine("\n\t O valor do volume do prisma é: " + Volume +"\n");

        }
    }
}
