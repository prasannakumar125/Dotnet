using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pleaseenter econd number");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("sum of two numbers" + sum);
            Console.ReadLine();
        }
    }
}
