using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calcular Hipotenusa;

namespace Programa_8_12_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            float cateto1, cateto2;

                Console.WriteLine("Digite o valor do 1º Cateto: ");
                cateto1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor do 2º Cateto: ");
                cateto2 = float.Parse(Console.ReadLine());

            float valor1, hipotenusa;

                valor1 = cateto1 * cateto1 + cateto2 * cateto2;
                hipotenusa = valor1 * valor1;

                Console.WriteLine("Resultado: " + hipotenusa);
                Console.ReadKey();

        }
    }
}
