using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4HW
{
    public class Ch4HW06
    {
        public static void ch4hw06()
        {
            Console.Clear();
            Console.Write("求質數,請輸入一個二位整數 : ");
            int n = int.Parse(Console.ReadLine());
            int[] prime = new int[n];
            int i, j;
            for (i = 1; i <= n; i++)
            {
                prime[i-1] = i;
            }
            for (i = 2; i*i <=n; i++)
            {
                for (j=2*i; j <= n; j++)
                {
                    if (j % i == 0)
                        prime[j - 1] = 0;
                }
            }
            
            for (i=0; i < n; i++)
            {
                if (prime[i] > 0)
                    Console.Write(prime[i] + "\t");
            }
            Console.Read();

        }
    }
}