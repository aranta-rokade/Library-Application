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

namespace BS_UI
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }
        LibraryForm libForm;
        private void bt_login_Click(object sender, EventArgs e)
        {
            if (tbx_user_name.Text.ToString() == "" || tbx_password.Text.ToString() == "")
            {
                MessageBox.Show("Enter your credentials.");
            }
            else
            {
                int userID = Convert.ToInt32(tbx_user_name.Text.ToString());
                string password = tbx_password.Text.ToString();

                Login loginObj = new Login();
                if (loginObj.ValidateAdmin(userID, password))
                {
                    this.Hide();
                    libForm = new LibraryForm();
                    libForm.Show();
                    MessageBox.Show("Login Successful.");
                }
                else
                {
                    MessageBox.Show("Login Failed.");
                }
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
