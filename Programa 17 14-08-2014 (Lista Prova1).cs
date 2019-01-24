using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Leia o número e apresente os números primos anteriores correspondentes do número digitado
// Execício 16 da lista num. 1
namespace Programa17_14_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            double numUser;

            Console.WriteLine("Digite o número desejado");
            numUser = double.Parse(Console.ReadLine());

            for (int i = 0; i < numUser; i++)
            {

                    if (numUser / i == > 0) &&
                        Console.Write( i + "= Número Primo ");
                
            }

            Console.ReadKey();
        }
    }
}
