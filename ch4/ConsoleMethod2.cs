using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ch4
{
    public class ConsoleMethod2
    {
        public static void consolemethod2()
        {
            string name = "Jack Wu";
            string Welcome = Program1.GetWelcome(name, true);
            Console.WriteLine(Welcome);
            Console.WriteLine();
            Console.WriteLine(Program1.GetWelcome("Mary Lin", false));
            Console.Read();
        }
    }

    public class Program1
    {
        public static string GetWelcome(string username, bool ismale)
        {
            string str = "";
            if (ismale)
                Console.WriteLine(username + "  先生,歡迎光臨 !");
            else
                Console.WriteLine(username + "  小姐,歡迎光臨 !");
            return str;

        }
    }

}