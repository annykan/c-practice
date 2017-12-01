using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4HW
{
    public class Ch4HW05
    {
        public static void ch4hw05()
        {
            Console.Clear();
            int index = -1 , score = 0;
            Console.WriteLine("請輸入6位同學分數 :\n");
            string[] StudentName = new string[6] { "小名", "小王", "小呆", "小華", "王五", "張三" };
            int[] StudentScore = new int[6];
            int i;
            for (i = 0; i <= 5; i++)
            {
                Console.Write("請輸入第" + (i + 1).ToString("##") + "位同學"+ StudentName[i]+"的成績是:");
                StudentScore[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\n請輸入欲查詢之分數 :");
            score = int.Parse(Console.ReadLine());
            Array.Sort(StudentScore, StudentName);
            index = Array.BinarySearch(StudentScore, score);
            if (index >= 0)
                Console.WriteLine("找到了 ! " + StudentName[index] + "的分數是:" + score.ToString("###"));
            else
                Console.WriteLine("沒有人是這個成績喔 !");
                        
            Console.Read();

        }
    }
}