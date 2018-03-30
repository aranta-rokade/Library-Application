using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS_DAO;
using BS_BC;

namespace BS_Admin
{
    public class Login
    {
        public bool ValidateAdmin(int userID, string password)
        {
            AbstractSerialize serializeObj = new FileHandling();
            Admin admin = serializeObj.ReadAdmin();

            if ((admin.AdminID == userID) && (admin.AdminPassword.Equals(password)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
