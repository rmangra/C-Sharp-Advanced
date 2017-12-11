using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lambda expression syntax:
            // args => expression
            number => number * number;

            Console.WriteLine(Square(5));
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}
