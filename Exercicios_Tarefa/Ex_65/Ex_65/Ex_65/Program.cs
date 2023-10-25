using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_65
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 65
            double aux, mm, polegada = 25.4;

            // Criação da tabela

            // Topo
            Console.WriteLine("\n\t - - - - - - - - - - - - - - - - - - - - - - - - \n\t :");

            // CORPO
            
            for (aux = 1; aux <= 20; aux++)
            {
                mm = aux * polegada;
                if (aux <= 9)
                {
                    Console.WriteLine("\t : \t0{0} polegadas - - - - > {1} mm", aux, mm);
                }
                else
                {
                    Console.WriteLine("\t : \t{0} polegadas - - - - > {1} mm", aux, mm);
                }
            }

            //Console.WriteLine("\t :");

            // Baixo
            Console.WriteLine("\t :\n\t - - - - - - - - - - - - - - - - - - - - - - - - \n\n");
        }
    }
}
