using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx
            //http://msdn.microsoft.com/en-us/library/0c899ak8(v=vs.110).aspx
            // http://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
            //Format: 
            string aluno1 = "Zezinho", aluno2 = "Luizinho";
            double nota1 = 10, nota2 = 5.2;
            string frase = "O aluno {0} tirou {1:n} na prova; \r\n" +
                            "O aluno {2} tirou {3:00} na prova";

            //Console.WriteLine("\r\n" + "O aluno " + aluno1 + " tirou " + nota1.ToString("n") + " na prova;");

            Console.WriteLine("\r\n" + String.Format(frase, aluno1, nota1, aluno2, nota2));

            //Contains
            if (frase.Contains("aluno"))
            {
                Console.WriteLine("\r\nUm aluno fez a prova");
            }
            else
            {
                Console.WriteLine("\r\nNenhum aluno fez a prova");
            }

            if (!String.IsNullOrEmpty(frase))
            {
                Console.WriteLine("\r\nHouve uma prova");
            }
            else
            {
                Console.WriteLine("\r\nNão houve prova");
            }

            //Replace
            Console.WriteLine(String.Format("\r\n" + frase.Replace("prova", "avaliação"),
                                                    aluno1, nota1, aluno2, nota2));

            //Tolower e ToUpper
            Console.WriteLine(String.Format("\r\n" + frase.ToLower(), aluno1.ToLower(), nota1, aluno2.ToLower(), nota2));
            Console.WriteLine(String.Format("\r\n" + frase.ToUpper(), aluno1.ToUpper(), nota1, aluno2.ToUpper(), nota2));

            //Trim
            Console.WriteLine("\r\n" + String.Format(("           " + frase).Trim(), aluno1, nota1, aluno2, nota2));

            //Substring
            Console.WriteLine("\r\n" + frase.Substring(0, 7));

            //IndexOf
            Console.WriteLine("\r\n" + frase.IndexOf("aluno"));

            //insert
            Console.WriteLine("\r\n" + String.Format(frase.Insert(17, " Insert"), aluno1, nota1, aluno2, nota2));

            Console.ReadKey();
        }
    }
}
