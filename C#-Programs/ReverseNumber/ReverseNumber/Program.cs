using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");

            //int num = Convert.ToInt32(Console.ReadLine());
            //int result = 0;

            //while (num != 0)
            //{
            //    int rem = num % 10;
            //    result = result * 10 + rem;
            //    num = num / 10;
            //}
            //Console.WriteLine("Reverse of a given number is {0}", result);
            //Console.ReadLine();

            B ob = new B();
            ob.name = "Venkat";
            ob.address = "Hyderabad";
            Console.WriteLine(ob.name);
            Console.WriteLine(ob.address);
           


            B obj = new A();
            A ojj = new A();
            ojj.name = "Venkat";
            ojj.address = "Hyderabad";

            A ojd = new B();
            ojd.name = "Venkat";
            ojd.address = "Hyderabad";
            Console.WriteLine(ojd.name);
            Console.WriteLine(ojd.address);
            Console.ReadLine();
        }
    }
    public class A
    {
        public string name;
        
    }
    public class B:A
    {
        public string address;

    }
}
