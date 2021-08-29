using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Unary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int result;

            Console.WriteLine("a is " + a);
            result = ++a;
            Console.WriteLine("Pre increment of a is : " + a);

            Console.WriteLine("a is " + a);
            result = a++;
            Console.WriteLine("Post increment of a is : " + a);

            Console.WriteLine("a is " + a);
            result = --a;
            Console.WriteLine("Pre decrement of a is : " + a);

            Console.WriteLine("a is " + a);
            result = a--;
            Console.WriteLine("Post decrement of a is : " + a);

            Console.ReadLine();

        }
    }
}
