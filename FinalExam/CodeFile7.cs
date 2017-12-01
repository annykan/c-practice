using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class CodeFile7
    {
        static int GetMax(ref int[] ary)	
        {
            int i, max;
            max = ary[0];       		
          
            for (i = 1; i <= ary.GetUpperBound(0); i++)
            {
                if (max < ary[i])
                {
                    max = ary[i];
                }
            }
            return max; 
        }

        public static void codefile7()
        {
            int[] myArray1 = new int[Program.len];

            if (Program.len != 0)
            {
                for (int j = 0; j < Program.len; j++)
                {
                    myArray1[j] = int.Parse(Program.arr[j]);

                }

            }
            
            Console.WriteLine("\n == 陣列元素如下 ==\n");
            int i;
            for (i = 0; i <= myArray1.GetUpperBound(0); i++)
            {
                Console.Write("  {0} ", myArray1[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("  陣列最大值：{0}", GetMax(ref myArray1));
            Console.Read();
        }
    }
}