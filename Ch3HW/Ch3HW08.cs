using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*8.	請利用do while迴圈，計算 2+4+6+...n 的總和，其中n為正的偶數，可由鍵盤自行輸入。若輸入的不是正偶數，
 * 則程式會要求使用者再次輸入，直到輸入的數是正偶數為止。*/
namespace Ch3HW
{
    public class Ch3HW08
    {
        public static void ch3hw08()
        {
            int x = 1, total = 0;
            while (x < 0 || x % 2 != 0)
            {
                Console.Write("請輸入正偶數 :");
                x = int.Parse(Console.ReadLine());
            }
            while (x >= 2)
            {
                total = total + x;
                x = x - 2;
            }
            Console.WriteLine("總合為:" + total.ToString("####"));
            Console.Read();
        }

    }
}