using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_LargestIn_TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter the number1 : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number2 :");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} is large number ", a);
            }
            else
            {
                Console.WriteLine("{0} is large number", b);
            }
            Console.ReadLine();
        }
    }
}
