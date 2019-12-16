using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace database.Entities
{
    public class Store
    {
        readonly SQLiteAsyncConnection _database;

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public long Longitude { get; set; }
        public long Latitude { get; set; }
    }
}
