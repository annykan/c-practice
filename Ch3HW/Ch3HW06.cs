using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3HW
{
    public class Ch3HW06
    {
        public static void ch3hw06()
        {
            int star_count = 1;
            int space_count = 6;

            for (int i = 1; i <= 7; i++)        // 外層迴圈
            {
                for (int space = space_count; space >= 1; space = space - 1)
                {
                    Console.Write("{0}", " ");
                }
                for (int star = 1; star <= star_count; star++)
                {
                    Console.Write("{0}", "*", star);
                }
                space_count = space_count - 1;
                Console.WriteLine();
                star_count = star_count + 1;
            }
            Console.Read();

            //star 2
            for (int x = 1; x <= 7; x++)
            {
                for (int i = 1; i <= x; i++)        // 外層迴圈
                    Console.Write("{0}", "*");

                Console.WriteLine();
            }
            Console.Read();

            //star3
            for (int x = 7; x >= 1; x--)
            {
                for (int i = x; i >= 1; i--)
                    Console.Write("{0}", "*");

                Console.WriteLine();
            }
            Console.Read();

            //star4
            int x_count = 7;
            int y_count = 0;
            for (int i = 7; i >= 1; i--)
            {
                for (int y = 1; y <= y_count; y++)
                    Console.Write(" ");
                for (int x = x_count; x >= 1; x--)
                    Console.Write("{0}", "*");

                Console.WriteLine();
                x_count = x_count - 1;
                y_count = y_count + 1;
            }
            Console.Read();

            //star5
           // int x_count = 1;
           // int y_count = 6;
            for (int i = 1; i <= 7; i++)
            {
                for (int y = y_count; y >= 1; y--)
                    Console.Write(" ");

                for (int x = 1; x <= x_count; x++)
                    Console.Write("{0}", "*");
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