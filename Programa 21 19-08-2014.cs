using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um programa em C que calcule e escreva a seguinte soma:
// aumente 3 e diminua dois;

namespace Programa21_19_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
               
		    for (int i = 1, k = 1; k < 100; i++)
			{
			    Console.WriteLine(k);
                
                if (i % 2 == 0)
                {
                    k -= 2;
                }
                
                else
            	{
                    k += 3;
            	}

            } Console.ReadKey();
            
        }
    }
}
