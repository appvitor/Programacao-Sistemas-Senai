using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Verificar IMC
namespace Programa_9_12_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso;

            Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine().Replace(".",","));

            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine().Replace(".",","));

            double IMC = peso / (altura * altura);

            Console.WriteLine("Digite seu sexo (Masculino/Feminino): ");
            string sexo = Console.ReadLine().ToLower();

            if (sexo.Equals("masculino"))
            {
                if (IMC < 20.7)
                {
                    Console.WriteLine("Abaixo do Peso!");
                }
                else if (IMC >= 20.7 && IMC < 26.4)
                {
                    Console.WriteLine("No peso normal");
                }
                else if (IMC >= 26.4 && IMC < 27.8)
                {
                    Console.WriteLine("Marginalmente acima do peso...");
                }
                else if (IMC >=27.8 && IMC < 31.1)
                {
                    Console.WriteLine("Acima do Peso Ideal!");
                }
                else if (IMC >= 31.1)
                {
                    Console.WriteLine("Obeso!!!");
                }
            }
                if (sexo.Equals("feminino"))
                
                    if (IMC < 19.1)
                    {
                        Console.WriteLine("Abaixo do Peso!");
                    }
                    else if (IMC >= 19.1 && IMC < 25.8)
                    {
                        Console.WriteLine("No peso normal");
                    }
                    else if (IMC >= 25.8 && IMC < 27.3)
                    {
                        Console.WriteLine("Marginalmente acima do peso...");
                    }
                    else if (IMC >=27.3 && IMC < 32.3)
                    {
                        Console.WriteLine("Acima do Peso Ideal!");
                    }
                    else if (IMC >= 32.3)
                    {
                        Console.WriteLine("Obeso!!!");
                    }
            else
            {
                Console.WriteLine("Sexo Inválido!");
            }
        Console.ReadKey();

        }
    }
}
