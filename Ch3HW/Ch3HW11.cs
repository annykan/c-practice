using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11.	試利用while迴圈找出最小的n值，使得 1+2+3+...n 的總和大於等於1000。*/
namespace Ch3HW
{
    public class Ch3HW11
    {
        public static void ch3hw11()
        {
            int x = 1, sum = 0;
            while (sum <= 1000)
            {
                sum = sum + x;
                x++;
            }
            Console.WriteLine(" n = " + x.ToString("####"));
            Console.Read();


        }
    }
}