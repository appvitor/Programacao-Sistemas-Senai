using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, mandou digitar cada mercadoria com o nome, 
//preço de compra preço de venda das mercadorias. Fazer um algoritmo que:
//• Determine e escreva quantas mercadorias proporcionam:
//• Lucro menor 10 %;
//• Lucro entre 10% e 20%;
//• Lucro maior que 20%.
//• Determine e escreva o valor total de compra e de venda de todas as mercadorias, assim como o lucro total.

namespace Programa40_08_09_2014__Trab.Vetor_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = ("Sistema de Produtos");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            int menuPrincipal = 0;

            string[] gavetaProdutos = new string[0];
            double[] gavetaValoresCompra = new double[0];
            double[] gavetaValoresVenda = new double[0];
            double[] gavetaLucros = new double[0];

            string nomeProduto = "";
            double valorCompraProduto = 0, valorVendaProduto = 0;

            bool checaOpcao = false;

            do
            {

                Console.WriteLine("________________________________________________________________________________");
                Console.WriteLine("                 $ $ $          LUCRO DAS MERCADORIAS        $ $ $             ");
                Console.Write("_______________________________________________________________________________ ");
            
                Console.WriteLine("█                                                                             █");
                Console.WriteLine("█                               1 - Inserir produtos                          █");
                Console.WriteLine("█                               2 - Alterar Produtos                          █");
                Console.WriteLine("█                               3 - Excluir Produtos                          █");
                Console.WriteLine("█                               4 - Apresentar Lucros                         █");
                Console.WriteLine("█                                                                             █");
                Console.WriteLine("█                               0 - Sair do Programa                          █");
                Console.WriteLine("█                                                                             █");
                Console.WriteLine("█                               $$$$$$$$$$$$$$$$$$$$                          █");
                Console.WriteLine("█                               $$    ▄▄███▄▄     $$                          █");
                Console.WriteLine("█                               $$    ██╔════╝    $$                          █");
                Console.WriteLine("█                               $$    ███████╗    $$                          █");
                Console.WriteLine("█                               $$    ╚════██║    $$                          █");
                Console.WriteLine("█                               $$    ███████║    $$                          █");
                Console.WriteLine("█                               $$    ╚═▀▀▀══╝    $$                          █");
                Console.WriteLine("█                               $$$$$$$$$$$$$$$$$$$$                          █");
                Console.WriteLine("█                                                                             █");
                Console.WriteLine("█_____________________________________________________________________________█");

                do
                {
                    Console.Write("Digite uma opção: ");
                    checaOpcao = int.TryParse(Console.ReadLine(), out menuPrincipal);

                    if (!checaOpcao)
                    {
                        Console.WriteLine("Digito incorreto - digite novamente!");
                    }
                    else if (menuPrincipal < 0 || menuPrincipal > 4)
                    {
                        Console.WriteLine("Digito incorreto - digite novamente!");
                    }

                } while (!checaOpcao);

                switch (menuPrincipal)
                {
                
                    case 1:

                        Console.Clear();
                        int voltaMenu;

                        do
                        {

                            Console.WriteLine("\r\nDigite o nome do produto: (Digite 'sair' p/ finalizar o programa)");
                            nomeProduto = Console.ReadLine();

                            if (!nomeProduto.Equals("sair"))
                            {
                                Array.Resize(ref  gavetaProdutos, gavetaProdutos.Length + 1);
                                gavetaProdutos[gavetaProdutos.Length - 1] = nomeProduto;

                                Console.WriteLine("\r\nDigite o valor de compra do produto:");
                                valorCompraProduto = double.Parse(Console.ReadLine());

                                Array.Resize(ref gavetaValoresCompra, gavetaValoresCompra.Length + 1);
                                gavetaValoresCompra[gavetaValoresCompra.Length - 1] = valorCompraProduto;

                                Console.WriteLine("\r\nDigite o valor de venda do produto:");
                                valorVendaProduto = double.Parse(Console.ReadLine());

                                Array.Resize(ref gavetaValoresVenda, gavetaValoresVenda.Length + 1);
                                gavetaValoresVenda[gavetaValoresVenda.Length - 1] = valorVendaProduto;
                            }
                        } while (!nomeProduto.Equals("sair"));
                    

                        Console.Clear();

                        checaOpcao = true;
                        break;

                    case 4:
                        for (int i = 1; i < gavetaProdutos.Length; i++)
                        {
                            gavetaLucros[i] = ((gavetaValoresVenda[i] / gavetaValoresCompra[i]) - 1);

                            Console.WriteLine(nomeProduto[i] + " = " + gavetaLucros[i] + " de lucro");

                            checaOpcao = true;
                        }
 
                        break;

                    case 0 :

                        Console.Clear();
                        Console.WriteLine("Programa Finalizado");
                        checaOpcao = false;

                        break;
                }

                Console.ReadKey();
            } while (menuPrincipal != 0);
            


        }
    }
}
