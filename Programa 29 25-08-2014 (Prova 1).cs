using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Leia 3 números inteiros e calcule e apresenta a média, a soma e o produto destes.

namespace Programa29_25_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, media, soma, prod;

            Console.WriteLine("Digite o 1º número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\nDigite o 2º número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\nDigite o 3º número: ");
            num3 = double.Parse(Console.ReadLine());

            media = (num1 + num2 + num3) / 3;
            soma = num1 + num2 + num3;
            prod = num1 * num2 * num3;

            Console.WriteLine("\r\nO valor da Média é: " + media);

            Console.WriteLine("\r\nO valor da Soma é: " + soma);

            Console.WriteLine("\r\nO valor do Produto é: " + prod);

            Console.ReadKey();
        }
    }
}
