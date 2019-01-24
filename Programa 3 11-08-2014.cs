using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_3_11_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1,valor2,valor3;

            Console.WriteLine("Digite o primeiro Número");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Digite o segundo Número");
            valor2 = int.Parse(Console.ReadLine());
            valor3 = (valor1 + valor2) * valor1;
            Console.WriteLine(Environment.NewLine + "Resultado " + valor3);
            Console.ReadKey();
        }
    }
}
