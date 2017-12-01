using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2.	請撰寫一程式，可由鍵盤輸入攝氏溫度，程式的輸出為華氏溫度，其轉換公式如下：
華氏溫度=1.8* 攝氏溫度+32  */

namespace Ch3HW
{
    public class Ch3HW02
    {
        public static void ch3hw02()
        {
            double cdegree = 0;
            Console.Write(" 請輸入攝氏溫度 :  ");
            cdegree = Convert.ToDouble((Console.ReadLine())) * 1.8 + 32;
            Console.WriteLine(" 華氏溫度為 : " + cdegree.ToString("#.##"));
            Console.Read();

        }
    }
}