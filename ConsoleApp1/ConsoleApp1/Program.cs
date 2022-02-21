using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            int sum , x, y;
            string operat;
            Console.WriteLine("Please Choice Witch Operator Want to use");
            Console.WriteLine("1- +");
            Console.WriteLine("2- -");
            Console.WriteLine("3- *");
            Console.WriteLine("4- /");
            operat = Console.ReadLine();
           
            if (operat == "1" || operat == "+" || operat == "-" || operat == "*" || operat == "/" || operat == "2" || operat == "3" || operat == "4")
            {
                Console.WriteLine("Now Please Enter The First Number");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Now Please Enter The Secound Number");
                y = Convert.ToInt32(Console.ReadLine());

                if (operat == "1" ||operat == "+")
                {
                    sum = x + y;
                    Console.WriteLine(sum);
                    Console.WriteLine("Please Press any key to exit");
                }
                else if (operat ==  "2" || operat == "-")
                {
                    sum = y - x;
                    Console.WriteLine(sum);
                    Console.WriteLine("Please Press any key to exit");
                }
                else if (operat == "3" || operat == "*")
                {
                    sum = y * x;
                    Console.WriteLine(sum);
                    Console.WriteLine("Please Press any key to exit");
                }
                else if (operat == "4" || operat == "/")
                {
                    sum = y / x;
                    Console.WriteLine(sum);
                    Console.WriteLine("Press any key to exit");
                }
            }
            else
            {
                Console.WriteLine("Sorry Please Choice a valid number, Please Try Again");
            }
           


            Console.ReadKey();
        }
    }
}
