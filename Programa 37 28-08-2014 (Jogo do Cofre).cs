using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Trabalho: Jogo do cofre

//O jogo do cofre consiste em criar uma senha de 3 números inteiros de 0 a 9:
// - O usuário deve escolher se quer jogar na dificuldade Fácil (10 chances ), Médio ( 7 chances ) ou Difícil ( 5 chances );
// - O usuário terá X chances para tentar acertar a senha na ordem certa;
// - Para cada vez que o usuário tentar deve ser apresentado quantos números ele acertou e quantos estavam na ordem certa;
// - No fim, deve ser apresentado se ele conseguiu ou não abrir o cofre, e perguntar se deseja tentar novamente.

namespace Programa37_28_08_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("The Vault Game");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            int vlDifi, code1, code2, code3, num1, num2, num3;
            bool checkProgram = false, checkNum = false;
            Random randCode = new Random();

            #region "Random Code"
            code1 = randCode.Next(0, 10);

            do
            {
                code2 = randCode.Next(0, 10);

            } while (code2 == code1);

            do
            {
                code3 = randCode.Next(0, 10);

            } while (code3 == code1 || code3 == code2);
            #endregion

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine(" \t\t\t\t\t\t\t\t\t\t\t\t\tChoose the level of dificulty: ");
            Console.WriteLine(" \r\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t1 - EASY :)");
            Console.WriteLine(" \r\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t2 - MEDIUM :/");
            Console.WriteLine(" \r\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t3 - HARD :(" );
            Console.WriteLine(" \r\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t0 - EXIT");
            Console.WriteLine("\r\n////////////////////////////////////////////////////////////////////////////////");

            Console.SetCursorPosition(37, 23);
            checkNum = int.TryParse(Console.ReadLine(), out vlDifi);

            switch (vlDifi)
            {

                #region "Dificulty 1 - Easy"
                case 1:
                    for (int i = 9; i > -1; i--)
                    {
                        #region "Typing and Checking 1º Number"
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\tThe Vault has a sequence of  Three numbers that goes from 0 to 9");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tType the sequence to the Vault: ");

                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t1º number: ");
                            Console.SetCursorPosition(37, 10);
                            checkNum = int.TryParse(Console.ReadLine(), out num1);

                            if (checkNum)
                            {
                                if (num1 > 9 || num1 < 0)
                                {
                                    checkNum = false;
                                    Console.Clear();
                                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tThe number must be between 0 to 9 ! :/");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tYou typed something that is not a number !!! :(");
                                Console.ReadKey();
                            }
                        } while (!checkNum);
                        #endregion

                        #region "Typing and Checking 2º Number"
                        do
                        {
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t2º number: ");
                            Console.SetCursorPosition(37, 15);
                            checkNum = int.TryParse(Console.ReadLine(), out num2);

                            if (checkNum)
                            {
                                if (num2 > 9 || num2 < 0)
                                {
                                    checkNum = false;
                                    Console.Clear();
                                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tThe number must be between 0 to 9 ! :/");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tYou typed something that is not a number !!! :(");
                                Console.ReadKey();
                            }

                        } while (!checkNum);
                        #endregion

                        #region "Typing and Checking 3º Number"
                        do
                        {
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t3º number: ");
                            Console.SetCursorPosition(37, 20);
                            checkNum = int.TryParse(Console.ReadLine(), out num3);

                            if (checkNum)
                            {
                                if (num3 > 9 || num3 < 0)
                                {
                                    checkNum = false;
                                    Console.Clear();
                                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tThe number must be between 0 to 9 ! :/");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tYou typed something that is not a number !!! :(");
                                Console.ReadKey();
                            }
                            
                        } while (!checkNum);
                        #endregion

                        #region "Checking Right Numbers"

                        int checkRights = 0;
                        if (code1 == num1 || code1 == num2 || code1 == num3)
                        {
                            checkRights++;
                        }

                        if (code2 == num1 || code2 == num2 || code2 == num3)
                        {
                            checkRights++;
                        }

                        if (code3 == num1 || code3 == num2 || code3 == num3)
                        {
                            checkRights++;
                        }

                        #endregion

                        #region "Checking Order"

                        int checkOrder = 0;
                        if (code1 == num1)
                        {
                            checkOrder++;
                        }

                        if (code2 == num2)
                        {
                            checkOrder++;
                        }

                        if (code3 == num3)
                        {
                            checkOrder++;
                        }


                        #endregion

                        #region "Results"
                        if (checkRights == 3 && checkOrder == 3)
	                    {
		                    Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tCONGRATULATIONS!!!");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYou find out the password!!! :D");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tPassword: " + code1 + code2 + code3);                 
                            checkProgram = true;
                            Console.ReadKey();
                            break;
	                    }

                        if (i == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYour chances are over!!!");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tThe Password was: " + code1 + code2 + code3);
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\r\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tYOU LOSE :´(");
                            Console.SetCursorPosition(37, 15);
                            Console.ReadKey();
                            checkProgram = false;
                            break;

                        }

                        else
	                    {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYou' ve typed a wrong sequence...");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tBut You HITTED {0} numbers !!!", checkRights);
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tAnd {0} of them on the RIGHT SEQUENCE !!!", checkOrder);
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYou have " + i + " CHANCES to go... Try Again!!! :D");
                            checkProgram = false;
                            Console.ReadKey();

	                    }


                        #endregion

                    }
                    
                    break;
                #endregion

                #region "Dificulty 2 - Medium"
                case 2:
                    for (int i = 6; i > -1; i--)
                    {
                        #region "Typing and Checking 1º Number"
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\tThe Vault has a sequence of  Three numbers that goes from 0 to 9");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tType the sequence to the Vault: ");

                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t1º number: ");
                            Console.SetCursorPosition(37, 10);
                            checkNum = int.TryParse(Console.ReadLine(), out num1);

                            if (checkNum)
                            {
                                if (num1 > 9 || num1 < 0)
                                {
                                    checkNum = false;
                                    Console.Clear();
                                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tThe number must be between 0 to 9 ! :/");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tYou typed something that is not a number !!! :(");
                                Console.ReadKey();
                            }
                        } while (!checkNum);
                        #endregion

                        #region "Typing and Checking 2º Number"
                        do
                        {
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t2º number: ");
                            Console.SetCursorPosition(37, 15);
                            checkNum = int.TryParse(Console.ReadLine(), out num2);

                            if (checkNum)
                            {
                                if (num2 > 9 || num2 < 0)
                                {
                                    checkNum = false;
                                    Console.Clear();
                                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tThe number must be between 0 to 9 ! :/");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tYou typed something that is not a number !!! :(");
                                Console.ReadKey();
                            }

                        } while (!checkNum);
                        #endregion

                        #region "Typing and Checking 3º Number"
                        do
                        {
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t3º number: ");
                            Console.SetCursorPosition(37, 20);
                            checkNum = int.TryParse(Console.ReadLine(), out num3);

                            if (checkNum)
                            {
                                if (num3 > 9 || num3 < 0)
                                {
                                    checkNum = false;
                                    Console.Clear();
                                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tThe number must be between 0 to 9 ! :/");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tYou typed something that is not a number !!! :(");
                                Console.ReadKey();
                            }

                        } while (!checkNum);
                        #endregion

                        #region "Checking Right Numbers"

                        int checkRights = 0;
                        if (code1 == num1 || code1 == num2 || code1 == num3)
                        {
                            checkRights++;
                        }

                        if (code2 == num1 || code2 == num2 || code2 == num3)
                        {
                            checkRights++;
                        }

                        if (code3 == num1 || code3 == num2 || code3 == num3)
                        {
                            checkRights++;
                        }

                        #endregion

                        #region "Checking Order"

                        int checkOrder = 0;
                        if (code1 == num1)
                        {
                            checkOrder++;
                        }

                        if (code2 == num2)
                        {
                            checkOrder++;
                        }

                        if (code3 == num3)
                        {
                            checkOrder++;
                        }


                        #endregion

                        #region "Results"
                        if (checkRights == 3 && checkOrder == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tCONGRATULATIONS!!!");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYou find out the password!!! :D");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tPassword: " + code1 + code2 + code3);
                            checkProgram = true;
                            Console.ReadKey();
                            break;
                        }

                        if (i == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYour chances are over!!!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\r\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tYOU LOSE :´(");
                            Console.SetCursorPosition(37, 15);
                            Console.ReadKey();
                            checkProgram = false;
                            break;

                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYou' ve typed a wrong sequence...");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tBut You HITTED {0} numbers !!!", checkRights);
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tAnd {0} of them on the RIGHT SEQUENCE !!!", checkOrder);
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYou have " + i + " CHANCES to go... Try Again!!! :D");
                            checkProgram = false;
                            Console.ReadKey();

                        }


                        #endregion

                    }

                    break;
                #endregion

                #region "Dificulty 3 - Hard"
                case 3:
                    for (int i = 4; i > -1; i--)
                    {
                        #region "Typing and Checking 1º Number"
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\tThe Vault has a sequence of  Three numbers that goes from 0 to 9");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tType the sequence to the Vault: ");

                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t1º number: ");
                            Console.SetCursorPosition(37, 10);
                            checkNum = int.TryParse(Console.ReadLine(), out num1);

                            if (checkNum)
                            {
                                if (num1 > 9 || num1 < 0)
                                {
                                    checkNum = false;
                                    Console.Clear();
                                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tThe number must be between 0 to 9 ! :/");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tYou typed something that is not a number !!! :(");
                                Console.ReadKey();
                            }
                        } while (!checkNum);
                        #endregion

                        #region "Typing and Checking 2º Number"
                        do
                        {
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t2º number: ");
                            Console.SetCursorPosition(37, 15);
                            checkNum = int.TryParse(Console.ReadLine(), out num2);

                            if (checkNum)
                            {
                                if (num2 > 9 || num2 < 0)
                                {
                                    checkNum = false;
                                    Console.Clear();
                                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tThe number must be between 0 to 9 ! :/");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tYou typed something that is not a number !!! :(");
                                Console.ReadKey();
                            }

                        } while (!checkNum);
                        #endregion

                        #region "Typing and Checking 3º Number"
                        do
                        {
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t3º number: ");
                            Console.SetCursorPosition(37, 20);
                            checkNum = int.TryParse(Console.ReadLine(), out num3);

                            if (checkNum)
                            {
                                if (num3 > 9 || num3 < 0)
                                {
                                    checkNum = false;
                                    Console.Clear();
                                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tThe number must be between 0 to 9 ! :/");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\tYou typed something that is not a number !!! :(");
                                Console.ReadKey();
                            }

                        } while (!checkNum);
                        #endregion

                        #region "Checking Right Numbers"

                        int checkRights = 0;
                        if (code1 == num1 || code1 == num2 || code1 == num3)
                        {
                            checkRights++;
                        }

                        if (code2 == num1 || code2 == num2 || code2 == num3)
                        {
                            checkRights++;
                        }

                        if (code3 == num1 || code3 == num2 || code3 == num3)
                        {
                            checkRights++;
                        }

                        #endregion

                        #region "Checking Order"

                        int checkOrder = 0;
                        if (code1 == num1)
                        {
                            checkOrder++;
                        }

                        if (code2 == num2)
                        {
                            checkOrder++;
                        }

                        if (code3 == num3)
                        {
                            checkOrder++;
                        }


                        #endregion

                        #region "Results"
                        if (checkRights == 3 && checkOrder == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tCONGRATULATIONS!!!");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYou find out the password!!! :D");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tPassword: " + code1 + code2 + code3);
                            checkProgram = true;
                            Console.ReadKey();
                            break;
                        }

                        if (i == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYour chances are over!!!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("\r\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tYOU LOSE :´(");
                            Console.SetCursorPosition(37, 15);
                            Console.ReadKey();
                            checkProgram = false;
                            break;

                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYou' ve typed a wrong sequence...");
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tBut You HITTED {0} numbers !!!", checkRights);
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tAnd {0} of them on the RIGHT SEQUENCE !!!", checkOrder);
                            Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tYou have " + i + " CHANCES to go... Try Again!!! :D");
                            checkProgram = false;
                            Console.ReadKey();

                        }


                        #endregion

                    }

                    break;
                #endregion

                default:
                    Console.Clear();
                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tInvalid Option!");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\tTry Again! :)");
                    Console.ReadKey();
                    checkProgram = false;
                    break;

                case 0:
                    Console.Clear();
                    Console.SetCursorPosition(37, 10);
                    Console.WriteLine("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tGame finalized, byeee!! >.<");
                    Console.SetCursorPosition(37, 15);
                    Console.ReadKey();
                    checkProgram = true;
                    break;
            
            }
            
        }
    }
}