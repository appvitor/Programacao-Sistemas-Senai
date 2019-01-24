using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_6_12_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, valor4, valor5;

            Console.WriteLine("Digite o primeiro Número: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Digite o segundo Número: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Digite o terceiro Número: ");
            valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Digite o quarto Número: ");
            valor4 = int.Parse(Console.ReadLine());

            valor5 = valor1 * valor1 + valor2 * valor2 + valor3 * valor3 + valor4 * valor4;

            Console.WriteLine(Environment.NewLine + "Resultado: " + valor5);

            Console.ReadKey();
        }
    }
}
