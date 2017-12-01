using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*12.	試利用巢狀for迴圈印出九九乘法表。*/
namespace FinalExam
{
    public class CodeFile3
    {
        public static void codefile3()
        {
            int x = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    x = i * j;
                    Console.Write("\t" + j.ToString("##") + "*" + i.ToString("##") + "=" + x.ToString("##"));
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}