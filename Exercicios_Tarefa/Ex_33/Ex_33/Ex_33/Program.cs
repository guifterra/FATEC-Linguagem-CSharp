using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_33
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 33
            double h_degrau, h_desejado, n_de_degraus = 0;

            // Leitura
            Console.Write("\n Inserir altura do degrau: ");
            h_degrau = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir altura desejada da escada: ");
            h_desejado = Convert.ToDouble(Console.ReadLine());

            // Calculo
            n_de_degraus = h_desejado / h_degrau;

            // Impressao
            Console.WriteLine("\n\n O numero de degraus de {0} uc necessarios para atingir a altura de {1} são {2} degraus!", h_degrau, h_desejado, n_de_degraus);

            Console.WriteLine("\n uc = unidade de comprimento \n\n");
        }
    }
}
