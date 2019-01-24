using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacoesVarias
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3;
            do
            {
                Console.Title = "Validações Várias";
                Console.Clear();
                bool teste = false;

                do
                {
                    Console.Clear();
                    Console.WriteLine("\r\nDigitar conjuntos de 3 algarismos numéricos, estando um deles entre 100 e 200: ");
                    Console.WriteLine("\r\n================================================================================");

                    Console.WriteLine("\r\nDigite o primeiro valor do conjunto: ");
                    do
                    {
                        teste = double.TryParse(Console.ReadLine(), out valor1);

                        if (!teste)
                        {
                            Console.WriteLine("\r\nValor inválido. Digite novamente em formato numérico: ");
                        }
                    } while (!teste);

                    teste = false;
                    Console.WriteLine("\r\nDigite o segundo valor do conjunto: ");
                    do
                    {
                        teste = double.TryParse(Console.ReadLine(), out valor2);

                        if (!teste)
                        {
                            Console.WriteLine("\r\nValor inválido. Digite novamente em formato numérico: ");
                        }
                    } while (!teste);

                    teste = false;
                    Console.WriteLine("\r\nDigite o terceiro valor do conjunto: ");
                    do
                    {
                        teste = double.TryParse(Console.ReadLine(), out valor3);

                        if (!teste)
                        {
                            Console.WriteLine("\r\nValor inválido. Digite novamente em formato numérico: ");
                        }
                    } while (!teste);

                    if (!(valor1 < valor2 && valor2 < valor3))
                    {
                        break;
                    }

                    //valor1 ,valor2 ou valor3 devem estar entre 100 e 200;
                    if (!((valor1 >= 100 && valor1 <= 200) || 
                    (valor2 >= 100 && valor2 <= 200) || 
                    (valor3 >= 100 && valor3 <= 200)))
                    {
                        Console.WriteLine("\r\nNecessário que um dos números do conjunto esteja entre 100 e 200. ");
                        Console.ReadKey();
                    }

                } while (!((valor1 >= 100 && valor1 <= 200) || 
                    (valor2 >= 100 && valor2 <= 200) || 
                    (valor3 >= 100 && valor3 <= 200)));

                if (valor1 < valor2 && valor2 < valor3)
                {
                    Console.WriteLine("\r\nSoma do conjunto = " + (valor1 + valor2 + valor3));
                    Console.WriteLine("\r\nProduto do conjunto = " + (valor1 * valor2 * valor3));
                    Console.WriteLine("\r\nMédia do conjunto = " + ((valor1 + valor2 + valor3) / 3));

                    Console.WriteLine("\r\nVocê digitou uma ordem crescente. O programa sera reiniciado.");
                }
                else
                {
                    Console.WriteLine("\r\nVocê não digitou uma ordem crescente. O programa será finalizado.");
                }

                Console.ReadKey();
               

            } while (valor1 < valor2 && valor2 < valor3); //!(valor3 > valor2 && valor2 > valor3)

            Console.Clear();
        }
    }
}
