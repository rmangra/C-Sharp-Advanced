using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LambdaExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lambda expression syntax:
            // args => expression
            // number => number * number;

            // () = > ...
            // x => ...
            // (x, y, z) => ...

            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));

            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);

            Console.WriteLine(result);
        }

        /*  static int Square(int number)
            {
                return number * number;
            }
        */
    }
}
