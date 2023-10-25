using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3_Algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Data: 24/08/2022 */
            double peso;
            int idade;
            string nome;
            
            // Leitura de Nome
            Console.Write("\n Digite seu Nome: ");
            nome = Console.ReadLine();

            // Leitura de Idade
            Console.Write("\n Digite sua Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            // idade = int.Parse(Console.ReadLine());

            // Leitura de Peso
            Console.Write("\n Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            // peso = double.Parse(Console.ReadLine());

            // Título
            Console.Write("\n\n - - - Dados - - - \n");

            // Impressoes
            Console.WriteLine("\n O Nome digitado foi: " + nome);
            Console.WriteLine(" A Idade digitado foi: " + idade + " anos");
            Console.WriteLine(" O peso digitado foi: " + peso + " Kg");
            Console.Write("\n");


        }
    }
}
