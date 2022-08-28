using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deletegates_Assignment14
{
    internal class Program
    {
        public delegate void num();
        public void divisibleBy3()
        {
            int[] arr = new int[] { 5, 9, 15, 21, 25, 42, 100, 200, 300, 500, 600, 900 };
            int n = 3;
            int length = arr.Length;
            Console.WriteLine("Delegates Method");
            Console.WriteLine("Numbers Divisible by 3 in the given list: ");
            for (int i = 0; i < length; i++)
            {
                if (arr[i] % n == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        public void lambdaExpression()
        {
            List<int> numbers = new List<int>() { 5, 9, 15, 21, 42, 100, 200, 300, 600, 900 };
            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);
            Console.WriteLine("Lambda Expression Method");
            Console.WriteLine("Numbers Divisible by 3 in the given list: ");
            foreach (var value in divBy3)
            {
                Console.WriteLine(value);
            }
        }
        static void Main(string[] args)
        {
            Program del = new Program();
            num del_obj = new num(del.divisibleBy3);
            del_obj();
            del.lambdaExpression();
            Console.ReadLine();
        }
    }
}
