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

            int repeticao = 0;
           
                #region "Geração de Senha"

            senha1 = randNum.Next(0, 10);
            senha2 = randNum.Next(0, 10);
            senha3 = randNum.Next(0, 10);

                #endregion
            do
            {

                GetValorValidadoZeroNove("\r\nDigite o 1º número da senha: ", out resposta1);

                GetValorValidadoZeroNove("\r\nDigite o 2º número da senha: ", out resposta2);

                GetValorValidadoZeroNove("\r\nDigite o 3º número da senha: ", out resposta3);

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
                    if (resposta2 == resposta1)
                    {
                        if (ContaCodigoEmSenhas(resposta2, senha1, senha2, senha3) >= 2)
                        {
                            ContAcertos++;
                        }
                    }
                    else
                    {
                        ContAcertos++;
                    }
                }


                if (resposta3 == senha1 ||
                    resposta3 == senha2 ||
                    resposta3 == senha3)
                {
                    if (resposta3 == resposta1 && resposta3 == resposta2)
                    {
                        if (ContaCodigoEmSenhas(resposta3,senha1, senha2, senha3)  >= 3)
                        {
                            ContAcertos++;
                        }
                    }
                    else if (resposta3 == resposta1 || resposta3 == resposta2)
                    {                     
                        if (ContaCodigoEmSenhas(resposta3, senha1, senha2, senha3) >= 2)
                        {
                            ContAcertos++;
                        }
                    }
                    else
                    {
                        ContAcertos++;
                    }
                }

                #endregion

                if (ContAcertos == 3 && contOrdemCerta == 3)
                {
                    MensagemAbriuCofre();
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


        private static void GetValorValidadoZeroNove(string mensagem, out int valorRetornavel, string mensagemErro = "\r\nDeve ser digitado um valor numérico entre 0 e 9")
        {
            bool valida = false;
            do
            {
                Console.WriteLine(mensagem);
                valida = int.TryParse(Console.ReadLine(), out valorRetornavel);

                if (valida)
                {
                    if (valorRetornavel > 9 || valorRetornavel < 0)
                    {
                        valida = false;
                        Console.WriteLine("\r\nO nº deve estar entre 0 e 9");
                    }
                }
                else
                {
                    Console.WriteLine(mensagemErro);
                }

            } while (!valida);
        }

        private static void GetValorValidadoZeroNove(string mensagem, out double valorRetornavel, string mensagemErro = "\r\nDeve ser digitado um valor numérico entre 0 e 9")
        {
            bool valida = false;
            do
            {
                Console.WriteLine(mensagem);
                valida = double.TryParse(Console.ReadLine(), out valorRetornavel);

                if (valida)
                {
                    if (valorRetornavel > 9 || valorRetornavel < 0)
                    {
                        valida = false;
                        Console.WriteLine("\r\nO nº deve estar entre 0 e 9");
                    }
                }
                else
                {
                    Console.WriteLine(mensagemErro);
                }

            } while (!valida);
        }






        static void MensagemAbriuCofre()
        {
            Console.WriteLine("\r\nPARABÉNS, VOCÊ ABRIU O COFRE!");
        }


        static int ContaCodigoEmSenhas(int codigo, int senha1, int senha2, int senha3) 
        {
            int contNumerosIguais = 0;

            if (codigo == senha1)
            {
                contNumerosIguais++;
            }

            if (codigo == senha2)
            {
                contNumerosIguais++;
            }

            if (codigo == senha3)
            {
                contNumerosIguais++;
            }

            return contNumerosIguais;
        }



    }
}
