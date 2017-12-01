using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	試撰寫一程式，可由鍵盤輸入一個整數，然後判斷它是奇數或偶數。

namespace Ch3HW
{
    public class Ch3HW01
    {
        public static void ch3hw01() { 
            int var1;
            Console.Write("請輸入整數:");
            var1 = (int.Parse(Console.ReadLine()));
            if (var1 % 2 == 0)
                Console.WriteLine(var1 + "  是偶數 !");
            else
                Console.WriteLine(var1 + "  是奇數 !");
            Console.Read();
        }
    }
}