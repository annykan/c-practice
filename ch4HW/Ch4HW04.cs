using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4HW
{
    public class Ch4HW04
    {
        public static void ch4hw04()
        {
            Console.Clear();
            Console.WriteLine("請輸入10個整數到陣列 :\n");
            int[] x = new int[10];
            int i;
            for (i=0; i<=9; i++)
            {
                Console.Write("請輸入第" + (i+1).ToString("##") + "個整數 :");
                x[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(x);
            Console.WriteLine("輸入資料由小到大做遞增排序 :");

            Action<int> myAction = new Action<int>(showArray);
            Array.ForEach(x, myAction);
            Console.Read();
           
            void showArray(int r)
            {
                Console.Write(r.ToString("##,##")+"\t");
            }

            



        }
    }
}