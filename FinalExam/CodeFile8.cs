using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class CodeFile8
    {
        public static void codefile8()
        {

            int[,,] myArray = new int[4, 2, 3];
            int sum = 0;
            int n = 1;
            
            int i; 
            for (i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k<3; k++)
                    {
                        myArray[i, j, k] = n;
                        n = n + 1;
                        sum = sum + n;

                    }

                }

              
            }
            Console.WriteLine("總合為: {0} " , sum);
            Console.Read();
        }
    }
}