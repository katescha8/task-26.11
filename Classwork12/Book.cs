using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork12
{
    class Book
    {
        public string author;
        public string title;
        public string publishing;
        public Book(string author, string title, string publishing, BookContainer bc)
        {
            this.author = author;
            this.title = title;
            this.publishing = publishing;
            bc.books.Add(this);
        }
    }
    class BookContainer
    {
        public List<Book> books = new List<Book>();
        public void Sort(BookSort bs)
        {
            
        }
    }
}
