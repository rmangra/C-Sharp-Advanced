using System;
using System.Linq;

namespace Linq
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var book in cheapBooks)
                Console.WriteLine(book);
            
            
            // More LINQ Extension Methods
            //books.OrderBy(b => b.Title)
            //Func<int, int, int> add = (a, b) => a + b;
            //Console.WriteLine(add(2, 3));
        }

        private static float CalculateDiscount(float price)
        {
            return 0;
        }
    }
}
