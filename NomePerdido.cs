using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificacaoDeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataNasc;
            Console.WriteLine(Environment.NewLine + "Digite sua data de nascimento: ");
            dataNasc = DateTime.Parse(Console.ReadLine());

            TimeSpan ts = DateTime.Now.Date - dataNasc;

            int idade = ts.Days/365;

          

            if (idade >= 16 || idade == 17)
            {
                if (idade == 16 || idade == 17)
                {
                     Console.WriteLine(Environment.NewLine + "Você pode votar, mas seu voto é facultativo");
                    Console.WriteLine(Environment.NewLine + "Você não pode dirigir");
                }
                 else
               {
                    Console.WriteLine(Environment.NewLine + "Você já possui idade para votar e dirigir!");
                }
               }
               else 
              {
                 Console.WriteLine(Environment.NewLine + "Você não possui idade para votar nem dirigir!");

                }

               Console.ReadKey();             

        }
    }
}
