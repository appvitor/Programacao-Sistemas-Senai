using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificarIdade
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int anoNascimento;
            Console.WriteLine("Digite seu ano de nascimento:");
            anoNascimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "O ano que você nasceu foi: " + anoNascimento);

            int idade = DateTime.Now.Year - anoNascimento;

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
