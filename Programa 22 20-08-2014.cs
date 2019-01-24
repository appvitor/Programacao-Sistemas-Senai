using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa22_20_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
                           
            for (int i = 1, k = 1, j = 2, l = 50; k < 100 && l > 0; i++, j++)
            {
                Console.WriteLine(k);
                Console.WriteLine(l);

                  l -= j;    

                if (i % 2 == 0)
                {
                    k -= 2;
                }
                
                else
                {
                    k += 3;
                }
            }
            Console.ReadKey();
        }
    }
}


            //for (int i = 1, k = 1; k < 100; i++)
            //{
            //    Console.WriteLine(k);
            //    if (i % 2 == 0) // se i for par
            //    {
            //         k -= 1;
            //    }
            //    else // se i for impar
            //    {
            //        k += 2;
            //    }
            //}
            //Console.ReadKey();