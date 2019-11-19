using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace database.Entities
{
    public class Discount
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(Store))]
        public int storeId { get; set; }

        public string DiscountName { get; set; }
        public string DiscountDescription { get; set; }
        public int discountValue { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
