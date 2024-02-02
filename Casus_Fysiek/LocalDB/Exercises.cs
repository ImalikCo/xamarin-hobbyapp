using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casus_Fysiek.LocalDB
{
    public class Exercises
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }
        [MaxLength(20)]
        public string CreatedByUser
        {
            get;
            set;
        }
        [MaxLength(20)]
        public string Exercise
        {
            get;
            set;
        }
        [MaxLength(200)]
        public string Description
        {
            get;
            set;
        }
        [MaxLength(300)]
        public string Tips
        {
            get;
            set;
        }
    }

    
}
