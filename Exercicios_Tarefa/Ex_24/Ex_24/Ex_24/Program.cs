using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 24
            double salario, KW_gastos, valor_1KW, valor_pago,valor_pago_descontado;

            // Leituras
            Console.Write("\n Inserir o salario mínimo: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir a quantidade de KW gastos pela residencia: ");
            KW_gastos = Convert.ToDouble(Console.ReadLine());

            // Calculos
            valor_1KW = (salario / 7) / 100;
            valor_pago = valor_1KW * KW_gastos;
            valor_pago_descontado = valor_pago * 0.9;

            // Arredondamentos

            valor_1KW = Math.Round(valor_1KW,2);
            valor_pago = Math.Round(valor_pago, 2);
            valor_pago_descontado = Math.Round(valor_pago_descontado, 2);

            // Impressoes
            Console.WriteLine("\n\n O preço de 1 KW é " + valor_1KW + " R$");

            Console.WriteLine("\n O preço a ser pago pelo dono da casa é " + valor_pago + " R$");

            Console.WriteLine("\n O preço a ser pago com desconto de 10% é " + valor_pago_descontado + " R$ \n");



        }
    }
}
