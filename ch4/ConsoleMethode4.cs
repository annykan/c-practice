using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ch4
{
    class class2
    {
        public string GetWelcome(string username, bool ismale)
        {
            string str = "";
            if (ismale)
                str = username + "  先生,歡迎光臨 !";
            else
                str = username + "  小姐,歡迎光臨 !";
            return str;

        }
    }

    class ConsoleMethod4
    {
        public static void consolemethod4()
        {
            string name = "Jack Wu";
            class2 myclass = new class2();

            string Welcome = myclass.GetWelcome(name, true);
            Console.WriteLine(Welcome);
            Console.WriteLine();
            Console.WriteLine(myclass.GetWelcome("Mary Lin", false));
            Console.Read();
        }
    }

}