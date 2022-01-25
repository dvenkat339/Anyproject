using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            p.SwapWithThirdVariable();
            p.SwapWithOutThirdVariable();

        }
        public void SwapWithThirdVariable()
        {
            int a, b, temp;

            Console.WriteLine("Enter A Value : \n");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter B Value : \n");
            b = Convert.ToInt32(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("A value is {0} and B value is {1}", a, b);
            //Console.WriteLine("B value is {0}", b);

            Console.ReadLine();
        }
        void SwapWithOutThirdVariable()
        {
            int a, b;

            Console.WriteLine("A values is :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B value is :");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(" A is {0}", a);
            Console.WriteLine("B Is {0}", b);

            Console.ReadLine();
        }
    }
}
