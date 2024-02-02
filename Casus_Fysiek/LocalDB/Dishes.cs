using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casus_Fysiek.LocalDB
{
    class Dishes
    {
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
        public string DishName
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
