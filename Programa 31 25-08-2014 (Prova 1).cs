using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Leia 5 números, informe o menor, o maior e quais são ímpares

namespace Programa31_25_08_2014_Prova1_
{
    class Program
    {
        static void Main(string[] args)
        {

            double vlAux, vlMaior = 0, vlMenor = 0, vlImpar;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("\r\nDigite um valor para o número " + i);
                vlAux = double.Parse(Console.ReadLine());

                vlImpar = (vlAux % 2 == 1);

                if (i == 0)
                {
                    vlMenor = vlAux;
                    vlMaior = vlAux;
                }

                else if (vlAux > vlMaior)
                {
                    vlMaior = vlAux;
                }

                else if (vlAux < vlMenor)
                {
                    vlMenor = vlAux;
                }

            }

            Console.WriteLine("\r\nO Maior valor digitado foi: " + vlMaior);
            Console.WriteLine("\r\nO Menor valor digitado foi: " + vlMenor);
            Console.WriteLine("\r\nOs números ímpares foram: " + vlImpar);

            Console.ReadKey();

        }
    }
}
