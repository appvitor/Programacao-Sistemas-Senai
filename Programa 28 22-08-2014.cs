using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Um determinado material radioativo perde metade de sua massa a cada 50 segundos. Dada 
//a massa inicial, em gramas, fazer um programa em C que calcule o tempo necessário para 
//que essa massa se torne menor que 0,5 grama. O programa em C deve escrever a massa 
//inicial, a massa final e o tempo calculado em horas, minutos e segundos.

namespace Programa28_22_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Massa Radiotiva";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            string reDo;

                do
                {
                    double massaIni, massaFinal, h, m, s;
                    int aux = 0;
               

                    Console.WriteLine("Digite a quatidade de massa do material radioativo: ");
                    massaIni = double.Parse(Console.ReadLine());
                
                    massaFinal = massaIni;

                    for (; massaFinal >= 0.5; )
                    {
                        aux += 50;
                        massaFinal /= 2;
                    }

                    h = aux / 3600;
                    m = (aux % 3600) / 60;
                    s = (aux % 3600 % 60);

                    Console.WriteLine("\r\nO tempo necessário será de: " + h + " : " + m + " : " + s);
                    Console.WriteLine("\r\nA massa inicial era de: " + massaIni + ", e a massa final será de: " + massaFinal);
                    
                    Console.WriteLine("\r\nDeseja repetir a operação? S ou N?");
                    reDo = (Console.ReadLine().ToLower());

                
                } while (reDo.Equals("s"));
        }
    }
}
