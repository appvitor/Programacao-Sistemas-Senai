using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MenuSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int vlMenu = 0;
            bool finalizar = false;
            string professor = "", aula = "";
            do
            {
                Console.Clear();
                Console.WriteLine("===============================================================================");
                Console.WriteLine("||\r\n\t\t[1] Insira o nome do professor                      ||");
                Console.WriteLine("||\r\n\t\t[2] Insira a aula lecionada pelo professor");
                Console.WriteLine("||\r\n\t\t[3] Apresente o professor");
                Console.WriteLine("||\r\n\t\t[0] Sair");
                Console.WriteLine("||\r\n===============================================================================");

                Console.WriteLine("\r\n\r\n\t\tDigite a opção desejada: ");
                vlMenu = int.Parse(Console.ReadLine());

                switch (vlMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Insira o nome do professor");
                        professor = Console.ReadLine();
                        Console.WriteLine("\r\nNome inserido com sucesso!");
                        Console.ReadKey();
                        finalizar = false;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Insira a aula lecionada pelo professor");
                        aula = Console.ReadLine();
                        Console.WriteLine("\r\nAula inserida com sucesso!");
                        Console.ReadKey();
                        finalizar = false;
                        break;                        
                    case 3:
                        Console.Clear();
                        Console.WriteLine(String.IsNullOrEmpty(professor) ? "Nome não inserido!" : "Professor: " + professor);
                        Console.WriteLine(aula.Equals("") ? "Aula não inserida!" : "Aula: " + professor);
                        Console.ReadKey();
                        finalizar = false;
                        break;
                    case 0:
                        finalizar = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida");
                        Console.ReadKey();
                        finalizar = false;
                        break;
                }

            } while (!finalizar);

            Console.Clear();
            Console.WriteLine("Programa finalizado");
            Console.ReadKey();


        }
    }
}
