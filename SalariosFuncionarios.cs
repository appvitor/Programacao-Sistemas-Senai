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
            string nomeFuncionario1, nomeFuncionario2, nomeFuncionario3, nomeFuncionario4;
            int horasTrabalhadas1, horasTrabalhadas2, horasTrabalhadas3, horasTrabalhadas4;
            double valorHora1, valorHora2, valorHora3, valorHora4;

            Console.WriteLine("\r\nDigite o nome do 1º funcionário: ");
            nomeFuncionario1 = Console.ReadLine();

            GetValorValidado("\r\nDigite as horas trabalhadas do 1º funcionário: ", out horasTrabalhadas1);

            GetValorValidado("\r\nDigite o valor da hora do 1º funcionário: ", out valorHora1);

            Console.Clear();
            Console.WriteLine("\r\nDigite o nome do 2º funcionário: ");
            nomeFuncionario2 = Console.ReadLine();

            GetValorValidado("\r\nDigite as horas trabalhadas do 2º funcionário: ", out horasTrabalhadas2);

            GetValorValidado("\r\nDigite o valor da hora do 2º funcionário: ", out valorHora2);

            Console.Clear();
            Console.WriteLine("\r\nDigite o nome do 3º funcionário: ");
            nomeFuncionario3 = Console.ReadLine();

            GetValorValidado("\r\nDigite as horas trabalhadas do 3º funcionário: ", out horasTrabalhadas3);

            GetValorValidado("\r\nDigite o valor da hora do 3º funcionário: ", out valorHora3);

            Console.Clear();
            Console.WriteLine("\r\nDigite o nome do 4º funcionário: ");
            nomeFuncionario4 = Console.ReadLine();

            GetValorValidado("\r\nDigite as horas trabalhadas do 4º funcionário: ", out horasTrabalhadas4);

            GetValorValidado("\r\nDigite o valor da hora do 4º funcionário: ", out valorHora4);

            Console.Clear();

            Console.WriteLine("\r\n\r\nFuncionário: {0}\r\nSalário: {1:C}", nomeFuncionario1, horasTrabalhadas1 * valorHora1);
            Console.WriteLine("\r\n\r\nFuncionário: {0}\r\nSalário: {1:C}", nomeFuncionario2, horasTrabalhadas2 * valorHora2);
            Console.WriteLine("\r\n\r\nFuncionário: {0}\r\nSalário: {1:C}", nomeFuncionario3, horasTrabalhadas3 * valorHora3);
            Console.WriteLine("\r\n\r\nFuncionário: {0}\r\nSalário: {1:C}", nomeFuncionario4, horasTrabalhadas4 * valorHora4);

            double somaSalarios = horasTrabalhadas1 * valorHora1 +
                                    horasTrabalhadas2 * valorHora2 +
                                    horasTrabalhadas3 * valorHora3 +
                                    horasTrabalhadas4 * valorHora4;

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
