using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ch4HW
{
    public class Ch4HW07
    {
        public static void ch4hw07()
        {
            Console.Clear();
            string[] StudentName = new string[6] { "小明", "小王", "小呆", "小華", "王五", "張三" };
            int[] StudentScore = new int[6] { 100, 95, 87, 92, 88, 65 };
            Console.Write("請輸入欲查詢學生姓名 :");
            string NAME = Console.ReadLine();
           // Action<string[],int[], string> MYACTION = new Action<string[], int[], string>(SEARCHSCORE);

             SEARCHSCORE(StudentName, StudentScore, NAME);

            // MYACTION (StudentName,StudentScore, NAME);
            Console.Read();
        }
        private static void SEARCHSCORE(string[] AAA, int[] BBB,string name)
        {
            int i; 
            for (i = 0; i <= AAA.GetUpperBound(0); i++)
            {
                if (AAA[i] == name)
                    Console.WriteLine("\n 找到了,第" + (i + 1) + "位學生" + name + "的成績是:" + BBB[i].ToString("###"));
                
            }
        }

    }
}