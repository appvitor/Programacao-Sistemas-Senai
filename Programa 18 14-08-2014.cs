using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa18_14_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;

            Console.WriteLine("Digite um valor: ");
            valor = double.Parse(Console.ReadLine());

            for (int i = 1; i <= 200; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("\r\n");
                }
                Console.Write(i + " = " + i * valor + " | ");
            }

            Console.ReadKey();
        }
    }
}
