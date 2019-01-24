using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dado um número  n  inteiro e positivo, dizemos que  n  é perfeito se  n  for igual à soma de 
//seus divisores positivos diferentes de  n. Construa um programa em C que verifica se um 
//dado número é perfeito. Ex: 6 é perfeito, pois 1+2+3 = 6.

namespace Programa27_21_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {

            int numDigi, soma;

            soma = 0;

            Console.WriteLine("Digite o número desejado: ");
            numDigi = int.Parse(Console.ReadLine());

            for (int i = 1; i < numDigi; i++)
            {

                if (numDigi % i == 0)
                {
                    soma += (i);
                }
               
            }
            
                if (soma == numDigi)
                {
                    Console.WriteLine("\r\nO número " + numDigi + " é perfeito! :D");
                }
            
                else
	            {
                    Console.WriteLine("\r\nO número " + numDigi + " não é perfeito :(");
	            }
 
            Console.ReadKey();

        }
    }
}
