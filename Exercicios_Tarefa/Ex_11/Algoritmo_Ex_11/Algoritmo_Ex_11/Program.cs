using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ex 11
            double num, potencia_2, potencia_3, potencia_4, potencia_5;

            Console.Write("\n\t Inserir valor para realização de potencia: ");
            num = Convert.ToDouble(Console.ReadLine());

            potencia_2 = Math.Pow(num,2);
            potencia_3 = Math.Pow(num, 3);
            potencia_4 = Math.Pow(num, 4);
            potencia_5 = Math.Pow(num, 5);

            Console.WriteLine("\n\n\t O número digitado foi {0} E:\n\t Seu valor elevado a 2 é {1},\n\t Elevado a 3 é {2},\n\t Elevado a 4 é {3},\n\t Elevado a 5 é {4} \n\n",num, potencia_2, potencia_3,potencia_4,potencia_5);




        }
    }
}
