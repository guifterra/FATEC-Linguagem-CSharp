using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 27
            double numero = 0, loop = 0, numero_el_4 = 0, numero_el_2, numero_el_3, numero_el_7, raiz_2, raiz_3, raiz_7;

            // Leitura
            while(loop == 0)
            {
                Console.Write("\n Inserir numero positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if(numero > 0)
                {
                    loop = 1;
                }
                else
                {
                    Console.WriteLine("\n O valor inserido n é positivo, por favor, troque-o! \n");
                }
            }

            // Calculo 1
            numero_el_4 = Math.Pow(numero, 4);

            // Condicao
            if(((numero_el_4%2) == 0) && ((numero_el_4%5) == 0))
            {
                // Calculo 2
                numero_el_2 = Math.Pow(numero, 2);
                numero_el_3 = Math.Pow(numero, 3);
                numero_el_7 = Math.Pow(numero, 7);

                // Impressoes
                Console.WriteLine("\n\n O numero digitado foi " + numero);
                Console.WriteLine(" Seu valor elevado ao quadrado é " + numero_el_2);
                Console.WriteLine(" Seu valor elevado ao cubo é " + numero_el_3);
                Console.WriteLine(" Seu valor elevado a sétima é " + numero_el_7);

            }
            else
            {
                // Calculo 3

                float um_terco = 1, um_set = 1, meio = 1;
               
                meio = meio / 2;
                um_terco = um_terco / 3;
                um_set = um_set / 7;

                raiz_2 = Math.Pow(numero, meio);
                raiz_3 = Math.Pow(numero, um_terco);
                raiz_7 = Math.Pow(numero, um_set);

                // Impressoes
                Console.WriteLine("\n\n O numero digitado foi " + numero);
                Console.WriteLine(" Sua raiz quadrada é " + Math.Round(raiz_2,2));
                Console.WriteLine(" Sua raiz cúbica é " + Math.Round(raiz_3, 2));
                Console.WriteLine(" Sua raiz sétima é " + Math.Round(raiz_7, 2));
            }
            
            Console.WriteLine("\n");

        }
    }
}
