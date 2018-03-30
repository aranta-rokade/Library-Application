namespace BS_UI
{
    partial class LibraryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_availableBooks = new System.Windows.Forms.ListBox();
            this.lbx_issuedBooks = new System.Windows.Forms.ListBox();
            this.lbl_availableBooks = new System.Windows.Forms.Label();
            this.lbl_issuedBooks = new System.Windows.Forms.Label();
            this.lbl_bookName = new System.Windows.Forms.Label();
            this.lbl_bookAuthor = new System.Windows.Forms.Label();
            this.tbx_bookName = new System.Windows.Forms.TextBox();
            this.tbx_bookAuthor = new System.Windows.Forms.TextBox();
            this.bt_addNewBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_logout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_availableBooks
            // 
            this.lbx_availableBooks.FormattingEnabled = true;
            this.lbx_availableBooks.Location = new System.Drawing.Point(57, 254);
            this.lbx_availableBooks.Name = "lbx_availableBooks";
            this.lbx_availableBooks.Size = new System.Drawing.Size(394, 277);
            this.lbx_availableBooks.TabIndex = 0;
            this.lbx_availableBooks.SelectedIndexChanged += new System.EventHandler(this.lbx_availableBooks_SelectedIndexChanged);
            // 
            // lbx_issuedBooks
            // 
            this.lbx_issuedBooks.FormattingEnabled = true;
            this.lbx_issuedBooks.Location = new System.Drawing.Point(509, 254);
            this.lbx_issuedBooks.Name = "lbx_issuedBooks";
            this.lbx_issuedBooks.Size = new System.Drawing.Size(394, 277);
            this.lbx_issuedBooks.TabIndex = 1;
            this.lbx_issuedBooks.SelectedIndexChanged += new System.EventHandler(this.lbx_issuedBooks_SelectedIndexChanged);
            // 
            // lbl_availableBooks
            // 
            this.lbl_availableBooks.AutoSize = true;
            this.lbl_availableBooks.Location = new System.Drawing.Point(54, 223);
            this.lbl_availableBooks.Name = "lbl_availableBooks";
            this.lbl_availableBooks.Size = new System.Drawing.Size(83, 13);
            this.lbl_availableBooks.TabIndex = 2;
            this.lbl_availableBooks.Text = "Available Books";
            // 
            // lbl_issuedBooks
            // 
            this.lbl_issuedBooks.AutoSize = true;
            this.lbl_issuedBooks.Location = new System.Drawing.Point(570, 223);
            this.lbl_issuedBooks.Name = "lbl_issuedBooks";
            this.lbl_issuedBooks.Size = new System.Drawing.Size(71, 13);
            this.lbl_issuedBooks.TabIndex = 3;
            this.lbl_issuedBooks.Text = "Issued Books";
            // 
            // lbl_bookName
            // 
            this.lbl_bookName.AutoSize = true;
            this.lbl_bookName.Location = new System.Drawing.Point(67, 40);
            this.lbl_bookName.Name = "lbl_bookName";
            this.lbl_bookName.Size = new System.Drawing.Size(69, 13);
            this.lbl_bookName.TabIndex = 5;
            this.lbl_bookName.Text = "Book Name :";
            // 
            // lbl_bookAuthor
            // 
            this.lbl_bookAuthor.AutoSize = true;
            this.lbl_bookAuthor.Location = new System.Drawing.Point(64, 80);
            this.lbl_bookAuthor.Name = "lbl_bookAuthor";
            this.lbl_bookAuthor.Size = new System.Drawing.Size(72, 13);
            this.lbl_bookAuthor.TabIndex = 6;
            this.lbl_bookAuthor.Text = "Book Author :";
            // 
            // tbx_bookName
            // 
            this.tbx_bookName.Location = new System.Drawing.Point(178, 37);
            this.tbx_bookName.Name = "tbx_bookName";
            this.tbx_bookName.Size = new System.Drawing.Size(545, 20);
            this.tbx_bookName.TabIndex = 7;
            // 
            // tbx_bookAuthor
            // 
            this.tbx_bookAuthor.Location = new System.Drawing.Point(178, 73);
            this.tbx_bookAuthor.Name = "tbx_bookAuthor";
            this.tbx_bookAuthor.Size = new System.Drawing.Size(545, 20);
            this.tbx_bookAuthor.TabIndex = 8;
            // 
            // bt_addNewBook
            // 
            this.bt_addNewBook.Location = new System.Drawing.Point(61, 110);
            this.bt_addNewBook.Name = "bt_addNewBook";
            this.bt_addNewBook.Size = new System.Drawing.Size(75, 23);
            this.bt_addNewBook.TabIndex = 9;
            this.bt_addNewBook.Text = "Add";
            this.bt_addNewBook.UseVisualStyleBackColor = true;
            this.bt_addNewBook.Click += new System.EventHandler(this.bt_addNewBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_bookName);
            this.groupBox1.Controls.Add(this.bt_addNewBook);
            this.groupBox1.Controls.Add(this.lbl_bookName);
            this.groupBox1.Controls.Add(this.tbx_bookAuthor);
            this.groupBox1.Controls.Add(this.lbl_bookAuthor);
            this.groupBox1.Location = new System.Drawing.Point(57, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 149);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Book";
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(872, 13);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(75, 23);
            this.bt_logout.TabIndex = 11;
            this.bt_logout.Text = "Logout";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 559);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_issuedBooks);
            this.Controls.Add(this.lbl_availableBooks);
            this.Controls.Add(this.lbx_issuedBooks);
            this.Controls.Add(this.lbx_availableBooks);
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_availableBooks;
        private System.Windows.Forms.ListBox lbx_issuedBooks;
        private System.Windows.Forms.Label lbl_availableBooks;
        private System.Windows.Forms.Label lbl_issuedBooks;
        private System.Windows.Forms.Label lbl_bookName;
        private System.Windows.Forms.Label lbl_bookAuthor;
        private System.Windows.Forms.TextBox tbx_bookName;
        private System.Windows.Forms.TextBox tbx_bookAuthor;
        private System.Windows.Forms.Button bt_addNewBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_logout;
    }
}