using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Repetição de nome
namespace Programa_12_13_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomePessoa;
            int qtRepeticao;

            Console.WriteLine("Digite seu nome: ");
            nomePessoa = Console.ReadLine().Trim();

            Console.WriteLine("Digite a quantidade de vezes que seu nome seja apresentado: ");
            qtRepeticao = int.Parse(Console.ReadLine().Trim());

            //int i = 0;

            //Console.WriteLine("");
            //while (i < qtRepeticao)
            //{
            //    Console.WriteLine("Repetição de nome: " + nomePessoa);
            //    i++;
            //}

            for (int i = 0; i < qtRepeticao; i++)
            {
                Console.WriteLine("Repetição de nome: " + nomePessoa);
            }


            Console.ReadKey();
        }
    }
}
