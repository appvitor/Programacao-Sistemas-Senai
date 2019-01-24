using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa para a Cotação do Dólar
namespace Programa_5_12_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            float vlCotacao, vlDolar;

            Console.WriteLine("Digite a cotação do Dólar: ");
            vlCotacao = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor em Dólar: ");
            vlDolar = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor em Reais = " + (vlCotacao * vlDolar));
            Console.ReadKey();
        }
    }
}
