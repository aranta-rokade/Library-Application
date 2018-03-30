using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BS_Admin;
using BS_DAO;
namespace BS_UI
{
    public partial class LibraryForm : Form
    {
        static BookList list = BookList.GetBookList();

        public LibraryForm()
        {
            InitializeComponent();
            Books bk = new Books();
            bk.InitializeList();
            Fill_Listboxes();
        }


        public void Fill_Listboxes()
        {
            lbx_availableBooks.Items.Clear();
            lbx_issuedBooks.Items.Clear();

            foreach (Book item in list.ListOfBooks)
            {
                if (item.BookIssued == false)
                {
                    lbx_availableBooks.Items.Add(String.Format("ID : {0}, Book : {1}, Author : {2}", item.BookID, item.BookName, item.BookAuthor));
                }
                else
                {
                    lbx_issuedBooks.Items.Add(String.Format("ID : {0}, Book : {1}, Author : {2}", item.BookID, item.BookName, item.BookAuthor));
                }
            }
        }

        private void bt_addNewBook_Click(object sender, EventArgs e)
        {
            string bookName = tbx_bookName.Text.ToString();
            string bookAuthor = tbx_bookAuthor.Text.ToString();

            Books bookObj = new Books();
            if (bookObj.AddNewBook(bookName, bookAuthor))
            {
                MessageBox.Show("New Book Added.");
            }
            Fill_Listboxes();
            tbx_bookName.Text = "";
            tbx_bookAuthor.Text = "";
        }

        private void lbx_availableBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Index : " + lbx_availableBooks.SelectedItem + ", VAlue : " + lbx_availableBooks.SelectedValue);
            //MessageBox.Show(lbx_availableBooks.SelectedIndex.ToString());

            string id = lbx_availableBooks.SelectedItem.ToString().Split(',')[0];
            //MessageBox.Show(id);
            int ID = Convert.ToInt32(id.Substring(5));
            //MessageBox.Show(ID.ToString());

            Books bookObj = new Books();
            Book book = bookObj.GetBook(ID);

            var confirmResult = MessageBox.Show("ID : " + book.BookID + "\nName : " + book.BookName + "\nAuthor : " + book.BookAuthor + "\n\nAre you sure you want to issue this book?",
                                     "Issue book ??",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //BookList bookListObj = BookList.GetBookList();
                //bookListObj.IssueBook(book);
                if (bookObj.IssueBook(book)==false)
                {
                    MessageBox.Show("Oops! Some error occured.");
                }
                Fill_Listboxes();
            }
            else
            {
                
            }
        }

        private void lbx_issuedBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = lbx_issuedBooks.SelectedItem.ToString().Split(',')[0];
            //MessageBox.Show(id);
            int ID = Convert.ToInt32(id.Substring(5));
            //MessageBox.Show(ID.ToString());

            Books bookObj = new Books();
            Book book = bookObj.GetBook(ID);

            var confirmResult = MessageBox.Show("ID : "+book.BookID+"\nName : "+book.BookName+"\nAuthor : "+book.BookAuthor+"\nIssue Date : "+book.IssueDate+"\nReturn Date : "+book.ReturnDate+"\n\nAre you sure you want to return this book?",
                                    "Return book ??",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (bookObj.ReturnBook(book) == false)
                {
                    MessageBox.Show("Oops! Some error occured.");
                }
                Fill_Listboxes();
            }
            else
            {

            }
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_login form_login = new form_login();
            form_login.Show();
        }
    }
}
