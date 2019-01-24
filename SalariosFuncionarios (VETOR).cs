using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariosFuncionarios
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] nomeFuncionario = new string[4];
            int[] horasTrabalhadas = new int[4];
            double[] valorHora = new double[4];


            for (int i = 0; i < nomeFuncionario.Length; i++)
            {
                Console.WriteLine("\r\nDigite o nome do {0}º funcionário: ", i+1);
                nomeFuncionario[i] = Console.ReadLine();

                GetValorValidado(String.Format("\r\nDigite as horas trabalhadas do {0}º funcionário: ", i+1),
                    out horasTrabalhadas[10]);

                GetValorValidado(String.Format("\r\nDigite o valor da hora do {0}º funcionário: ", i + 1),
                    out valorHora[i]);

                Console.Clear();
            }

            double somaSalarios = 0;
            for (int i = 0; i < nomeFuncionario.Length; i++)
            {
                Console.WriteLine("\r\n\r\nFuncionário: {0}\r\nSalário: {1:C}", nomeFuncionario[i], 
                    horasTrabalhadas[i] * valorHora[i]);

                somaSalarios += horasTrabalhadas[i] * valorHora[i];
            }

            Console.WriteLine("\r\n\r\nSoma dos Salários: {0:c}", somaSalarios);

            Console.ReadKey();
        }


        private static void GetValorValidado(string mensagem, out int valorRetornavel, string mensagemErro = "\r\nDeve ser digitado um valor inteiro numérico.")
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

        private static void GetValorValidado(string mensagem, out double valorRetornavel, string mensagemErro = "\r\nDeve ser digitado um valor numérico.")
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
