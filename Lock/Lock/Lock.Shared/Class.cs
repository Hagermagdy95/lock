using System;
using System.Collections.Generic;
using System.Text;

namespace Lock
{
    public class pass
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int ID { get; set; }
        public string appname { get; set; }
        public string accname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
