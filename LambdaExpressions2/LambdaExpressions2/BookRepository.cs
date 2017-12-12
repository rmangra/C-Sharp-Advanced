using System.Collections.Generic;

namespace LambdaExpressions2
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 7},
                new Book() {Title = "Title 3", Price = 9},
                new Book() {Title = "Title 4", Price = 12},
                new Book() {Title = "Title 5", Price = 17}
            };
        }
    }
}