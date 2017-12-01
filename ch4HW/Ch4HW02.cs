using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	

namespace ch4HW
{
    public class Ch4HW02
    {
        public static void ch4hw02()
        {
            Console.Clear();
            string[] Supperstar = new string[] { "周華健", "蔡依林", "張學友", "劉德華" };
            int[,] Praise = new int[4, 3] { { 650, 478, 111 }, { 14, 23, 58 }, { 503, 700, 65 }, { 124, 68, 663 } };
            Console.WriteLine("姓名\t\t第一區\t第二區\t第三區\t總票數");
            Console.WriteLine("================================================");
            int i = 0;
            float  x = 0;
            for (i = 0; i <= Supperstar.GetUpperBound(0); i++)
            {
                Console.WriteLine(Supperstar[i] + "\t\t" + Praise[i, 0].ToString("#,#") + "\t" + Praise[i, 1].ToString("#,#") + "\t"
                    + Praise[i, 2].ToString("#,#") + "\t" + (Praise[i, 0] + Praise[i, 1] + Praise[i, 2]).ToString("#,#"));
                x = x + (Praise[i, 0] + Praise[i, 1] + Praise[i, 2]);
            }
            Console.WriteLine();
            for (i=0; i<= Supperstar.GetUpperBound(0); i++)
            {
                Console.WriteLine(Supperstar[i]+ "\t" + "得票率 : " + ((Praise[i, 0] + Praise[i, 1] + Praise[i, 2])/ x).ToString("0.00"));
            }
            Console.Read();
        }
    }
}