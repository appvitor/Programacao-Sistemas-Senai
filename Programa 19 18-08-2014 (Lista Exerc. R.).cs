using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Insira dois valores de hora e mostre o intervalo de horas, minutos e segundos no período inserido

namespace Programa19_18_08_2014__Lista_Exerc.R._
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora1, hora2;

            Console.WriteLine("Digite a hora inicial.\r\n");
            hora1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora final.\r\n");
            hora2 = int.Parse(Console.ReadLine());

            if (hora1 > 24 || hora2 > 24 || hora1 == hora2)
            {
                Console.WriteLine("Horário Inválido!");
            }

            else for (int i = hora1; i < hora2; i++)
                    {
                        for (int j = 0; j <= 59; j++)
                        {
                            for (int k = 0; k <= 59; k++)
                            {
                            Console.WriteLine("\r\n" + i + ":" + j + ":" + k);
                            }
                        }
                    } Console.ReadKey();
             
        }
       
    }

    
    
}
