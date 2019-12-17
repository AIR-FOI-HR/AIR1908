using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace database.Entities
{
    public class Store
    {
        public static MyDatabase database;

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public long Longitude { get; set; }
        public long Latitude { get; set; }

        public static List<Store> getAll()
        {
            return database.GetStores();
        }

        List<Discount> discountList;
  
        public List<Discount> getDiscountList() {
            if (discountList == null || discountList.Count() == 0)
	        {
                discountList = database.GetDiscountsByStoreId(storeID);
	        }
            return discountList;
        }

    }
}
