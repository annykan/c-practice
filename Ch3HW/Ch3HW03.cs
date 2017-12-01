using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 撰寫一程式，可由鍵盤輸入氣溫，若在20~22度之間，顯示出:請加一件薄外套! ，若在14~19度之間，顯示出:天氣冷, 請穿上外套!：*/
namespace Ch3HW
{
    public class Ch3HW03
    {
        public static void ch3hw03()
        {
            int cdegree = 0;
            Console.Write(" 請輸入攝氏溫度 :  ");
            cdegree = int.Parse(Console.ReadLine());
            if (cdegree >= 14 && cdegree <= 19)
                Console.WriteLine(" 天氣冷請穿上外套 ! ");
            if (cdegree >= 20 && cdegree <= 22)
                Console.WriteLine(" 請加一件薄外套 ! ");

            Console.Read();
        }
    }
}