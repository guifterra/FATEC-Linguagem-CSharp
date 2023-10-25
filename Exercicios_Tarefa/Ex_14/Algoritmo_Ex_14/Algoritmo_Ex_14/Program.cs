using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Ex_14
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ex 14
            double pi, raio, area, perimetro;

            // Leitura do valor do raio
            Console.Write("\n\t Inserir valor do raio da circunferencia: ");
            raio = Convert.ToDouble(Console.ReadLine());

            // Atribuição de PI e calculos
            pi = Math.PI;

            area = (double)pi * (Math.Pow((double)raio, 2));
            perimetro = 2 * pi * raio;

            // Impressoes
            Console.WriteLine("\n\n\t O valor do raio da circunferencia é "+ raio);
            Console.WriteLine("\t O valor do PI é " + pi);
            Console.WriteLine("\t O valor da área é " + area);
            Console.WriteLine("\t O valor do perimetro é " + perimetro);

            // Distanciamento
            Console.WriteLine("\n\n");
        }
    }
}
