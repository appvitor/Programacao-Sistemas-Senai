using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Múltiplo de 10
namespace Programa_14_13_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine( i );
                if (i % 10 == 0)
                {
                    Console.WriteLine(" = Múltiplo de 10!");
                }
            }

            Console.ReadKey();
        }
    }
}
