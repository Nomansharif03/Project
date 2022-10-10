using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Put Your Number:");
            a = int.Parse(Console.ReadLine());
            
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is even");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Number is odd");
            Console.ReadLine();

            }
        }
    }
}
