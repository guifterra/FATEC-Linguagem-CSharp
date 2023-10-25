using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_71
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 71
            double altura, peso_ideal;
            char sexo = 'A';

            bool loop_sexo = true;

            // Leituras
            Console.Write("\n Inserir altura em m: ");
            altura = Convert.ToDouble(Console.ReadLine());

            while(loop_sexo == true)
            {
                Console.Write("\n Inserir sexo (M - masculino ou F - feminino): ");
                sexo = Convert.ToChar(Console.ReadLine());

                if ((sexo == 'M') || (sexo == 'm') || (sexo == 'F') || (sexo == 'f'))
                {
                    loop_sexo = false;
                }
                else
                {
                    Console.WriteLine(" Entrada não identificada, Por favor, inserir M ou F!");
                }
            }

            if ((sexo == 'M') || (sexo == 'm'))
            {
                peso_ideal = (72.7 * altura) - 58;
                Console.WriteLine("\n O peso ideal é " + peso_ideal + "\n");
            }
            else
            {
                peso_ideal = (62.1 * altura) - 44.7;
                Console.WriteLine("\n O peso ideal é " + peso_ideal + "\n");
            }
        }
    }
}
