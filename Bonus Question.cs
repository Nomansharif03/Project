using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, revStr = "";
            Console.Write("Enter A number");
            str = Console.ReadLine();
            for(int i=str.Length-1;i>=0;i++)
            {
                revStr = revStr + str[i].ToString();
            }
            if(revStr==str)
            {
                Console.WriteLine("String is a Palindrom");

            }
            else
            {
                Console.WriteLine("string is not a Palindrome");
            }
            Console.ReadLine();
        }
    }
}
