using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4HW
{
    class Ch4HW01
    {
        static int GetMax(int x, int y)        
        {
            if (x > y)
                return x;
            else
                return y;
        }

        static int GetMax(int x, int y, int z)     
        {
            if (x > y && x > z)
                return x;
            else
            {
                if (y > x && y > z)
                    return y;
                else
                    return z;
            }
           
        }

        static int GetMax(ref int[] ary)	//以陣列當引數傳遞為參考呼叫
        {
            int i, max;
            max = ary[0];       		// 先假設陣列第一個元素為最大值
            // 使用 迴圈逐一尋找陣列元素中的最大值
            for (i = 1; i <= ary.GetUpperBound(0); i++)
            {
                if (max < ary[i])
                {
                    max = ary[i];
                }
            }
            return max;  // 傳回陣列元素中的最大值
        }

        public static void ch4hw01()
        {
            Console.WriteLine("1. 95 和 69 二數的最大數是 : {0}", GetMax(95,69));
            Console.WriteLine("2. 80, 95, 76 三數中的最大數是: {0}", GetMax(80,95,76));

            int[] ary = new int[5] { 50, 95, 168, 125, 6 };
            Console.WriteLine("3. 50, 95, 168, 125, 6 中最大數是 : {0}",GetMax(ref ary));

            Console.Read();
        }
    }
}