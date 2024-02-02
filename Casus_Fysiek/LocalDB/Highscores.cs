using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casus_Fysiek.LocalDB
{
    class Highscores
    {
        public int Id
        {
            get;
            set;
        }
        [MaxLength(20)]
        public string NameOfUser
        {
            get;
            set;
        }
        [MaxLength(20)]
        public string PointAmount
        {
            get;
            set;
        }
    }
}
