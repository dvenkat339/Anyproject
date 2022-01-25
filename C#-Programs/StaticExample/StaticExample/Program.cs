using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    class Program
    {
        static class User
        {
            public static string Name;
            public static string Address;

            public static void Details()
            {
                 string a = "Hello 123";
                 string b = "Hi";
              Console.WriteLine("a and b is {0} *** {1}", a, b);
           
            }
        }
        static void Main(string[] args)
        {
        User.Name = "Venkat";
        User.Address = "Canada";
        User.Details();

        Console.WriteLine("Name Of User {0}", User.Name);
        Console.WriteLine("Address Of User {0}", User.Address);
        Console.ReadLine();

    }
    }
}
