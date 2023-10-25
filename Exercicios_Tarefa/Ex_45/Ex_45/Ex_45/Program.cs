using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_45
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 45
            double peso, altura, imc;

            // Leitura
            Console.Write("\n Inserir peso (Em Kg): ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Inserir altura (Em m): ");
            altura = Convert.ToDouble(Console.ReadLine());

            if((peso > 0) && (altura > 0))
            {
                // Calculo de IMC
                imc = peso / (Math.Pow(altura, 2));

                // Impressao
                Console.WriteLine(" \n\n O valor do imc é: " + Math.Round(imc,2));

                // Condica0
                if(imc < 17)
                {
                    Console.WriteLine(" Muito abaixo do peso! \n\n");
                }
                else
                {
                    if((imc >= 17) && (imc <= 18.49))
                    {
                        Console.WriteLine(" Abaixo do peso! \n\n");
                    }
                    else
                    {
                        if((imc >= 18.5) && (imc <= 24.99))
                        {
                            Console.WriteLine(" Peso normal \n\n");
                        }
                        else
                        {
                            if((imc >= 25) && (imc <= 29.99))
                            {
                                Console.WriteLine(" Acima do peso \n\n");
                            }
                            else
                            {
                                if ((imc >= 30) && (imc <= 34.99))
                                {
                                    Console.WriteLine(" Obesidade I \n\n");
                                }
                                else
                                {
                                    if ((imc >= 35) && (imc <= 39.99))
                                    {
                                        Console.WriteLine(" Obesidade II (severa) \n\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine(" Obesidade III (mórbida) \n\n");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\n Valores invalidos! \n\n");
            }


        }
    }
}
