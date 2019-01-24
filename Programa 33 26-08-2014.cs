using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um programa que leia vários conjuntos de três valores reais e mostre para cada
//conjunto: sua soma, seu produto e sua média. O programa para quando um conjunto não
//entrar com seus valores em ordem crescente.
//Um dos 3 números deve estar entre 100 e 200


namespace Programa33_26_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3, soma, prod, media;

            do
            {

                Console.WriteLine("\r\nDigite o 1º valor: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\r\nDigite o 2º valor: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\r\nDigite o 3º valor: ");
                num3 = int.Parse(Console.ReadLine());

                if (num1 < 0 || num2 < 0 || num3 < 0)
                {
                    Console.WriteLine("\r\nValores negativos são inválidos!");
                }

                else if (num1 > 200 && num2 > 200 && num3 > 200)
                {
                    Console.WriteLine("\r\nUm dos números deve ser menor que 200!");
                }

                else if (num1 < 100 && num2 < 100 && num3 < 100);
                {
                    Console.WriteLine("\r\nUm dos números deve ser maior ou igual que 100!");
                }
                
                else
	            {
                    soma = num1 + num2 + num3;
                    prod = num1 * num2 * num3;
                    media = (num1 + num2 + num3) / 3;
	            }
                 

                    Console.WriteLine("\r\no valor da Soma é: " + soma);
                    Console.WriteLine("o valor do Produto é: " + prod);
                    Console.WriteLine("o valor da Média: " + media);
                

            } while (num3 > num2 && num2 > num1);


            Console.ReadKey();
        }
    }
}
