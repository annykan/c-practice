using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2
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
                Console.WriteLine("1. myFirst");
                Console.WriteLine("2. ConsoleEnum1");
                Console.WriteLine("3. ConsoleEscSeq");
                Console.WriteLine("4. ConsoleEx1");
                Console.WriteLine("5. ConsoleFormat");
                Console.WriteLine("6. ConsoleShift");
                Console.WriteLine("7. ConsoleStruct1");
                Console.WriteLine("8. ConsoleToString");
                Console.WriteLine("9. ConsoleMyCSharp");
                Console.WriteLine("======================");
                Console.Write("請輸入要執行的範例 :");
                input = Console.ReadLine();
                switch(input)
                {
                    case "0":
                        flag = false;
                        break;
                    case "1":
                        CodeFile1.codefile1();
                        break;
                    case "2":
                        ConsoleEnum1.consoleenum1();
                        break;
                    case "3":
                        ConsoleEscSeq.Consoleescseq();
                        break;
                    case "4":
                        ConsoleEx1.consoleex1();
                            break;
                    case "5":
                        ConsoleFormat.consoleformat();
                        break;
                    case "6":
                        ConsoleShift.consoleshift();
                        break;
                    case "7":
                        ConsoleStruct1.consolestruct1();
                        break;
                    case "8":
                        ConsoleToString.consoletostring();
                        break;
                    

                }
            }
        }
    }
}
