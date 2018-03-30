using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BS_DAO
{
    public class BookList
    {
        private static BookList BookListObj = null;
        public List<Book> ListOfBooks = new List<Book>();
        public static int index = 0;
        
        private BookList()
        {
            
        }

        public static BookList GetBookList()
        {
            if (BookListObj == null)
            {
                BookListObj = new BookList();
            }
            return BookListObj;
        }


        public bool AddBook(string name, string author)
        {
            Book newBook = new Book(name, author);
            ListOfBooks.Add(newBook);
            return true;
        }

        public void IssueBook(Book book)
        {
            book.IssueDate = System.DateTime.Now;
            book.ReturnDate = book.IssueDate.AddDays(7.0);
            book.BookIssued = true;
        }

        public void ReturnBook(Book book)
        {
            book.BookIssued = false;
        }

        public Book GetBook(int id)
        {
            foreach (Book item in ListOfBooks)
            {
                if (item.BookID == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
