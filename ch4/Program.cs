using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Program
    {
        static public int len;
        static public string[] arr;
        static void Main(string[] args)
        {
            len = args.Length;
            arr = new string[len];
            arr = args;
            bool flag = true;

            while (flag)
            {
                Console.Clear();
                string input = "";
                Console.WriteLine("1. ConsoleAry");
                Console.WriteLine("2. ConsoleAryForEach2");
                Console.WriteLine("3. ConsoleForEach1");
                Console.WriteLine("4. ConsoleAmount");
                Console.WriteLine("5. ConsoleMethod1");
                Console.WriteLine("6. ConsoleMethod2");
                Console.WriteLine("7. ConsoleMethod3");
                Console.WriteLine("8. ConsoleMethod4");
                Console.WriteLine("9. ConsoleByVal");
                Console.WriteLine("10. ConsoleByRef");
                Console.WriteLine("11. ConsoleOut");
                Console.WriteLine("12. ConsoleGetMax");
                Console.WriteLine("13. ConsoleOverLoads");
                Console.WriteLine("14. ConsoleStaticVar");
                Console.WriteLine("66. text");
                Console.WriteLine("======================");
                Console.Write("請輸入要執行的範例 :");
                input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        flag = false;
                        break;
                    case "1":
                        ConsoleAry.consoleary();
                        break;
                    case "2":
                        ConsoleAryForEach2.consolearyforeach2();
                        break;
                    case "3":
                        ConsoleForEach1.consoleforeach1();
                        break;
                    case "4":
                        ConsoleAmount.consoleamount();
                        break;
                    case "5":
                        ConsoleMethod1.consolemethod1();
                        break;
                    case "6":
                        ConsoleMethod2.consolemethod2();
                        break;
                    case "7":
                        ConsoleMethod3.consolemethod3();
                        break;
                    case "8":
                        ConsoleMethod4.consolemethod4();
                        break;
                    case "9":
                        ConsoleByVal.consolebyval();
                        break;
                    case "10":
                        ConsoleByRef.consolebyref();
                        break;
                    case "11":
                        ConsoleOutput.consoleoutput();
                        break;
                    case "12":
                        ConsoleGetMax.consolegetmax();
                        break;
                    case "13":
                        ConsoleOverLoads.consoleoverloads();
                        break;
                    case "14":
                        ConsoleStaticVar.consolestaticvar();
                        break;
                    case "66":
                        Test.test();
                        break;


                }
            }
        }
    }
}