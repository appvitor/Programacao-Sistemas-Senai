using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_13_13_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeUser;
            float numVezes;

            Console.WriteLine("\r\nQual é o seu nome?");
            nomeUser = Console.ReadLine();

            Console.WriteLine("\r\nQuantas vezes você quer que seu nome repita?");
            numVezes = float.Parse(Console.ReadLine());

            for (int i = 0; i < numVezes; i++)
            {
                Console.WriteLine("\r\nRepetindo seu nome: " + nomeUser);
            }

            Console.ReadKey();
        }
    }
}
