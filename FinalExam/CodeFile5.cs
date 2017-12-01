using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class CodeFile5
    {
        static int product(int x)        
        {
            int sum = 1 ;
            for (int i = 1; i <= x; i++)
                sum = sum * i;
            return (sum);
        }
        

        public static void codefile5()
        {
            Console.Write("請輸入整數:");
            int x ;
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(" {0}! = {1}", x, product(x));
                        
            Console.Read();
        }
    }
}
