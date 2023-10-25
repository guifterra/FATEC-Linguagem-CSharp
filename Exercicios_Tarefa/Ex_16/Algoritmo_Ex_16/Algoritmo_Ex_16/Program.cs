using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Ex_16
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ex 16
            double B_Maior, b_menor, altura, area;

            // Leitura de informacoes
            Console.Write("\n Inserir valor da Base maior: ");
            B_Maior = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir valor da Base menor: ");
            b_menor = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir valor da Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            // Calculo de area
            area = ((B_Maior + b_menor) * altura) / (double)2;

            // Impressoes
            Console.WriteLine("\n O valor da área do trapézio qualquer é: " + area +"\n");


        }
    }
}
