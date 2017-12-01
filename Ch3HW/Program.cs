using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3HW
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
                Console.WriteLine("1.試撰寫一程式，可由鍵盤輸入一個整數，然後判斷它是奇數或偶數。");
                Console.WriteLine("2.請撰寫一程式，可由鍵盤輸入攝氏溫度，程式的輸出為華氏溫度，其轉換公式如下：華氏溫度 = 1.8 * 攝氏溫度 + 32");
                Console.WriteLine("3.試撰寫一程式，可由鍵盤輸入氣溫，若在20~22度之間，顯示出:請加一件薄外套! ，若在14~19度之間，顯示出:天氣冷, 請穿上外套!：");
                Console.WriteLine("4.珍珠奶茶與烏龍拿鐵分別為45與55元, 請先詢問客人各需要買幾瓶, 當珍珠奶茶與烏龍拿鐵購買總數超過15瓶, 並且總額達(含) 800元, 售價享有9折優惠：");
                Console.WriteLine("5.珍珠奶茶與烏龍拿鐵分別為45與55元, 請先詢問客人各需要買幾瓶, 當珍珠奶茶與烏龍拿鐵購買總數超過12瓶, 或是總額達(含) 700元, 或是珍珠奶茶購買達(含)10瓶, 售價享有95折優惠：");
                Console.WriteLine("6.請使用 For 迴圈印出下列星號");
                Console.WriteLine("7.學生成績程式。");
                Console.WriteLine("8.請利用do while迴圈，計算 的總和，其中n為正的偶數，可由鍵盤自行輸入。若輸入的不是正偶數，則程式會要求使用者再次輸入，直到輸入的數是正偶數為止。");
                Console.WriteLine("9.請由鍵盤輸入數值1~4，並加以判斷輸入值是否在1~4之間，如果超出此範圍，則印出 「輸入錯誤」，否則利用switch印出相對應的季節：");
                Console.WriteLine("10.試撰寫一程式，利用while迴圈印出5~20之間所有整數的平方值，最後再印出這些平方值的總和。");
                Console.WriteLine("11.試利用while迴圈找出最小的n值，使得 的總和大於等於1000。");
                Console.WriteLine("12.試利用巢狀for迴圈印出九九乘法表。");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.Write("請輸入要執行範例:");
                input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        flag = false;
                        break;
                    case "1":
                        Ch3HW01.ch3hw01();
                        break;
                    case "2":
                        Ch3HW02.ch3hw02();
                        break;
                    case "3":
                        Ch3HW03.ch3hw03();
                        break;
                    case "4":
                        Ch3HW04.ch3hw04();
                        break;
                    case "5":
                        Ch3HW05.ch3hw05();
                        break;
                    case "6":
                        Ch3HW06.ch3hw06();
                        break;
                    case "7":
                    //    Ch3HW07.ch3hw07();
                        break;
                    case "8":
                        Ch3HW08.ch3hw08();
                        break;
                    case "9":
                        Ch3HW09.ch3hw09();
                        break;
                    case "10":
                        Ch3HW10.ch3hw10();
                        break;
                    case "11":
                        Ch3HW11.ch3hw11();
                        break;
                    case "12":
                        Ch3HW12.ch3hw12();
                        break;


                }



            }
        }
    }
}
            

        
    

