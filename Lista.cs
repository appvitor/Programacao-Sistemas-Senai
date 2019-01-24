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
            List<string> listaDeStrings = new List<string>();

            listaDeStrings.Clear(); // Reinicia Lista

            listaDeStrings.Add("5");
            listaDeStrings.Add("8");
            listaDeStrings.Add("7");
            listaDeStrings.Add("4");

            int intAux = 0;
            foreach (string item in listaDeStrings)
            {
                Console.WriteLine(item);
                intAux++;
            }

            for (int i = 0; i < listaDeStrings.Count; i++)
            {
                Console.WriteLine(listaDeStrings[i]);
            }

            listaDeStrings.Remove("5"); // remove por elemento
            listaDeStrings.RemoveAt(0); // remove por index    

            bool teste = listaDeStrings.Contains("5");

            listaDeStrings.IndexOf("5");

            Console.ReadKey();
        }
    }
}