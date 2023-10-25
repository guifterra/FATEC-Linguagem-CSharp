using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1_Algoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Aula 1 de Algoritmo
                Autor: Guilherme
                Data: 17/08/2022
            */

            /*
            Impressão de Texto sem Quebra de Linha
            
            Console.Write("Olá Mundo");
            Console.Write("Olá Mundo");
            Console.Write("Olá Mundo");
            */

            /*
            Console.WriteLine("\n\tOlá Mundo\n");
            Console.WriteLine("\tOlá Mundo\n");
            Console.WriteLine("\tOlá Mundo\n");
            */

            /*
            Console.WriteLine("\n\n\t Primeira Aula de Algoritmo \n\t Professor: Dionisio \n\t Data: 17 / 08 / 2022 \n");

            Console.WriteLine("Primeira");
            Console.WriteLine("\tAula");
            Console.WriteLine("\t\tde");
            Console.WriteLine("\t\t\tAlgoritmo! \n\n");

            string nome = "Guilherme";
            Console.WriteLine(nome);

            nome = "Guilherme Fabiano Terra da Silva";
            Console.WriteLine("O nome digitado foi: " + nome + "!!\n");
            */

            string nome_user, nome_user2,sobrenome_user2;

            // Leitura aluno 1
            Console.Write("\n Inserir o nome de usuário: ");
            nome_user = Console.ReadLine();

            // Impressao 1
            Console.WriteLine("\n\n O nome do usuario é " + nome_user + "\n");

            // Leitura aluno 2
            Console.Write("\n Inserir o Nome do segundo aluno: ");
            nome_user2 = Console.ReadLine();

            Console.Write("\n\n Inserir o sobrenme do segundo aluno: ");
            sobrenome_user2 = Console.ReadLine();

            // Impressao 2
            Console.WriteLine("\n\n O nome do usuario 2 é " + nome_user2 + " " + sobrenome_user2 + "\n");
        }
    }
}
