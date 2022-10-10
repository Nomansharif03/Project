using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int[] list = { 10, 20, 30, 40, 50, 60, 70 };
            for(int i=0; i < list.Length; i=i + 2)
            {
                Console.WriteLine(list[i]);

            }
            Console.ReadLine();
        }
    }
}
