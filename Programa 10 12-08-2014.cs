using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_10_12_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorHoraA, prof1, prof2, salario1, salario2;

            Console.WriteLine("Digite valor em R$ de Hora/Aula");
            valorHoraA = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor da quantidade de Horas/Aula do Professor 1");
            prof1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor da quantidade de Horas/Aula do Professor 2");
            prof2 = float.Parse(Console.ReadLine());

            salario1 = valorHoraA * prof1;
            salario2 = valorHoraA * prof2;

            if (salario1 > salario2)
            {
                Console.WriteLine("O Salário Maior é do Professor 1! Resultado: " + salario1);
            }
            else if (salario2 > salario1)
            {
                Console.WriteLine("Sálário Maior é do Professor 2! Resultado: " + salario2);
            }
            else if (salario1 == salario2)
            {
                Console.WriteLine("O Salário dos dois professores é igual!");
            }
            Console.ReadKey();

        }
    }
}
