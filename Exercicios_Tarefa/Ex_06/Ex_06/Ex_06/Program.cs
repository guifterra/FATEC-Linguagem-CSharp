using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0.0, num2 = 0.0;
            double div, media;

            Console.Write("\n Inserir numero 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir numero 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n ---> Informacoes: \n");

            Console.WriteLine($" Os numeros inseridos foram {num1} e {num2}\n");

            Console.WriteLine($" {num1} + {num2} = {num1+num2}");
            Console.WriteLine($" {num1} - {num2} = {num1-num2}");
            Console.WriteLine($" {num1} * {num2} = {num1*num2}");
            div = num1 / num2;
            Console.WriteLine($" {num1} / {num2} = {div}");
            media = (num1 + num2) / 2;
            Console.WriteLine($"\n A media de {num1} e {num2} é {media} \n");


        }
    }
}
