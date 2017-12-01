using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class CodeFile4
    {
        public static void codefile4()
        {
            Console.Write("請輸入欲列印符號:");
            string ss;
            int y_count = 6;
            int x_count = 1;
            ss = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int y = y_count; y >= 1; y--)
                    Console.Write(" ");

                for (int x = 1; x <= x_count; x++)
                    Console.Write("{0}", ss);
                for (int z = y_count; z >= 1; z--)
                    Console.Write(" ");

                Console.WriteLine();
                x_count = x_count + 2;
                y_count = y_count - 1;
            }
            Console.Read();
        }
    }
}