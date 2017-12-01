using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class CodeFile10
    {
        public static void codefile10()
        {
            string ss = "";
            Console.Write("請輸入字串:");
            ss = Console.ReadLine();
            int aa=0, ee=0, ii=0, oo=0, uu=0;

            for (int i = 0; i < ss.Length; i++)
            {

                switch (ss.Substring(i, 1))
                {
                    case "a":
                        aa = aa + 1;
                        break;

                    case "e":
                        ee = ee + 1;
                        break;
                    case "i":
                        ii = ii + 1;
                        break;
                    case "u":
                        uu = uu + 1;
                        break;

                    case "o":
                        oo = oo + 1;
                        break;

                    default:
                        break;
                }
            }
            Console.Write("\n 'a'的總數是{0} ", aa);
            Console.Write("\n 'e'的總數是{0} ", ee);
            Console.Write("\n 'i'的總數是{0} ", ii);
            Console.Write("\n 'o'的總數是{0} ", oo);
            Console.Write("\n 'u'的總數是{0} ", uu);
            Console.Read();


           
        }
    }
}