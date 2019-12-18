using database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace core
{
    public abstract class DataLoader
    {
        public List<Store> stores;
        public List<Discount> discounts;

        protected DataLoadedListener mdataLoadedListener;

        public virtual void loadData(DataLoadedListener dataLoadedListener)
        {
            this.mdataLoadedListener = dataLoadedListener;

        }

        public bool dataLoaded()
        {
            if (stores == null || discounts == null)
            {
                return false;
            }
            return true;
        }

    }
}
