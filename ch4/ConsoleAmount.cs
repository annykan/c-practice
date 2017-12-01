using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ch4
{
    public class ConsoleAmount
    {
        public static void consoleamount()
        {
            double [][] amt = new double [3][];
            amt[0] = new double[] { 1100, 2200, 3300 };
            amt[1] = new double[] { 1500, 2500 };
            amt[2] = new double[] { 1000, 2000, 3000, 4000 };
            
            int i, j;
            string[] company = new string[] { "台北", "台中", "高雄" };
            double [] x = new double[] { 0.0, 0.0, 0.0 };
            double total = 0;
            Console.WriteLine("\t 第一處\t 第二處\t 第三處\t 第四處\t (單位:千元)");
            for (i = 0; i < amt.Length; i++)
            {
                Console.WriteLine();
                {
                    for (j = 0; j < amt[i].Length; j++)
                    {

                        Console.Write("\t {0}", amt[i][j]);
                        x[i] += amt[i][j];
                    }
                }
            }

            Console.WriteLine();
            for (int n=0; n<3; n++)
            {
                x[n] *= 1000;
                total += x[n];
                Console.WriteLine("{0}分公司營業額:{1}元\t營業率: {2:p}",company[n], x[n].ToString("c"), x[n]/total);
            }

            Console.WriteLine("\n總營業額:{0}元" , total.ToString("c"));
            Console.Read();
        }
        

    }
}