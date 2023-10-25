using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_32
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 32
            double salario, salario_c_aumento;
            const double aumento = 1.25;

            // Leitura de salario
            Console.Write("\n Inserir valor do salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

            // Calculo
            salario_c_aumento = salario * aumento;

            // Impressoes
            Console.WriteLine("\n O salario do funcionário é : " + salario + " R$");

            Console.WriteLine(" O salario com aumento de 25% é: " + salario_c_aumento + " R$\n\n");
        }
    }
}
