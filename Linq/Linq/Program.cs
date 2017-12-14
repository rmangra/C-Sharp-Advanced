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

            var aspbook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            Console.WriteLine(aspbook == null);

            var firstbook = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(firstbook.Title + " " + firstbook.Price);

            var lastbook = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(lastbook.Title + " " + lastbook.Price);

            var pagedBooks = books.Skip(2).Take(3);
            
            foreach (var pagedbook in pagedBooks)
                Console.WriteLine(pagedbook.Title);

            var count = books.Count();
            Console.WriteLine(count);

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);
            Console.WriteLine(totalPrices);
            
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
