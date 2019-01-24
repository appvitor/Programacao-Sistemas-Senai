using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Leia o nome de dois alunos e a nota que obtiveram na prova (0,0 a 10,0), 
//levando em consideração que a nota mínima para passar é 6,0, 
//verifique e apresente qual dos alunos passou, ou se ambos passaram/reprovaram.

namespace Programa30_25_08_2014_Prova1_
{
    class Program
    {
        static void Main(string[] args)
        {
            float  nota1, nota2;
            string nome1, nome2;

            Console.WriteLine("Qual é o nome do primeiro aluno? ");
            nome1 = (Console.ReadLine());

            Console.WriteLine("\r\nQual é o nome do segundo aluno? ");
            nome2 = (Console.ReadLine());

            Console.WriteLine("\r\nQual foi a nota de " + nome1 + " ? ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\r\nQual foi a nota de " + nome2 + " ? ");
            nota2 = float.Parse(Console.ReadLine());

                if (nota1 >= 6.0)
                {
                        if (nota2 >= 6.0)
                        Console.WriteLine("\r\nAmbos " + nome1 + " e " + nome2 + " foram aprovados! ");
                }

                else if (nota1 < 6.0)
                {
                        if (nota2 < 6.0)
                        Console.WriteLine("\r\nAmbos " + nome1 + " e " + nome2 + " foram reprovados! ");
                }

                else if (nota2 < 6.0)
                {
                        if  (nota1 >= 6.0)
                        Console.WriteLine("\r\nApenas " + nome1 + " foi aprovado. ");
                }

                else if (nota2 >= 6.0)
                {
                        if (nota1 < 6.0)
                        Console.WriteLine("\r\nApenas " + nome2 + " foi aprovado. ");
                }
            
            Console.ReadKey();
        }
    }
}
