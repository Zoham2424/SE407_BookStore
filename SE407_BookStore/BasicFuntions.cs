using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace SE407_BookStore
{
    internal class BasicFuntions
    {
        public static Book? GetBookByTitle(string title)
        {
            using (var context = new )
            {
                return context.Books
                    .FirstOrDefault(b => b.Title == title);
            }
        }
        public static List<Book> GetAllBooks()
        {
            using (var context = new )
            {
                return context.Books.ToList();
            }
        }

    }
}
