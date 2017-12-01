using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4.	珍珠奶茶與烏龍拿鐵分別為45與55元, 請先詢問客人各需要買幾瓶, 當珍珠奶茶與烏龍拿鐵購買總數超過15瓶, 並且總額達(含) 800元, 售價享有9折優惠：*/
namespace Ch3HW
{
    public class Ch3HW04
    {
        public static void ch3hw04()
        {
            int x = 0, y = 0;
            double z = 0;
            Console.Write("珍珠奶茶數量:");
            x = int.Parse(Console.ReadLine());
            Console.Write("\n烏龍拿鐵數量:");
            y = int.Parse(Console.ReadLine());
            z = (x * 45) + (y * 55);
            if (x + y > 15 && z >= 800)
            {
                z = z * 0.9;
                Console.WriteLine("九折優惠共 :" + z.ToString("####") + " 元");
            }
            else
                Console.WriteLine("共 :" + z.ToString("####") + "元");
            Console.Read();



        }
    }
}