using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            b = 0;
            Console.WriteLine("Put a number to check");
            a = int.Parse(Console.ReadLine());
            int[] List = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < List.Length; i++)
            {
                if (a == List[i])
                    b++;

            }
            if (b > 0)
            {
                Console.WriteLine("Number is in the list");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Number is not in the list");
                Console.ReadLine();
            }
        }
    }
}