using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 150, 300, 400, 350, 450, 550, 600 };
            for (int i = 0; i < list.Count ;i++)
            {
                Console.WriteLine(i);
            }

            
            int max_num = list.AsQueryable().Max();
            Console.WriteLine("Largest number = {0}", max_num);

            Console.ReadLine();
        }
    }
}
