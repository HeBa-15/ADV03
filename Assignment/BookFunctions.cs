using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BookFunctions
    {
        public static string GetTitle(Book b)
        {
           if (b is not null)
            {
                return  $"Title: {b.Title}";
            }
            else
            {
                return "Not Found";
            }
        }
        public static string GetAuthors(Book b)
        {
            if (b is not null)
            {
                string Authors =string.Join(",", b.Authors);
                return $"Authors: {Authors}";
            }
            else
            {
                return "Not Found";
            }

        }

        public static string GetPrice(Book b)
        {
            if (b is not null)
            {
                return $"Price: {b.Price}";
            }
            else
            {
                return "Not Found";
            }
        }
    }
}
