using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Receba uma frase e a apresente trocando todas as vogais 
//‘A’ por ‘E’, ‘I’ por ‘O’ e ‘U’ por ‘A’.

namespace Programa36_27_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            Console.WriteLine(String.Format("\r\n" + frase.ToLower().Replace("a", "e") ("i", "o") ("u", "a")));
 
            Console.ReadKey();
        }
    }
}
