using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa39_05_09_2014
{
    class Program
    {
        static void DadosFuncionarios(int i = 0, bool checaHorasTrab, bool checaValorHora)
        {

            Console.WriteLine("\r\nDigite o nome do " + i + "º funcionário: ");
            nomeFuncionario = Console.ReadLine();

            Console.WriteLine("\r\nDigite a quantidade de horas trabalhadas do " + i + "º funcionário: ");
            checaHorasTrab = int.TryParse (Console.ReadLine(), out horasTrabalhadas);

            Console.WriteLine("\r\nDigite o valor da hora do " + i + "º funcionário: ");
            checaValorHora = double.TryParse(Console.ReadLine(), out valorHora);

            return  DadosFuncionarios;
        }
        

        static void Main(string[] args)
        {
            string nomeFuncionario;
            int horasTrabalhadas;
            double valorHora;
            bool checaHorasTrab = false, checaValorHora = false;

           for (int i = 0; i < 5 ; i++)
			{
			    DadosFuncionarios(bool checaHorasTrab, bool checaValorhora);
			}

            Console.Clear();
            Console.WriteLine("\r\nFuncionário {0} \r\nSalário: {1}", nomeFuncionario1, horasTrabalhadas1 * valorHora1);
            Console.WriteLine("\r\nFuncionário {0} \r\nSalário: {1}", nomeFuncionario2, horasTrabalhadas2 * valorHora2);
            Console.WriteLine("\r\nFuncionário {0} \r\nSalário: {1}", nomeFuncionario3, horasTrabalhadas3 * valorHora3);
            Console.WriteLine("\r\nFuncionário {0} \r\nSalário: {1}", nomeFuncionario4, horasTrabalhadas4 * valorHora4);

            double somaSalarios = horasTrabalhadas1 * valorHora1 +
                                    horasTrabalhadas2 * valorHora2 +
                                    horasTrabalhadas3 * valorHora3 +
                                    horasTrabalhadas4 * valorHora4;

            Console.WriteLine("\r\n: {0:c}", somaSalarios);

            Console.ReadKey();
        }
    }
}
