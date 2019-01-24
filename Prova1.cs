using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {

            //int valor1, valor2, valor3;

            //Console.WriteLine("\r\nDigite o valor 1: ");
            //valor1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("\r\nDigite o valor 2: ");
            //valor2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("\r\nDigite o valor 3: ");
            //valor3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("\r\nSoma: " + (valor1 + valor2 + valor3));
            //Console.WriteLine("\r\nMédia: " + (((double)valor1 + valor2 + valor3) / 3));
            //Console.WriteLine("\r\nProduto: " + (valor1 * valor2 * valor3));

            //Console.ReadKey();

            //=================================================================================================================//

            //double valor1, valor2;
            //string aluno1, aluno2;

            //Console.WriteLine("\r\nDigite o aluno 1: ");
            //aluno1 = Console.ReadLine();

            //Console.WriteLine("\r\nDigite o valor 1: ");
            //valor1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("\r\nDigite o aluno 2: ");
            //aluno2 = Console.ReadLine();

            //Console.WriteLine("\r\nDigite o valor 2: ");
            //valor2 = double.Parse(Console.ReadLine());

            //if (valor1 >= 6.0 && valor2 >= 6.0)
            //{
            //    Console.WriteLine("\r\nAmbos os Alunos passaram");
            //}
            //else if (valor1 >= 6.0)
            //{
            //    Console.WriteLine("\r\nApenas o aluno " + aluno1 + " passou");
            //}
            //else if (valor2 >= 6.0)
            //{
            //    Console.WriteLine("\r\nApenas o aluno " + aluno2 + " passou");
            //}
            //else
            //{
            //    Console.WriteLine("\r\nAmbos os Alunos reprovaram");
            //}

            //Console.ReadKey();

            //=================================================================================================================//

            double vlMin = 0, vlMax = 0;
            string vlImpares = "";

            Random randNum = new Random();
            for (int i = 0; i < 5; i++)
            {
                int vlRandom = randNum.Next(0, 11);
                //Console.WriteLine("\r\nDigite o valor " + (i+1) + ": ");
                //int vlRandom = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    vlMin = vlRandom;
                    vlMax = vlRandom;
                }
                else
                {
                    if (vlRandom < vlMin)
                    {
                        vlMin = vlRandom;
                    }

                    if (vlRandom > vlMax)
                    {
                        vlMax = vlRandom;
                    }
                }

                if (!(vlRandom % 2 == 0))
                {
                    vlImpares += vlRandom + ", ";
                }

            }

            Console.WriteLine("\r\nMaior Valor : " + vlMax);
            Console.WriteLine("\r\nMenor Valor: " + vlMin);
            Console.WriteLine("\r\nNúmeros Impares: " + vlImpares.Substring(0,vlImpares.Length -2));


            Console.ReadKey();
        }
    }
}
