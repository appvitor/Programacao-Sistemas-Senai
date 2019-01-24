using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] intArray = new string[0];

            //for (int i = 0; i < 10; i++)
            //{
            //    Array.Resize(ref  intArray, intArray.Length + 1);
            //    intArray[intArray.Length - 1] = i;
            //}

            string nomeProduto = "";
            do
            {
               Console.WriteLine("\r\nDigite o nome do seu produto: (Digite 'sair' p/ finalizar)");
               nomeProduto = Console.ReadLine();

               if (!nomeProduto.Equals("sair"))
               {
                   Array.Resize(ref  intArray, intArray.Length + 1);
                   intArray[intArray.Length - 1] = nomeProduto;
               }

            } while (!nomeProduto.Equals("sair"));

            Console.Clear();

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            

            Console.ReadKey();
        }
    }
}
