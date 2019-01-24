using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cálculo Volume da Pirâmide;

namespace Programa_7_12_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            float altPiramide, largBase;

            Console.WriteLine("Digite a altura da pirâmide em metros: ");
            altPiramide = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a alargura da base em metros: ");
            largBase = float.Parse(Console.ReadLine());

            float areaBase = (float)Math.Pow(largBase, 2);          //largBase * largBase;

            Console.WriteLine("Volume da pirâmide = " + (areaBase * altPiramide) / 3 + " m³");
            Console.ReadKey();
        }
    }
}