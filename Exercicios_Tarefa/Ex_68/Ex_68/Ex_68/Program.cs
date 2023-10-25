using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_68
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 68
            int nivel_alerta = 0, loop_escolha = 0;

            // Leitura
            while(loop_escolha == 0)
            {
                Console.Write("\n Inserir o numero do nivel de alerta: ");
                nivel_alerta = Convert.ToInt32(Console.ReadLine());

                if ((nivel_alerta >= 0) && (nivel_alerta <= 10))
                {
                    loop_escolha = 1;
                }
                else
                {
                    Console.WriteLine(" O valor inserido deve estar entre 0 e 10!");
                }
            }

            // Impressao
            if (nivel_alerta >= 9)
            {
                Console.WriteLine(" O nível é considerado GRAVE! \n");
            }
            else
            {
                Console.WriteLine(" O nível não é considerado GRAVE! \n");
            }
        
        }
    }
}
