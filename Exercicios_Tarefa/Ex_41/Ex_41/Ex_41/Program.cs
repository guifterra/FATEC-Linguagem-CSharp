using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_41
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 41
            double salario, salario_c_aumento;
            const double aumento = 1.25;

            // Leitura de salario
            Console.Write("\n Inserir vlaor do salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

            // Calculo
            salario_c_aumento = salario * aumento;

            // Impressao
            Console.WriteLine("\n\n O salario do funcionário é {0} R$ !", salario);
            Console.WriteLine(" O salario com aumento é {0} R$ ! \n\n", salario_c_aumento);
        }
    }
}
