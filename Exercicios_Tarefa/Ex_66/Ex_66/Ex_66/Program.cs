using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_66
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 66
            int limite, incremento, aux;

            // Leitura
            Console.Write("\n Inserir o limite do intervalo: ");
            limite = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Inserir o incremento do intervalo: ");
            incremento = Convert.ToInt32(Console.ReadLine());

            // Condica0
            if (limite > incremento)
            {
                if ((limite > 0) && (incremento > 0))
                {
                    Console.WriteLine("\n\n O intervalo de 0 a {0}: \n",limite);

                    for (aux = 0; aux <= limite; aux += incremento)
                    {
                        Console.Write(" " + aux);
                    }

                    Console.WriteLine("\n\n");
                    

                }
                else
                {
                    Console.WriteLine("\n\n Um dos valores é invalido! \n\n");
                }
            }
            else
            {
                Console.WriteLine("\n\n Não existe intervalo! \n\n");
            }
        }
    }
}
