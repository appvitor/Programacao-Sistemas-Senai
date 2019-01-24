using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um programa em C que calcula o produto dos números digitados pelo usuário. O 
//programa em C deve permitir que o usuário digite uma quantidade não determinada de 
//números. O programa em C encerra quando o usuário digita o valor zero .

namespace Programa23_20_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            float num, result = 1;

            do
            {

                Console.WriteLine("Digite algum número");
                num = float.Parse(Console.ReadLine());

                if (num != 0)
                {
                    result *= num;
                
                }

            } while (num != 0);


                Console.WriteLine("Resultado: " + result);
                Console.ReadLine();
            
        }
    }
}
