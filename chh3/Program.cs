using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                string input = "";
                Console.WriteLine("1. ConsoleBreakContinue");
                Console.WriteLine("2. ConsolDoWhile");
                Console.WriteLine("3. ConsoleDoFor1");
                Console.WriteLine("4. ConsoleGuessNo");
                Console.WriteLine("5. ConsoleIfElse1");
                Console.WriteLine("6. ConsoleIfElse2");
                Console.WriteLine("7. ConsoleIfElse3");
                Console.WriteLine("8. ConsoleNextFor1");
                Console.WriteLine("9. ConsolNum");
                Console.WriteLine("======================");
                Console.Write("請輸入要執行的範例 :");
                input = Console.ReadLine();
               
                switch (input)
                {
                    case "0":
                        flag = false;
                        break;
                    case "1":
                        ConsoleBreakContinue.consolebreakcontinue();
                        break;
                    case "2":
                        ConsoleDoWhile.consoledowhile();
                        break;
                    case "3":
                        ConsoleFor1.consolefor1();
                        break;
                    case "4":
                        ConsoleGuessNo.consoleguessno();
                        break;
                    case "5":
                        ConsoleIfElse1.consoleifelse1();
                        break;
                    case "6":
                        ConsoleIfElse2.consoleifelse2();
                        break;
                    case "7":
                        ConsoleIfElse3.consoleifelse3();
                        break;
                    case "8":
                        ConsoleNextFor1.consolenextfor1();
                        break;
                    case "9":
                        ConsoleNum.consolenum();
                        break;
                    case "10":
                        ConsoleSwitch1.consoleswitch1();
                        break;
                    case "11":
                        ConsoleTenary.consoletenary();
                        break;
                    case "12":
                        ConsoleTest.consoletest();
                        break;
                    case "13":
                        ConsoleWhile1.consolewhile1();
                        break;

                }
            }
        }
    }
}

