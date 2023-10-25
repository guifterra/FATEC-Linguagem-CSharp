using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_67
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 67
            int numero1, numero2;
            bool loop1 = true;


            // Loop 1
            do
            {

                Console.Write("\n Inserir valor 1: ");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n Inserir valor 2: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                if(((0 < numero1) && (numero1 <= 100)) && ((0 < numero2) && (numero2 <= 100)))
                {
                    if (numero1 < numero2)
                    {
                        Console.WriteLine("\n O menor número é " + numero1 + " ! \n");
                    }
                    else
                    {
                        if(numero1 == numero2)
                        {
                            Console.WriteLine("\n Os números são iguais ! \n");
                        }
                        else
                        {
                            Console.WriteLine("\n O menor número é " + numero2 + " ! \n");
                        }
                        
                    }
                    loop1 = false;
                }
                else
                {
                    Console.WriteLine("\n\n Um dos valores inseridos é invalido! \n\n");
                    loop1 = false;
                }

            } while (loop1 == true);

        }
    }
}
