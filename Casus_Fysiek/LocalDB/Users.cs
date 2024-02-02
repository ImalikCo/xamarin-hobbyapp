using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casus_Fysiek.LocalDB
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }
        [MaxLength(20)]
        public string Username
        {
            get;
            set;
        }
        [MaxLength(20)]
        public string Password
        {
            get;
            set;
        }
    }
}
