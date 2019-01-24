using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Digitar 15 números e mostrar o maior e o menor
namespace Programa_15_14_08_2014__Lista_Prova1_
{
    class Program
    {
        static void Main(string[] args)
        {

            double vlAux, vlMaior = 0, vlMenor = 0;

            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine("Digite um valor para o número " + i);
                vlAux = double.Parse(Console.ReadLine());

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

            Console.WriteLine("O Maior valor digitado foi: " + vlMaior);
            Console.WriteLine("O Menor valor digitado foi: " + vlMenor);

            Console.ReadKey();     
        }
    }
}
