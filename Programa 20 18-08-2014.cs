using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Leia um intervalo de números reais; Exiba todos os intervalos múltiplos pelo último número do intervalo; A cada múltiplo do primeiro número do intervalo
//dividido por 2, pule uma linha.

namespace Programa20_18_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, numMul;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            numMul = num2 - 1;

            for (int i = num1 + 1; i < num2; i++)
			{

                if (i % ((num1 + 1) / 2) == 0)
                {

                    Console.WriteLine("\r\n" + i + "*" + numMul + " = " + (i * numMul));
                }
                else
                {
                    Console.WriteLine(i + "*" + numMul + " = " + (i * numMul));
                }
			}

            Console.ReadKey();
        }
    }
}
