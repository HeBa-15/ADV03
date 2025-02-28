using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate string BookDelegate(Book b);

    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> book,/*pointer to bookfunciton*/ BookDelegate fptr)
        {
            foreach (Book b in book)
            {
                Console.WriteLine(fptr.Invoke(b));

            }
        }   
        

        public static void ProcessBooks2(List<Book> book,/*pointer to bookfunciton*/ BookDelegate fptr)
        {
            foreach (Book b in book)
            {
                Console.WriteLine(fptr(b));

            }
        }

       
    }
}
