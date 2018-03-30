using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS_DAO;
using BS_BC;

namespace BS_Admin
{
    public class Books
    {
        public bool AddNewBook(string bookName, string bookAuthor)
        { 
            AbstractSerialize serializeObj = new FileHandling();
            BookList bookListObj = BookList.GetBookList();
            serializeObj.ReadBookList();
            Book.BookCount = bookListObj.ListOfBooks.Count;

            if (bookListObj.AddBook(bookName, bookAuthor))
            {
                serializeObj.WriteBookList();
                return true;
            }
            else
            { return false; }
        }

        public void InitializeList()
        {
            AbstractSerialize serializeObj = new FileHandling();
            BookList bookListObj = BookList.GetBookList();
            serializeObj.ReadBookList();
            Book.BookCount = bookListObj.ListOfBooks.Count;
        }

        public Book GetBook(int id)
        {
            BookList bookListObj = BookList.GetBookList();
            return bookListObj.GetBook(id);

        }

        public bool IssueBook(Book bk)
        {
            try
            {
                BookList bookListObj = BookList.GetBookList();
                bookListObj.IssueBook(bk);

                AbstractSerialize serializeObj = new FileHandling();
                serializeObj.WriteBookList();
                return true;
            }
            catch (Exception ex)
            { return false; }

        }

        public bool ReturnBook(Book bk)
        {
            try 
            {
                BookList bookListObj = BookList.GetBookList();
                bookListObj.ReturnBook(bk);
                AbstractSerialize serializeObj = new FileHandling();
                serializeObj.WriteBookList();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }

    }
}
