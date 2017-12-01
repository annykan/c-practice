using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program { 
        
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                string input = "";
                Console.WriteLine("0.離開");
                Console.WriteLine("1.EmptyClass");
                Console.WriteLine("2.");
                Console.WriteLine("3.");
                Console.WriteLine("4.");
                Console.WriteLine("5.");
                Console.WriteLine("6.");
                Console.WriteLine("7.");

                Console.WriteLine("--------------------------------------------------------------------------");
                Console.Write("請輸入要執行範例:");
                input = Console.ReadLine();
                Console.WriteLine();
                switch (input)
                {
                    case "0":
                        flag = false;
                        break;
                    case "1":
                        EmptyClass.emptyClass();
                        break;
                    case "2":
                        
                        break;
                    case "3":
                       
                        break;
                    case "4":
                        
                        break;
                    case "5":
                       
                        break;
                    case "6":
                        
                        break;
                    case "7":
                        
                        break;



                }



            }
        }
    }
}
