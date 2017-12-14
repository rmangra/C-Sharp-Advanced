using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(2, 3));
        }

        private static float CalculateDiscount(float price)
        {
            return 0;
        }
    }
}
