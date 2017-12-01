using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class CodeFile2
    {
        public static void codefile2()
        {
            int x, mid, left, right;
            mid = 0;

            int[] myArray1 = new int[Program.len];

            if (Program.len != 0)
            {
                for (int i = 0; i < Program.len; i++)
                {
                    myArray1[i] = int.Parse(Program.arr[i]);
                }
            }

            Array.Sort(myArray1);
            int loc_left = 0;
            left = myArray1[0];
            int loc_right = myArray1.GetUpperBound(0);
            right = myArray1[myArray1.GetUpperBound(0)];
            int loc_mid;
            loc_mid = (loc_left + loc_right) / 2;

            Console.Write("請輸入欲搜尋整數:");
            x = (int.Parse(Console.ReadLine()));

            Console.Write("陣列內容:");
            for (int j = 0; j <= 10; j++)
            {
                Console.Write(myArray1[j].ToString("\t#,#"));
            }
            Console.WriteLine();
            Array.Sort(myArray1);
            while (myArray1[loc_left] <= myArray1[loc_right])
            {
                loc_mid = (loc_left + loc_right) / 2;

                if (myArray1[loc_mid] == x)
                {
                    break;
                }
                else
                {
                    if (myArray1[loc_mid] > x)
                        loc_right = loc_mid;
                    else
                        loc_left = loc_mid;
                }
            }
            if (myArray1[loc_mid] == x)
            {
                Console.Write("找到了第 {0} 個位置",loc_mid);
            }


                Console.Read();
        }
    }
}
