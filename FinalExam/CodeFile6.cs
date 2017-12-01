using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class CodeFile6
    {
        static double dd(double x)
        {
            double sum = 0;
            sum = (3 * x * x * x) + (2 * x) - 1;
            return (sum);
        }


        public static void codefile6()
        {
            Console.WriteLine("1. f(-3.2) = {0}", dd(-3.2));
            Console.WriteLine("2. f(-2.1) = {0}", dd(-2.1));
            Console.WriteLine("2. f(2.1) = {0}", dd(2.1));
            Console.Read();
        }
    }
}