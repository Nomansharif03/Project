using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int s;
            Console.WriteLine("Put a Number");
            a = int.Parse(Console.ReadLine());
            for(int i=1;i<=12;i++)
            {
                s=i*a;
                Console.WriteLine(s);
                
            }
                Console.ReadLine();

        }
    }
}
