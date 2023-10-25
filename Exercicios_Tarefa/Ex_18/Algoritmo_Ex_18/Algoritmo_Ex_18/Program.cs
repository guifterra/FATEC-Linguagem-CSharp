using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Ex_18
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ex 18
            double raio_M, raio_m, area_M, area_m, area_coroa, auxiliar=0;
            const double pi = Math.PI;

            // Leitura de valores
            Console.Write("\n\t Inserir valor do Raio Maior: ");
            raio_M = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\t Inserir valor do Raio Menor: ");
            raio_m = Convert.ToDouble(Console.ReadLine());

            // Calculos
            area_M = pi * (double)(Math.Pow(raio_M, 2));
            area_m = pi * (double)(Math.Pow(raio_m, 2));

            // Verificacao
            if (area_M >= area_m)
            {
                // Faz nada
            }
            else
            {
                // Ajuste
                auxiliar = area_M;
                area_M = area_m;
                area_m = auxiliar;

                Console.WriteLine("\n\t O valor de Raio maior foi invertido com o de Raio menor, ajustamos isso para vc !!");
            }

            area_coroa = area_M - area_m;

            Console.WriteLine("\n\n\t Area da coroa circular é: " + area_coroa + "!! \n");
        }
    }
}
