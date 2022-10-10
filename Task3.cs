using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
             int a;
            int b;
            int s;
            Console.WriteLine("Enter Your First Number:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your 2nd Number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("The Total Sume is:");
            s=a+b;
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
