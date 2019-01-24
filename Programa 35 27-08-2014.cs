using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Receba uma frase toda em minúsculo, 
//apresente apenas as 10 primeiras letras e em maiúsculo.

namespace Programa35_27_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase;

            Console.WriteLine("Escreva alguma frase");
            frase = Console.ReadLine();

            Console.WriteLine(String.Format("\r\n" + frase.ToLower().Substring(0, 10)));

            Console.ReadKey();

        }
    }
}
