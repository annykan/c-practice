using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
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
                Console.WriteLine("1. 指定主程序可使用參數任意個後, 然後使用 Bubble sort 作排序由小至大; ");
                Console.WriteLine("2. 指定主程序可使用參數任意個後, 然後輸入欲搜尋的元素後,使用 Binary Search 尋找該元素,找到後傳回該索引值");
                Console.WriteLine("3. 二維陣列九九乘法表 ");
                Console.WriteLine("4. 印出可任意輸入字元的聖誕樹");
                Console.WriteLine("5. 請寫出一個 C# 函數 int product(int n) 以計算 n! 的值 (也就是 1*2*…*n 的值)。");
                Console.WriteLine("6. 設f(x)=3x+2x-1,試寫一函數 double f(double x),用來傳回 f(x) 的值，並於主程式裡分別計算f(-3.2), f(-2.1), f(0)與f(2.1)。");
                Console.WriteLine("7. 指定主程序可使用參數任意個後,可以傳回該鎮中當中最大的值。");
                Console.WriteLine("8. 試設陣列A的維度為4×2×3，請在程式碼裡宣告此一陣列，並在宣告同時設定初值(1~24)，然後計算陣列A內所有元素的總和。");
                Console.WriteLine("9. 撰寫int mod(int x, int y) 函數，計算x / y的餘數。並利用此函數來計算mod(17, 5)，即計算17/5 的餘數。");
                Console.WriteLine("10. 請試撰寫一程式，由鍵盤輸入一字串後，分別計算該字串出現a、e、i、o、u的次數。");
                Console.WriteLine("====================================================================");
                Console.Write("請輸入要執行的範例 :");
                input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        flag = false;
                        break;
                    case "1":
                        CodeFile1.codefile1();
                        break;
                    case "2":
                        CodeFile2.codefile2();
                        break;
                    case "3":
                        CodeFile3.codefile3();
                        break;
                    case "4":
                        CodeFile4.codefile4();
                        break;
                    case "5":
                        CodeFile5.codefile5();
                        break;
                    case "6":
                        CodeFile6.codefile6();
                        break;
                    case "7":
                        CodeFile7.codefile7();
                        break;
                    case "8":
                        CodeFile8.codefile8();
                        break;
                    case "9":
                        CodeFile9.codefile9();
                        break;
                    case "10":
                        CodeFile10.codefile10();
                        break;
                    
                }
            }
        }
    }
}