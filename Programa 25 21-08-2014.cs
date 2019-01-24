using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um programa em C para gerar os n primeiros termos da seqüência:
//1 1 2 3 5 8 13 21 34 55 89 …

namespace Programa25_21_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numDesej, numTro;

            Console.WriteLine("Digite a quantidade de números que você deseja da Sequência de Fibonacchi: ");
            numDesej = int.Parse(Console.ReadLine());

            for (int cont = 0, i = 0, j = 1; cont < numDesej; cont++)
            {

                if (cont == 1)
                {
                    Console.WriteLine("Sequência: " + i);
                }

                numTro = i + j;
                i = j;
                j = numTro;


                Console.WriteLine("Sequência: " + numTro);

            }

            Console.ReadKey();
        }
        
    }
}
