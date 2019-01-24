using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tabuada 0 a 9
namespace Programa_16_14_08_2014__Lista_Prova1_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine("\r\n " + i + " * " + j + " = " + (i * j));
                }
            }

            Console.ReadKey();
        }
    }
}
