using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class CodeFile1
    {
        public static void codefile1()
        {

            
           
            int[] myArray1 = new int[Program.len];

            if (Program.len != 0)
            {
                for (int i = 0; i < Program.len; i++)
                {

                    myArray1[i] = int.Parse(Program.arr[i]);

                }
               
            }

            Array.Sort(myArray1);
                      
            for (int i = 0; i <= myArray1.GetUpperBound(0); i++)
            {
                Console.Write("\t" + myArray1[i].ToString("#,#"));
            }
           
            Console.Read();
        }
    }
}