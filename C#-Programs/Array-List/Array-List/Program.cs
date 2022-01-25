using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            p.ArrayFor();
            p.ListFor();
            p.ArrayForeach();
            p.ListForeach();
        }
        public void ArrayFor()
        {
            string[] animals = new string[4] { "Deer", "Rabbit", "Loin", "Tiger" };

            Console.WriteLine("Animals :");
            for (int i = 0; i < animals.Length; i++)
            {
                
                Console.WriteLine(animals[i]);
            }
           
            Console.ReadLine();
        }
        public void ArrayForeach()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Numbers :");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
        public void ListFor()
        {
            List<string> Names = new List<string>();
            Names.Add("Abhinav");
            Names.Add("Bhuvi");
            Names.Add("Charles");
            Names.Add("Daniel");

            Console.WriteLine("Names :");
            for (int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine(Names[i]);

            }
            Console.ReadLine();
        }
        public void ListForeach()
        {
            List<int> integers = new List<int>();

            integers.Add(23);
            integers.Add(27);
            integers.Add(29);
            integers.Add(31);
            integers.Add(33);

            Console.WriteLine("Numbers :");

            foreach (int num in integers)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
