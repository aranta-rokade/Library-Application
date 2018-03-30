using System;

namespace BS_DAO
{
    [Serializable]
    public class Admin
    {
        public  int AdminID { get;  set; }
        public  string AdminName { get;  set; }
        public string AdminPassword { get; set; }

        public Admin()
        {

        }
    }
}
