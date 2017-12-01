using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*9.	請由鍵盤輸入數值1~4，並加以判斷輸入值是否在1~4之間，如果超出此範圍，則印出 "輸入錯誤"，
 * 否則利用switch印出相對應的季節：1：春天 2：夏天 3：秋天 4：冬天 */

namespace Ch3HW
{
    public class Ch3HW09
    {
        public static void ch3hw09()
        {
            int x = 0;
            while (x < 1 || x >= 4)
            {
                Console.Write("請輸入1~4 數字 :");
                x = int.Parse(Console.ReadLine());
            }
            switch (x)
            {
                case 1: Console.Write("春天"); break;
                case 2: Console.Write("夏天"); break;
                case 3: Console.Write("秋天"); break;
                case 4: Console.Write("冬天"); break;
            }
            Console.Read();

        }
    }
}
