using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ch4
{
    public class ConsoleMethod1
    {
        public static void consolemethod1 ()
        {
            string name = "Jack Wu";
            Login(name, true);
            Console.WriteLine();
            Login("Mary Line", false);
            Console.Read();
            
        }
        static void Login(string username, bool gender)
        {
            Console.Write(username);
            if (gender)
                Console.WriteLine("  先生,歡迎光臨 !");
            else
                Console.WriteLine("  小姐,歡迎光臨 !");
        }
    }
}
       