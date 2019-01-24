using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDoCofre
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha1, senha2, senha3;
            int resposta1, resposta2, resposta3;
            Random randNum = new Random();

            #region "Geração de Senha"

            senha1 = randNum.Next(0, 10);
            do
            {
                senha2 = randNum.Next(0, 10);
            } while (senha2 == senha1);
            do
            {
                senha3 = randNum.Next(0, 10);
            } while (senha3 == senha1 || senha3 == senha2);

            #endregion

            int repeticao = 0;
            do
            {
              

                bool valida = false;

                #region "Valida 1º Número"
                do
                {
                    Console.WriteLine("\r\nDigite o 1º número da senha: ");
                    valida = int.TryParse(Console.ReadLine(), out resposta1);

                    if (valida)
                    {
                        if (resposta1 > 9 || resposta1 < 0)
                        {
                            valida = false;
                            Console.WriteLine("\r\nO nº deve estar entre 0 e 9");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\r\nDeve ser digitado um valor numérico enter 0 e 9");
                    }

                } while (!valida);
                #endregion

                Console.WriteLine("\r\nDigite o 2º número da senha: ");
                resposta2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\r\nDigite o 3º número da senha: ");
                resposta3 = int.Parse(Console.ReadLine());

                #region "Conta Ordem Certa"

                int contOrdemCerta = 0;
                if (resposta1 == senha1)
                {
                    contOrdemCerta++;
                }

                if (resposta2 == senha2)
                {
                    contOrdemCerta++;
                }

                if (resposta3 == senha3)
                {
                    contOrdemCerta++;
                }

                #endregion

                #region "Conta Acertos"

                int ContAcertos = 0;
                if (resposta1 == senha1 ||
                    resposta1 == senha2 ||
                    resposta1 == senha3)
                {
                    ContAcertos++;
                }

                if (resposta2 == senha1 ||
                    resposta2 == senha2 ||
                    resposta2 == senha3)
                {
                    ContAcertos++;
                }

                if (resposta3 == senha1 ||
                    resposta3 == senha2 ||
                    resposta3 == senha3)
                {
                    ContAcertos++;
                }
                #endregion

                if (ContAcertos == 3 && contOrdemCerta == 3)
                {
                    Console.WriteLine("\r\nPARABÉNS, VOCÊ ABRIU O COFRE!");
                }
                else
                {
                    Console.WriteLine("\r\nVocê acertou {0} números.", ContAcertos);
                    Console.WriteLine("\r\nVocê acertou {0} números na ordem certa.", contOrdemCerta);
                }
  
                Console.ReadKey();

                repeticao++;

            } while (repeticao < 10);
            
        }
    }
}
