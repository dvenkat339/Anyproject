using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Largest_InThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 80;

            if (a > b && a > c)
            {
                Console.WriteLine("a is greater");

            }else if(b>c&& b > a)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }
            Console.ReadLine();
        }
    }
}
