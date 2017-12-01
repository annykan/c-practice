using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	

namespace ch4HW
{
    public class Ch4HW03
    {
        public static void ch4hw03()
        {
            Console.Clear();
            int[] x = new int[5];
            Console.WriteLine("請輸入五個整數: \n");
            int i;
            for (i=0; i<5; i++)
            {
                Console.Write("請輸入第" + (i+1).ToString("#") + "個整數:");
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Array.Sort(x);
            Console.WriteLine("最小數:" + x[0].ToString("##"));
            Console.WriteLine("最大數:" + x[4].ToString("##"));
            Console.Read();

            
            
        }
    }
}