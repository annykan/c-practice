using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5.	珍珠奶茶與烏龍拿鐵分別為45與55元, 請先詢問客人各需要買幾瓶, 當珍珠奶茶與烏龍拿鐵購買總數超過12瓶, 或是總額達(含) 700元, 或是珍珠奶茶購買達(含)10瓶, 售價享有95折優惠：*/
namespace Ch3HW
{
    public class Ch3HW05
    {
        public static void ch3hw05()
        {
            int x = 0, y = 0;
            double z = 0;
            Console.Write("珍珠奶茶數量:");
            x = int.Parse(Console.ReadLine());
            Console.Write("\n烏龍拿鐵數量:");
            y = int.Parse(Console.ReadLine());
            z = (x * 45) + (y * 55);
            if (x + y > 12 || z >= 700 || x >= 10)
            {
                z = z * 0.95;
                Console.WriteLine("九五折優惠共 :" + z.ToString("####") + " 元");
            }
            else
                Console.WriteLine("共 :" + z.ToString("####") + "元");
            Console.Read();



        }
    }
}

