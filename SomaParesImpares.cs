using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaParesImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0, somaPar = 0, somaImpar = 0;
            do
            {
                bool teste = false;
                do
                {
                    Console.WriteLine("\r\nDigite um número positivo ( > 1000 p/ Sair ): ");
                    teste = int.TryParse(Console.ReadLine(), out valor);

                    if (!teste)
                    {
                       Console.WriteLine("\r\nDigito Inválido, digite novamente no formato numérico.");
                    }
                    else if (valor < 0)
                    {
                        Console.WriteLine("\r\nDigito Inválido, o número digitado deve ser positivo.");
                        teste = false;
                    }

                } while (!teste);
               

                if (valor <= 1000)
                {
                    if (valor % 2 == 0)
                    {
                        somaPar += valor;
                    }
                    else
                    {
                        somaImpar += valor;
                    }
                }

            } while (valor <= 1000);

            Console.WriteLine("\r\nSoma dos pares: " + somaPar);
            Console.WriteLine("\r\nSoma dos ímpares: " + somaImpar);

            Console.ReadKey();
        }
    }
}
