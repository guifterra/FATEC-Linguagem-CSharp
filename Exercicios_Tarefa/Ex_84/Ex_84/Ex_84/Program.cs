using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_84
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 84
            double polegada, cm, aux;

            Console.WriteLine("");
            for(aux = 1; aux <= 20; aux++)
            {
                polegada = aux * 25.4;
                if(aux <= 9)
                {
                    Console.WriteLine("\t0" + aux + " cm ---> " + polegada + " polegadas");
                }
                else
                {
                    Console.WriteLine("\t" + aux + " cm ---> " + polegada + " polegadas");
                }
            }
            Console.WriteLine("");
        }
    }
}
