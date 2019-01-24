using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. 
//Para isto, mandou digitar cada mercadoria com o nome, preço de compra preço de venda das mercadorias. Fazer um algoritmo que:
//• Determine e escreva quantas mercadorias proporcionam:
//• Lucro menor 10 %;
//• Lucro entre 10% e 20%;
//• Lucro maior que 20%.
//• Determine e escreva o valor total de compra e de venda de todas as mercadorias, assim como o lucro total.

namespace ConsoleApplication3
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
            double preçoCompra, preçoVenda;
            double[] gavetaValoresCompra = new double[0];
            double[] gavetaValoresVenda = new double[0];
            string[] gavetaProdutos = new string[0];
            string nomeProduto = "", respostaExclusao = "", respostaNumeroCodigo = "";
            
            do
            {
                Console.Clear();
                DesenharPrimeiroMenu();
                GetValorValidado("\r\n\r\nDigite a opçao desejada: ", out menuPrincipal);

                switch (menuPrincipal)
                {
                    case 1:


                        int somaNome = 1;

                        do
                        {
                            Console.Clear();
                            DesenharPrimeiroMenu();
                            Console.WriteLine("\r\nDigite o nome do seu {0}º produto: (Para trocar opção digite: 'sair')", somaNome);
                            nomeProduto = Console.ReadLine();
                            
                            if (!nomeProduto.Equals("sair"))
                            {
                                Array.Resize(ref  gavetaProdutos, gavetaProdutos.Length + 1);
                                gavetaProdutos[gavetaProdutos.Length - 1] = nomeProduto;

                                GetValorValidado(string.Format("\r\nDigite o valor de compra do {0}º produto.", somaNome), out preçoCompra);
                                Array.Resize(ref  gavetaValoresCompra, gavetaValoresCompra.Length + 1);
                                gavetaValoresCompra[gavetaValoresCompra.Length - 1] = preçoCompra;

                                GetValorValidado(string.Format("\r\nDigite o valor de venda do {0}º produto.", somaNome), out preçoVenda);
                                Array.Resize(ref  gavetaValoresVenda, gavetaValoresVenda.Length + 1);
                                gavetaValoresVenda[gavetaValoresVenda.Length - 1] = preçoVenda;


                                Console.WriteLine("\r\nO código de " + nomeProduto + " é: " + (gavetaProdutos.Length - 1));

                                Console.ReadKey();

                                somaNome++;
                            }


                        } while (!nomeProduto.Equals("sair"));

                        Console.Clear();

                        break;

                    case 2:
                        Console.Clear();
                        DesenharOpçaoManutenção();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\r\nDigite o código do produto a ser deletado: ");
                        Console.WriteLine("\r\nEscreva ´´tudo´´ para deletar todos os produtos.");
                        Console.WriteLine("\r\nOu deixe em branco para continuar");
                        respostaExclusao = Console.ReadLine();

                        if (respostaExclusao.ToLower().Equals ("tudo"))
                        {
                            gavetaValoresCompra = new double[0];
                            gavetaValoresVenda = new double[0];
                            gavetaProdutos = new string[0];

                            Console.WriteLine("Todos os produtos foram excluídos com sucesso!");

                            Console.ReadKey();
                        }

                        else
                        {
                            for (int i = 0; i < gavetaProdutos.Length; i++)
                            {
                                Console.Clear();
                                Console.WriteLine("\r\n\t\t\t\tÉ o produto de código nº " + i + " que deseja alterar?");
                                respostaNumeroCodigo = Console.ReadLine();

                                if (respostaNumeroCodigo.ToLower().Equals("sim"))
                                {
                                    gavetaValoresCompra = new double[i];
                                    gavetaValoresVenda = new double[i];
                                    gavetaProdutos = new string[i];

                                    Console.WriteLine("\r\n\t\t\t\t\tProduto deletado com sucesso!");

                                    Console.ReadKey();
                                }
                            }    

                        }


                        break;

                    case 4:
                        int vlSubMenu = 0;
                        do
                        {
                            double[] vetLucro = new double[gavetaProdutos.Length];

                            Console.Clear();
                            DesenharSegundoMenu();

                            GetValorValidado("\r\n\r\nDigite a opçao desejada: ", out vlSubMenu);

                            switch (vlSubMenu)
                            {
                                case 1:

                                    Console.Clear();

                                    for (int i = 0; i < gavetaProdutos.Length; i++)
                                    {
                                        vetLucro[i] = ((gavetaValoresVenda[i] / gavetaValoresCompra[i]) - 1);

                                        if (vetLucro[i] < 0.10)
                                        {
                                            EscreverSegundoMenu(gavetaProdutos, gavetaValoresCompra, gavetaValoresVenda, vetLucro, i);
                                        }
                                    }
                                    Console.ReadKey();
                                    break;

                                case 2:

                                    Console.Clear();
                                    for (int i = 0; i < gavetaProdutos.Length; i++)
                                    {
                                        vetLucro[i] = ((gavetaValoresVenda[i] / gavetaValoresCompra[i]) - 1);

                                        if (vetLucro[i] >= 0.10 && vetLucro[i] <= 0.20)
                                        {
                                            EscreverSegundoMenu(gavetaProdutos, gavetaValoresCompra, gavetaValoresVenda, vetLucro, i);
                                        }
                                    }


                                    Console.ReadKey();
                                    break;

                                case 3:

                                    Console.Clear();
                                    for (int i = 0; i < gavetaProdutos.Length; i++)
                                    {
                                        vetLucro[i] = ((gavetaValoresVenda[i] / gavetaValoresCompra[i]) - 1);

                                        if (vetLucro[i] > 0.20)
                                        {
                                            EscreverSegundoMenu(gavetaProdutos, gavetaValoresCompra, gavetaValoresVenda, vetLucro, i);
                                        }

                                    }
                                    Console.ReadKey();
                                    break;

                                case 4:

                                    double totalVenda = 0, totalCompra = 0, totalLucro = 0;
                                    Console.Clear();

                                    for (int i = 0; i < gavetaProdutos.Length; i++)
                                    {
                                        vetLucro[i] = ((gavetaValoresVenda[i] / gavetaValoresCompra[i]) - 1);
                                        totalVenda += gavetaValoresVenda[i];
                                        totalCompra += gavetaValoresCompra[i];
                                        totalLucro += vetLucro[i];
                                    }

                                    Console.WriteLine("\t\t\t       Balanço Financeiro");
                                    Console.Write("\r\n\r\n\r\n\t\t\tValor total em compras:");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine(" {0:c}.", totalCompra);
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("\r\n\t\t\tValor total em vendas:");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine(" {0:c}.", totalVenda);
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("\r\n\t\t\tPorcentagem de lucro:");
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine(" {0:p}.", (totalLucro / gavetaProdutos.Length));

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("");

                                    Console.ReadKey();
                                    break;
                            }

                        } while (vlSubMenu != 5);

                        break;
                }

            } while (menuPrincipal != 5);

        }

        private static void DesenharPrimeiroMenu()
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("                 $ $ $           MENU DE CADASTROS        $ $ $             ");
            Console.Write("_______________________________________________________________________________ ");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("█                                                                             █");
            Console.WriteLine("█                               1 - Inserir produtos                          █");
            Console.WriteLine("█                               2 - Alterar Produtos                          █");
            Console.WriteLine("█                               3 - Excluir Produtos                          █");
            Console.WriteLine("█                               4 - Apresentar Lucros                         █");
            Console.WriteLine("█                                                                             █");
            Console.WriteLine("█                               5 - Sair do Programa                          █");  
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

        }
        private static void DesenharCifrao()
        {

        }

        private static void DesenharSegundoMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("                 $ $ $        Escolha a opçao desejada        $ $ $             ");
            Console.Write("_______________________________________________________________________________ ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("█                                                                             █");
            Console.WriteLine("█                               1 - Lucro menor 10 %                          █");
            Console.WriteLine("█                               2 - Lucro entre 10% e 20%                     █");
            Console.WriteLine("█                               3 - Lucro maior que 20%                       █");
            Console.WriteLine("█                               4 - Lucros Totais                             █");
            Console.WriteLine("█                                                                             █");
            Console.WriteLine("█                               5 - Retornar ao início                        █");
            Console.WriteLine("█                                                                             █");
            Console.Write("_______________________________________________________________________________ ");
        }


        private static void EscreverSegundoMenu(string[] vetNomeProduto, double[] vetPreçoCompra, double[] vetPreçoVenda, double[] vetLucro, int i)
        {
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("\t\t\t     Produto: {0}.\r\n", vetNomeProduto[i]);
            Console.WriteLine("\t\t\tCódigo do produto: {0}.", i);
            Console.Write("\t\t\tValor de compra:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" {0:c}.", vetPreçoCompra[i]);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\t\tValor de venda:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" {0:c}.", vetPreçoVenda[i]);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t\tPorcentagem de lucro: {0:p}.", vetLucro[i]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        private static void DesenharOpçaoManutenção()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t\t\r\n\t\t     Opção nao Disponivel no momento!");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\r\n                                                                 ▄█▄▄▄█▄");
            Console.WriteLine("                  ▄▓▄        ──█───█───────────────       ▄▀    ▄▌─▄─▄─▐▄    ▀▄");
            Console.WriteLine("      ▄█▄        ▄▓▓▓▄       ███████─────────▄▀▀▄─        █▄▄█  ▀▌─▀─▀─▐▀  █▄▄█");
            Console.WriteLine("    ▄█████▄     ▄▓▓▓▓▓▄      ██─▀─██  █▀█▀▀▀▀█  █          ▐▌    ▀▀███▀▀    ▐▌");
            Console.WriteLine("   ▀██┼█┼██▀   ▄▓▓▓▓▓▓▓▄     ███▄███  ▀ ▀     ▀▀          ████ ▄█████████▄ ████");
            Console.WriteLine("  ▄▄███████▄▄▄▄▄▄▄▄█▄▄▄▄     ███████                                                 ");
            Console.WriteLine("_________♥______♦______♣______♠______ - _____♥_______♦_______♣_______♠_________\n\r█ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █  █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ ██ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █ █  ");
            Console.WriteLine("________________________________________________________________________________");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\r\n\r\n\t\t\t\t [Enter]");
        }
        private static void GetValorValidado(string mensagem, out int valorRetornavel, string mensagemErro = "\r\nPor favor digite um número inteiro.")
        {
            bool valida = false;
            do
            {
                Console.WriteLine(mensagem);
                valida = int.TryParse(Console.ReadLine(), out valorRetornavel);

                if (!valida)
                {
                    Console.WriteLine(mensagemErro);
                }

            } while (!valida);
        }

        private static void GetValorValidado(string mensagem, out double valorRetornavel, string mensagemErro = "\r\nDigite apenas valores numéricos!")
        {
            bool valida = false;
            do
            {
                Console.WriteLine(mensagem);
                valida = double.TryParse(Console.ReadLine(), out valorRetornavel);

                if (!valida)
                {
                    Console.WriteLine(mensagemErro);
                }

            } while (!valida);
        }
    }
}

