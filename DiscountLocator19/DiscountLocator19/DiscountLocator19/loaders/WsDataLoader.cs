using core;
using database;
using database.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using webservice;

namespace DiscountLocator19.loaders
{
    public class WsDataLoader : DataLoader
    {
        private bool storesArrived = false;
        private bool discountsArrived = false;

        public override void loadData(DataLoadedListener dataLoadedListener)
        {
            base.loadData(dataLoadedListener);
            var request =
            new Dictionary<String, String>();
            request.Add("method", "getAll");
            //MyWebServiceCaller storeCaller = new MyWebServiceCaller(storeHandler);
           // MyWebServiceCaller discountCaller = new MyWebServiceCaller(discountsHandler);
           // storeCaller.getAll(request, "store");
            //discountCaller.getAll(request, "discount");
        }
        public bool isDataLoaded() { return false; }
    
    }
    
    

}

