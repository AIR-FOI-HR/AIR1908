using core;
using database;
using database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountLocator19.loaders
{
    public class DbDataLoader : DataLoader
    {
        public override void loadData(DataLoadedListener dataLoadedListener)
        {
            base.loadData(dataLoadedListener);
            try
            {
                stores = Database.DatabasePath.GetStores().Result;
                discounts = Database.DatabasePath.GetDiscounts().Result;

                mdataLoadedListener.onDataLoaded(stores, discounts);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
