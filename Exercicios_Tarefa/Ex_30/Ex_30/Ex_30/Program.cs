using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_30
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 30
            double celcius, fahr;

            // Leitura da temperatura em C
            Console.Write("\n Inserir temperatura em °C: ");
            celcius = Convert.ToDouble(Console.ReadLine());

            // Conversão para Fh
            double nove_quintos = 9;
            nove_quintos /= 5;

            fahr = ((nove_quintos * celcius) + 32);

            // Impressao
            Console.WriteLine("\n Temp em °C: " + celcius);
            Console.WriteLine(" Temp em °F: " + fahr + "\n");

        }
    }
}
