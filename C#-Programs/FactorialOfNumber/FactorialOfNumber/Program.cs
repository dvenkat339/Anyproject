using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;

            Console.WriteLine("Enter a Value :");

            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                fact = fact * i;
               
            }
            Console.WriteLine("Factorial of {1}  is {0}", fact, num);
            Console.ReadLine();
        }
    }
}
