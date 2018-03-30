using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using BS_DAO;

namespace BS_BC
{
    public class FileHandling : AbstractSerialize
    {
        static string FILE_PATH_ADMIN = @"D:\DB_Admin.txt";
        static string FILE_PATH_BOOK = @"D:\DB_Book.txt";

        public override Admin ReadAdmin()
        {
            using (FileStream fs = new FileStream(FILE_PATH_ADMIN, FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Admin admin;
                admin = (Admin)bf.Deserialize(fs);
                return admin;
            }

            #region old code to write the admin credentials to the binary file.
            //using (FileStream fs = new FileStream(FILE_PATH, FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    Admin admin = new Admin() { AdminID=101, AdminName="Aranta", AdminPassword="aranta" };
            //    bf.Serialize(fs,admin);
            //    return admin;
            //}
            #endregion

        }

        public override void ReadBookList()
        {
            using (FileStream fs = new FileStream(FILE_PATH_BOOK, FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                BookList BookListObj = BookList.GetBookList();
                BookListObj.ListOfBooks = (List<Book>)bf.Deserialize(fs);
                
            }
        }

        public override void WriteBookList()
        {
            using (FileStream fs = new FileStream(FILE_PATH_BOOK, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                BookList BookListObj = BookList.GetBookList();
                bf.Serialize(fs,BookListObj.ListOfBooks);
            }
        }

    }
}
