using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa34_27_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {

            string pessoa1, pessoa2, frase;

            pessoa1 = "João";
            pessoa2 = "Paulo";

            frase = "Aquele é {0}, e o outro é {1}";

            Console.WriteLine(frase, pessoa1, pessoa2);
            Console.WriteLine(frase, pessoa2, pessoa1);

            string frase2;

            frase2 = "O {0} ama o {1}";

            Console.WriteLine("\r\n" + frase2, pessoa1, pessoa2);

            string frase3;
            double nota, din;

            Console.WriteLine("\r\nDigite um valor: ");
            nota = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\nDigite outro valor: ");
            din = double.Parse(Console.ReadLine());

            frase3 = "O {0} tirou {1:n} na prova, e {2} ganhou {3:c}";

            Console.WriteLine("\r\n" + String.Format(frase3, pessoa1, nota, pessoa2, din));

            Console.WriteLine("\r\nDigite um valor: ");
            nota = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\nDigite outro valor: ");
            din = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\n" + String.Format(frase3, pessoa2, nota, pessoa1, din));

            Console.ReadKey();

        }
    }
}
