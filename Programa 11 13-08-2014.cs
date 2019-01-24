﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_11_13_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            string prof1, prof2;
            double horaAula1, horaAula2, vlHoraAula1, vlHoraAula2;

            Console.WriteLine("Digite o nome do 1º professor: ");
            prof1 = Console.ReadLine().Trim();

            Console.WriteLine("\r\nDigite o nome do 2º professor: ");
            prof2 = Console.ReadLine();

            Console.WriteLine("\r\nDigite as horas/aula do 1º professor: ");
            horaAula1 = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("\r\nDigite as horas/aula do 2º professor: ");
            horaAula2 = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("\r\nDigite o valor da hora/aula do 1º professor: ");
            vlHoraAula1 = double.Parse(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("\r\nDigite o valor da hora/aula do 2º professor: ");
            vlHoraAula2 = double.Parse(Console.ReadLine().Replace(".", ","));

            double salProf1 = horaAula1 * vlHoraAula1;
            double salProf2 = horaAula2 * vlHoraAula2;

            if (salProf1 > salProf2)
            {
                Console.WriteLine("\r\nO professor " + prof1 + " teve o maior salário: " + salProf1.ToString("C"));
            }
            else if (salProf1 < salProf2)
            {
                Console.WriteLine("\r\nO professor " + prof2 + " teve o maior salário: " + salProf2.ToString("C"));
            }
            else
            {
                Console.WriteLine("\r\nAmbos os professores" + prof1 + " e " + prof2 + " receberam o mesmo salário: " + salProf1);
            }

            Console.ReadKey();
        }
    }
}
