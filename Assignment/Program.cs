
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Book> books = new List<Book>()
            {
                new Book("1", "C#", new [] { "Ahmed", "Mohamed", "Ahmed" }, DateTime.Now, 20),
                new Book("2", "OOP", new [] { "Ali", "Mohamed", "Ahmed" }, DateTime.Now, 30),
                new Book("3", "LINQ", new [] { "Yousef", "Mohamed", "Ahmed" }, DateTime.Now, 40)

                    
            };

            #region A)
            // BookDelegate title = BookFunctions.GetTitle;
            // BookDelegate Price = BookFunctions.GetPrice;
            // BookDelegate authors = BookFunctions.GetAuthors;

            //LibraryEngine.ProcessBooks(books, title);
            //LibraryEngine.ProcessBooks(books, Price);
            //LibraryEngine.ProcessBooks(books, authors);



            #endregion

            #region b)

            Func<Book, string> func = BookFunctions.GetTitle;
            // LibraryEngine.ProcessBooks2(books,func);
            #endregion

            #region c)
            LibraryEngine.ProcessBooks2(books, delegate (Book b)
            {
                return b.ISBN;
            });
            #endregion

            #region d)
            LibraryEngine.ProcessBooks2(books, b => $"PublicationDate:{b.PublicationDate}");
            #endregion
        }
    }
}