using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace database
{
    public abstract class Database
    {
        static MyDatabase database;

        public static database.MyDatabase DatabasePath
        {
            get
            {
                if (database == null)
                {
                    database = new MyDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db3"));
                }
                return database;
            }
        }
    }
}
