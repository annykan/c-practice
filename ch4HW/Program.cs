using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4HW
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
                Console.WriteLine("0.離開");
                Console.WriteLine("1.建立三個GetMax多載方法,可用來傳回二數最大值,傳回三數最大值,傳回陣列中的最大數");
                Console.WriteLine("2.透過二維陣列顯示四位明星在三個區域的得票數,並算出每位明星的得票數");
                Console.WriteLine("3.由鍵盤輸入5個整數並存放到整數陣列中,然後再取出陣列內的最大樹和最小數");
                Console.WriteLine("4.建立一個長度為10的一維陣列,可以供使用者輸入10個數字後,並由小到大排序輸出");
                Console.WriteLine("5.建立二個長度同為6的陣列,一個陣列內容為姓名,另一個陣列內容為分數,使用者輸入" +
                    "分數後,可以查詢分數");
                Console.WriteLine("6.輸入一值 N,印出1~N之間的質數");
                Console.WriteLine("7.撰寫一個方法擁有搜尋陣列中資料的功能,呼叫方法時並傳入一個陣列,以及欲搜尋的資料。" +
                    "搜尋結束即印出相關訊息.");
                
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.Write("請輸入要執行範例:");
                input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        flag = false;
                        break;
                    case "1":
                        Ch4HW01.ch4hw01();
                        break;
                    case "2":
                        Ch4HW02.ch4hw02();
                        break;
                    case "3":
                        Ch4HW03.ch4hw03();
                        break;
                    case "4":
                        Ch4HW04.ch4hw04();
                        break;
                    case "5":
                        Ch4HW05.ch4hw05();
                        break;
                    case "6":
                        Ch4HW06.ch4hw06();
                        break;
                    case "7":
                        Ch4HW07.ch4hw07();
                        break;



                }



            }
        }
    }
}
