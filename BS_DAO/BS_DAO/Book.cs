using System;

namespace BS_DAO
{
    [Serializable]
    public class Book
    {
        [NonSerialized]
        public static int BookCount;

        public int BookID { get;  set; }
        public string BookName { get; private set; }
        public string BookAuthor { get; private set; }
        public bool BookIssued { get; set; }

        private DateTime _IssueDate;
        public DateTime IssueDate
        {
            get { return _IssueDate; }
            set { _IssueDate = value; }
        }

        private DateTime _ReturnDate;
        public DateTime ReturnDate
        {
            get { return _ReturnDate; }
            set { _ReturnDate = value; }
        }
        
        public Book(string name, string author)
        {
            this.BookID = BookCount;
            this.BookName = name;
            this.BookAuthor = author;
            this.BookIssued = false;
            BookCount++;
        }

    }
}
