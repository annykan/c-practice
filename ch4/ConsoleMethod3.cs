using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ch4
{
    class class1
    {
        public static string GetWelcome(string username, bool ismale)
        {
            string str = "";
            if (ismale)
                str = username + "  先生,歡迎光臨 !";
            else
                str = username + "  小姐,歡迎光臨 !";
            return str;

        }
    }

    class ConsoleMethod3
    {
        public static void consolemethod3()
        {
            string name = "Jack Wu";
            string Welcome = class1.GetWelcome(name, true);
            Console.WriteLine(Welcome);
            Console.WriteLine();
            Console.WriteLine(class1.GetWelcome("Mary Lin", false));
            Console.Read();
        }
    }
      
}