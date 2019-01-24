using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escreva um programa  em C que gera números entre 1000 e 1999 e mostra aqueles que 
//divididos por 11 dão resto 5.

namespace Programa24_20_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1001; i > 1000 && i < 2000; i++)
            {
                if (i % 11 == 5)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
