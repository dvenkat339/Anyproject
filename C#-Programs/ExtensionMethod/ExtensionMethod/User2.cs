using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class MyClassNew
    {
        public static void M4(this MyClass myClass)
        {
            Console.WriteLine("This is from Method4");
        }
        public static void M5(this MyClass myClass)
        {
            Console.WriteLine("This is from Method5");
        }
    }
}
