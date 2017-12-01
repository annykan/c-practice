using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*10.	試撰寫一程式，利用while迴圈印出5~20之間所有整數的平方值，最後再印出這些平方值的總和。*/
namespace Ch3HW
{
    public class Ch3HW10
    {
        public static void ch3hw10()
        {
            int x = 5, y = 0, sum = 0;
            while (x <= 20)
            {
                y = x * x;
                sum = sum + y;
                Console.Write(y.ToString("######") + "   ");
                x++;
            }
            Console.Write("\n平方值總和:" + sum.ToString("######"));
            Console.Read();

        }
    }
}
